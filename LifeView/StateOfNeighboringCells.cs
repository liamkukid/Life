using System.Collections.Generic;

namespace LifeView
{
    public class StateOfNeighboringCells
    {
        public List<bool> neighboringStateList = new List<bool>();

        public bool isLeftTopAlive;
        public bool isTopAlive;
        public bool isRightTopAlive;

        public bool isLeftAlive;
        public bool isRightAlive;

        public bool isRightBottomAlive;
        public bool isBottomAlive;
        public bool isLeftBottomAlive;

        private Square[][] life;

        public StateOfNeighboringCells(Square[][] life)
        {
            this.life = life;
        }

        public void CreateState(int row, int column)
        {
            if(life == null || life.Length == 1)
                return;

            if(row == 0)
            {
                SetState(new[] {life.Length - 1, 0, 1 }, column);
            }
            else if (row == life.Length - 1)
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
                SetState(rows, new[] { life[0].Length - 1, 0, 1 });
            }
            else if (column == life[0].Length - 1)
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
            isLeftTopAlive = life[rows[0]][columns[0]].isAlive;
            isLeftAlive = life[rows[1]][columns[0]].isAlive;
            isLeftBottomAlive = life[rows[2]][columns[0]].isAlive;

            isTopAlive = life[rows[0]][columns[1]].isAlive;
            isBottomAlive = life[rows[2]][columns[1]].isAlive;

            isRightTopAlive = life[rows[0]][columns[2]].isAlive;            
            isRightAlive = life[rows[1]][columns[2]].isAlive;
            isRightBottomAlive = life[rows[2]][columns[2]].isAlive;

            neighboringStateList.AddRange(new List<bool> { isLeftTopAlive, isLeftAlive, isLeftBottomAlive, isTopAlive, isBottomAlive, isRightTopAlive, isRightAlive, isRightBottomAlive });
        }
    }
}
