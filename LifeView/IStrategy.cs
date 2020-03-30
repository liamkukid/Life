using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeView
{
    public interface IStrategy
    {
        Square[][] Apply(Square[][] life);
    }
}
