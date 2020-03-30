using System.Drawing;

namespace LifeView
{
    public class FormOfLife
    {
        private int rows = 1;
        private int columns = 1;
        //private bool[][] livingPosition = new bool[1][]
        //{
        //    new bool[5] { true, true, true, true, true }
        //};

        private bool[][] livingPosition = new bool[1][]
        {
            new bool[1] { true }
        };

        public Square[][] ApplyFormOfLife(Square[][] life, Point startPosition)
        {
            int startRow = startPosition.Y;
            int startColumn = startPosition.X;
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    life[startRow + row][startColumn + column].isAlive = livingPosition[row][column];
                }
            }
            return life;
        }
    }
}
