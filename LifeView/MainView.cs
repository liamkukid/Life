using LifeView.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LifeView
{
    public partial class MainView : Form
    {
        private int sideOfSquare = 10;
        private int countColumns = 60;
        private int countRows = 60;
        private Square[][] field;
        private LifeStrategy strategy = new LifeStrategy();
        private Timer timer = new Timer();

        public MainView()
        {
            InitializeComponent();
            CreateField();
            ClientSize = new Size(sideOfSquare * countColumns, sideOfSquare * countRows + toolStrip1.Height);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Игра жизнь";
            Icon = Resources.microbe;
            toolStripDropDownButton1.Image = Resources.edit.ToBitmap();
            toolStripDropDownButton2.Image = Resources.add.ToBitmap();
            timer.Interval = 100;
            KeyPress += MainView_KeyPress;
            MouseDown += MainView_MouseDown;
            MouseMove += MainView_MouseMove;
            timer.Tick += TimerTick;
        }

        private void MainView_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
                SetLiveByMousePosition(e);
        }

        private void MainView_MouseDown(object sender, MouseEventArgs e)
        {
            SetLiveByMousePosition(e);
        }

        private void SetLiveByMousePosition(MouseEventArgs e)
        {
            var location = new Point(e.Location.X, e.Location.Y - toolStrip1.Height);
            for (int row = 0; row < field.Length; row++)
            {
                for (int column = 0; column < field[row].Length; column++)
                {
                    var square = field[row][column];
                    if (square.possition.X < location.X && square.possition.X + sideOfSquare > location.X &&
                    square.possition.Y < location.Y && square.possition.Y + sideOfSquare > location.Y)
                    {
                        field[row][column].isAlive = e.Button == MouseButtons.Left;
                        Invalidate();
                        return;
                    }
                }
            }
        }

        private void MainView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                if (timer.Enabled)
                    timer.Stop();
                else
                    timer.Start();
            }
            if (e.KeyChar == 'c' || e.KeyChar == 'с')
            {
                Clear();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            foreach (var row in field)
            {
                foreach (var square in row)
                {                    
                    var color = (square.isAlive) ? Brushes.Black : Brushes.White;
                    e.Graphics.FillRectangle(color, square.possition.X, square.possition.Y + toolStrip1.Height, sideOfSquare, sideOfSquare);
                    e.Graphics.DrawRectangle(new Pen(Color.Gray), square.possition.X, square.possition.Y + toolStrip1.Height, sideOfSquare, sideOfSquare);
                }
            }
        }

        private void TimerTick(object sender, EventArgs args)
        {
            field = strategy.Apply(field);
            Invalidate();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();   
        }

        private void CreateField()
        {
            int currentXPos = 0;
            int currentYPos = 0;
            field = new Square[countRows][];

            for (int row = 0; row < field.Length; row++)
            {
                currentXPos = 0;
                field[row] = new Square[countColumns];
                for (int column = 0; column < field[row].Length; column++)
                {
                    field[row][column] = new Square(new Point(currentXPos, currentYPos));
                    currentXPos += sideOfSquare;
                }
                currentYPos += sideOfSquare;
            }
        }

        private void Clear()
        {
            CreateField();
            Invalidate();
            timer.Stop();
        }

        private void addGliderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
            field.Apply(Resources.Glaider, new Point(10, 10));
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
            field.Apply(Resources.Row, new Point(10, 10));
        }

        private void добавитьСотыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
            field.Apply(Resources.Honeycomb, new Point(10, 10));
        }

        private void добавитьПалкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
            field.Apply(Resources.Stick, new Point(10, 10));
        }
    }
}
