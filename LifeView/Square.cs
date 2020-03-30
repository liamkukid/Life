using System.Drawing;

namespace LifeView
{
    public class Square
    {
        public Point possition;
        public bool isAlive = false;

        public Square(Point possition)
        {
            this.possition = possition;
        }

        public Square Clone()
        {
            return new Square(possition) { isAlive = this.isAlive };
        }
    }
}
