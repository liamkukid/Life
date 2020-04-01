using LifeView.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LifeView
{
    public partial class MainView : Form
    {
        private Field field;
        private LifeStrategy strategy = new LifeStrategy();
        private Timer timer = new Timer();

        public MainView(Field field)
        {
            InitializeComponent();
            this.field = field;
            ClientSize = new Size(field.width, field.height + toolStrip1.Height);
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
            field.ChageStateByLocation(location, e.Button == MouseButtons.Left, this);
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
            field.Paint(e.Graphics, toolStrip1.Height);
        }

        private void TimerTick(object sender, EventArgs args)
        {
            field = strategy.GetNextGeneration(field);
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

        private void Clear()
        {
            field = new Field();
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
