namespace LifeView
{
    public class GameStrategy
    {        
        public Square[][] Apply(ref Square[][] life)
        {
            for (int row = 0; row < life.Length; row++)
            {
                for (int column = 0; column < life[row].Length; column++)
                {
                    life[row][column].isAlive = !life[row][column].isAlive;
                }
            }
            return life;
        }
    }
}
