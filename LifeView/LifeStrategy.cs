using System.Linq;

namespace LifeView
{
    class LifeStrategy : IStrategy
    {
        public Square[][] Apply(Square[][] life)
        {
            Square[][] newLife = new Square[life.Length][];
            for (int row = 0; row < life.Length; row++)
            {
                newLife[row] = new Square[life[row].Length];
                for (int column = 0; column < life[row].Length; column++)
                {
                    newLife[row][column] = life[row][column];
                    var state = new StateOfNeighboringCells(life);
                    state.CreateState(row, column);
                    var aliveNeighboringCount = state.neighboringStateList.Where(x => x == true).Count();
                    if (life[row][column].isAlive == false && aliveNeighboringCount == 3)
                    {
                        newLife[row][column].isAlive = true;
                    }
                    if (life[row][column].isAlive == true && (aliveNeighboringCount == 3 || aliveNeighboringCount == 2))
                    {
                        newLife[row][column].isAlive = true;
                    }
                    if (life[row][column].isAlive == true && (aliveNeighboringCount > 3 || aliveNeighboringCount < 2))
                    {
                        newLife[row][column].isAlive = false;
                    }

                }
            }
            return newLife;
        }
    }
}
