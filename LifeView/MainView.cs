using System;
using System.Drawing;
using System.Windows.Forms;

namespace LifeView
{
    public class MainView : Form
    {
        int sideOfSquare = 15;
        int countColumns = 80;
        int countRows = 40;
        Square[][] life;
        FormOfLife formOfLife = new FormOfLife();
        GameStrategy strategy = new GameStrategy();

        public MainView()
        {
            int currentXPos = 0;
            int currentYPos = 0;
            life = new Square[countRows][];

            for(int row = 0; row < life.Length; row ++)
            {
                currentXPos = 0;
                life[row] = new Square[countColumns];
                for (int column = 0; column < life[row].Length; column++)
                {
                    life[row][column] = new Square(new Point(currentXPos, currentYPos));
                    currentXPos += sideOfSquare;
                }
                currentYPos += sideOfSquare;
            }
            life = formOfLife.ApplyFormOfLife(life, new Point(20, 10));
            ClientSize = new Size(sideOfSquare * countColumns, sideOfSquare * countRows);
            FormBorderStyle = FormBorderStyle.FixedDialog;

            var timer = new Timer();
            timer.Interval = 500;
            timer.Tick += TimerTick;
            timer.Start();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            foreach(var row in life)
            {
                foreach(var square in row)
                {
                    var color = (square.isAlive) ? Brushes.Black : Brushes.White;
                    e.Graphics.FillRectangle(color, square.possition.X, square.possition.Y, sideOfSquare, sideOfSquare);                    
                }
            }
        }

        private void TimerTick(object sender, EventArgs args)
        {
            strategy.Apply(ref life);
            Invalidate();
        }        
    }
}
