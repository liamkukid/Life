using System.Drawing;
using System.Windows.Forms;

namespace LifeView
{
    public class Field
    {
        public readonly int countColumns = 80;
        public readonly int countRows = 50;
        public readonly int width;
        public readonly int height;

        private readonly Square[,] field;
        private int sideOfSquare = 10;

        public Field()
        {
            width = sideOfSquare * countColumns;
            height = sideOfSquare * countRows;

            field = new Square[countColumns, countRows];
            for (int x = 0; x < countColumns; x++)
                for (int y = 0; y < countRows; y++)
                    field[x, y] = new Square(new Point(x * sideOfSquare, y * sideOfSquare));
        }

        public Square this[int x, int y]
        {
            get
            {
                return field[x, y];
            }
            set
            {
                field[x, y] = value;
            }
        }

        public void ChangeState(int x, int y, bool isAlive)
        {
            if (x < countColumns && y < countRows)
                field[x, y].isAlive = isAlive;
        }

        public void Paint(Graphics graphics, int topIndent)
        {
            foreach (var item in field)
            {
                var color = (item.isAlive) ? Brushes.Black : Brushes.White;
                graphics.FillRectangle(color, item.possition.X, item.possition.Y + topIndent, sideOfSquare, sideOfSquare);
                graphics.DrawRectangle(new Pen(Color.Gray), item.possition.X, item.possition.Y + topIndent, sideOfSquare, sideOfSquare);
            }
        }

        public void ChageStateByLocation(Point point, bool newState, Form form)
        {
            var x = point.X / sideOfSquare;
            var y = point.Y / sideOfSquare;
            if (x < countColumns && y < countRows)
            {
                field[x, y].isAlive = newState;
                form.Invalidate();
                return;
            }
        }
    }
}
