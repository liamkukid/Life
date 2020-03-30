using System.Drawing;

namespace LifeView
{
    public interface IFormOfLife
    {
        Square[][] Apply(Square[][] life, Point startPosition);
    }
}
