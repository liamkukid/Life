using System.Drawing;
using System.Linq;

namespace LifeView
{
    public class FieldWrapper : Field
    {
        public bool[][] Figure { get; private set; }
        public Field BaseField { get; private set; }        

        public FieldWrapper(Field baseField, string figureSource)
        {
            BaseField = baseField;
            for (int x = 0; x < countColumns; x++)
                for (int y = 0; y < countRows; y++)
                    ChangeState(x, y, BaseField[x, y].isAlive);
            Figure = Parse(figureSource);
        }

        public FieldWrapper(Field baseField, bool[][] figure)
        {
            BaseField = baseField;
            for (int x = 0; x < countColumns; x++)
                for (int y = 0; y < countRows; y++)
                    ChangeState(x, y, BaseField[x, y].isAlive);
            Figure = figure;
        }

        public override void Paint(Graphics graphics, int topIndent)
        {
            BaseField.Paint(graphics, topIndent);
            base.Paint(graphics, topIndent);
        }

        private bool[][] Parse(string figureSource)
        {
            var rows = figureSource.Split('\n').Select(x => x.Trim()).ToArray();            
            return rows.Select(x => x.Select(y => y == '#').ToArray()).ToArray();
        }

        public void Apply(Point point)
        {
            var positionX = point.X / sideOfSquare;
            var positionY = point.Y / sideOfSquare;
            if (positionY + Figure.Length < countRows && positionX + Figure[0].Length < countColumns)
            {
                for (int column = 0; column < countColumns; column++)
                    for (int row = 0; row < countRows; row++)
                        ChangeState(column, row, BaseField[column, row].isAlive);

                for (int row = 0; row < Figure.Length; row++)
                    for (int column = 0; column < Figure[row].Length; column++)
                        ChangeState(positionX + column, positionY + row, Figure[row][column]);
            }
        }
    }
}
