using System.Drawing;

namespace LifeView
{
    public struct Square
    {
        public Point possition;
        public bool isAlive;

        public Square(Point possition)
        {
            this.possition = possition;
            isAlive = false;
        }        
    }
}
