using System.Drawing;

namespace LifeView
{
    public class Glider : IFormOfLife
    {
        private const int rows = 3;
        private const int columns = 3;
        private bool[][] livingPosition;

        public Glider()
        {
            livingPosition = new bool[rows][]
            {
                new bool[columns] { false, false, true },
                new bool[columns] { true, false, true },
                new bool[columns] { false, true, true }
            };
        }

        public Square[][] Apply(Square[][] life, Point startPosition)
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
