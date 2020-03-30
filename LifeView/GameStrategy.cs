namespace LifeView
{
    public class GameStrategy
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
                    if(!state.isLeftAlive && !state.isRightAlive)
                        newLife[row][column].isAlive = false;
                    if (!state.isLeftAlive && state.isRightAlive)
                        newLife[row][column].isAlive = false;
                    if (state.isLeftAlive && !state.isRightAlive)
                        newLife[row][column].isAlive = true;
                    if (state.isLeftAlive && state.isRightAlive)
                        newLife[row][column].isAlive = true;
                }
            }
            return newLife;
        }
    }
}
