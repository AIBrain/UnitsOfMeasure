using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mechanics
{
    public class Force<T, U, V> : Composite<T, Acceleration<U, V>>
        where T : Mass.Mass, new()
        where U : SpatialProperty, new()
        where V : Time.Time, new()
    {
    }
}
