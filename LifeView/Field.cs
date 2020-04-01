namespace LifeView
{
    public class Field
    {
        public readonly int countColumns;
        public readonly int countRows;
        public readonly int width;
        public readonly int height;

        private readonly Square[,] field;
        private int sideOfSquare = 10;

        public Field(int countColumns, int countRows)
        {
            this.countColumns = countColumns;
            this.countRows = countRows;
            width = sideOfSquare * countColumns;
            height = sideOfSquare * countRows;

            field = new Square[countColumns, countRows];
            for (int x = 0; x < countColumns; x++)
                for (int y = 0; y < countRows; y++)
                    field[x, y] = new Square();
        }
    }
}
