using System.Drawing;
using System.Linq;

namespace LifeView
{
    public static class FieldExtensions
    {
        private static int countCows;
        private static int countColumns;

        public static void Apply(this Square[][] life, string figure, Point startPosition)
        {
            var test = Parse(figure);
            int startRow = startPosition.Y;
            int startColumn = startPosition.X;
            for (int row = 0; row < countCows; row++)
            {
                for (int column = 0; column < countColumns; column++)
                {
                    if(startRow + row < life.Length && startColumn + column < life[startRow + row].Length)
                        life[startRow + row][startColumn + column].isAlive = test[row][column];
                }
            }
        }
        
        private static bool[][] Parse(string figure)
        {
            var rows = figure.Split('\n').Select(x => x.Trim()).ToArray();
            countCows = rows.Length;
            countColumns = rows[0].Length;
            return rows.Select(x => x.Select(y => y == '#').ToArray()).ToArray();
        }
    }
}
