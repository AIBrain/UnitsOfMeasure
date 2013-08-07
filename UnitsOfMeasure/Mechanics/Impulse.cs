using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mechanics
{
    public class Impulse<M, L, T> : Rate<Momentum<M, L, T>, T>
        where M : Mass.Mass, new()
        where L : SpatialProperty, new()
        where T : Time.Time, new()
    {
    }
}
