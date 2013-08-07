using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mechanics
{
    public class Velocity<L, T> : Rate<L, T>
        where L : SpatialProperty, new()
        where T : Time.Time, new()
    {
    }

    public static class VelocityMixin
    {
        public static L Multiply<L, T>(this Velocity<L, T> a, T b)
            where L : SpatialProperty, new()
            where T : Time.Time, new()
        {
            return new L { Value = a.Value * b.Value };
        }

        public static Velocity<L, T> Divide<L, T>(this L a, T b)
            where L : SpatialProperty, new()
            where T : Time.Time, new()
        {
            return new Velocity<L, T> { Value = a.Value / b.Value };
        }
    }
}
