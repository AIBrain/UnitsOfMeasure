using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mechanics
{
    public class Momentum<M, L, T> : Composite<M, Velocity<L, T>>
        where M : Mass.Mass, new()
        where L : SpatialProperty, new()
        where T : Time.Time, new()
    {
    }
}
