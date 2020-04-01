using LifeView.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LifeView
{
    public partial class MainView : Form
    {
        private Field field;
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
            addStickToolStripMenuItem.Click += (s, e) => SetWrapper(Resources.Stick);
            addHoneycombToolStripMenuItem.Click += (s, e) => SetWrapper(Resources.Honeycomb);
            addRowToolStripMenuItem.Click += (s, e) => SetWrapper(Resources.Row);
            addGlaiderToolStripMenuItem.Click += (s, e) => SetWrapper(Resources.Glaider);
            clearToolStripMenuItem.Click += (s, e) => Clear();
            playToolStripMenuItem.Click += (s, e) => timer.Start();
            stopToolStripMenuItem.Click += (s, e) => timer.Stop();
        }

        private void MainView_MouseMove(object sender, MouseEventArgs e)
        {
            if (field is FieldWrapper fieldWrapper)
            {
                var location = new Point(e.Location.X, e.Location.Y - toolStrip1.Height);
                fieldWrapper.Apply(location);
                Invalidate();
                return;
            }
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
                SetLiveByMousePosition(e);
        }

        private void MainView_MouseDown(object sender, MouseEventArgs e)
        {
            if (field is FieldWrapper fieldWrapper && e.Button == MouseButtons.Left)
            {
                var figure = fieldWrapper.Figure;
                Field newField = fieldWrapper as Field;
                field = new FieldWrapper(newField, figure);
                Invalidate();
                return;
            }
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
            field = LifeStrategy.GetNextGeneration(field);
            Invalidate();
        }

        private void Clear()
        {
            field = new Field();
            Invalidate();
            timer.Stop();
        }

        private void SetWrapper(string figure)
        {
            field = new FieldWrapper(field, figure);
        }
    }
}
