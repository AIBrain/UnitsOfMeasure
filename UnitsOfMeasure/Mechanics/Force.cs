using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mechanics
{
    public class Force<M, L, T> : Composite<M, Acceleration<L, T>>
        where M : Mass.Mass, new()
        where L : SpatialProperty, new()
        where T : Time.Time, new()
    {
    }
}
