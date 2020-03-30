using System.Drawing;

namespace LifeView
{
    public class FormOfLife
    {
        private const int rows = 5;
        private const int columns = 5;
        private bool[][] livingPosition;

        public FormOfLife()
        {
            livingPosition = new bool[rows][]
            {
                new bool[columns] { false, false, true, false, true },
                new bool[columns] { false, true, true, false, false },
                new bool[columns] { false, false, true, true, true },
                new bool[columns] { true, false, true, true, true },
                new bool[columns] { false, false, true, true, false }

            };
        }

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
