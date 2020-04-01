using System.Drawing;
using System.Linq;

namespace LifeView
{
    public static class FieldExtensions
    {
        private static int countCows;
        private static int countColumns;

        public static void Apply(this Field field, string figure, Point startPosition)
        {
            var parsedFigure = Parse(figure);
            int startRow = startPosition.Y;
            int startColumn = startPosition.X;
            for (int row = 0; row < countCows; row++)
            {
                for (int column = 0; column < countColumns; column++)
                {
                    if(startRow + row < field.countRows && startColumn + column < field.countColumns)
                        field.ChangeState(startColumn + column, startRow + row, parsedFigure[row][column]);
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
