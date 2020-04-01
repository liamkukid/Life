using System.Collections.Generic;

namespace LifeView
{
    public class StateOfNeighboringCells
    {
        public List<bool> neighboringStateList = new List<bool>();

        private Field field;

        public StateOfNeighboringCells(Field field)
        {
            this.field = field;
        }

        public void CreateState(int row, int column)
        {
            if(field == null || field.countColumns <= 1 || field.countRows <= 1)
                return;

            if(row == 0)
            {
                SetState(new[] {field.countRows - 1, 0, 1 }, column);
            }
            else if (row == field.countRows - 1)
            {
                SetState(new[] { row - 1, row, 0 }, column);
            }
            else
            {
                SetState(new[] { row - 1, row, row + 1 }, column);
            }
        }

        private void SetState(int[] rows, int column)
        {
            if (column == 0)
            {
                SetState(rows, new[] { field.countColumns - 1, 0, 1 });
            }
            else if (column == field.countColumns - 1)
            {
                SetState(rows, new[] { column - 1, column, 0 });
            }
            else
            {
                SetState(rows, new[] { column - 1, column, column + 1 });
            }
        }

        private void SetState(int[] rows, int[] columns)
        {
            bool isLeftTopAlive = field[columns[0], rows[0]].isAlive;
            bool isLeftAlive = field[columns[0], rows[1]].isAlive;
            bool isLeftBottomAlive = field[columns[0], rows[2]].isAlive;
            
            bool isTopAlive = field[columns[1], rows[0]].isAlive;
            bool isBottomAlive = field[columns[1], rows[2]].isAlive;
            
            bool isRightTopAlive = field[columns[2], rows[0]].isAlive;            
            bool isRightAlive = field[columns[2], rows[1]].isAlive;
            bool isRightBottomAlive = field[columns[2], rows[2]].isAlive;

            neighboringStateList.AddRange(new List<bool> { isLeftTopAlive, isLeftAlive, isLeftBottomAlive, isTopAlive, isBottomAlive, isRightTopAlive, isRightAlive, isRightBottomAlive });
        }
    }
}
