namespace LifeView
{
    public class GameStrategy
    {        
        public Square[][] Apply(ref Square[][] life)
        {
            Square nextSquare = null;
            Square prevSquare = null;
            for (int row = 0; row < life.Length; row++)
            {
                for (int column = 0; column < life[row].Length; column++)
                {
                    var square = life[row][column];
                    if (nextSquare == null && prevSquare == null)
                    {
                        if (column == life[row].Length - 1)
                        {
                            nextSquare = life[row][0];
                            prevSquare = life[row][life[row].Length - 2];
                        }
                        else
                        {
                            nextSquare = life[row][column + 1];
                            prevSquare = life[row][life[row].Length - 1];
                        }

                    }
                    prevSquare = square.Clone();
                    if (column >= life[row].Length - 2)
                    {
                        if (column == life[row].Length - 2)
                            nextSquare = life[row][0];
                        else if (life[row].Length > 2)
                            nextSquare = life[row][1];
                    }
                    else
                        nextSquare = life[row][column + 2];

                    if (!prevSquare.isAlive && square.isAlive && !nextSquare.isAlive)
                    {
                        square.isAlive = false;                        
                        continue;
                    }
                    if (prevSquare.isAlive && !square.isAlive && !nextSquare.isAlive)
                    {
                        square.isAlive = true;
                        continue;
                    }
                }
            }
            return life;
        }
    }
}
