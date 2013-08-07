using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mechanics
{
    public class Velocity<T, U> : Composite<Delta<T>, Reciprocal<Delta<U>>>
        where T : SpatialProperty, new()
        where U : Time.Time, new()
    {
    }

    public static class VelocityMixin
    {
        public static Delta<T> Multiply<T, U>(this Velocity<T, U> a, U b)
            where T : SpatialProperty, new()
            where U : Time.Time, new()
        {
            return new Delta<T> { Value = a.Value * b.Value };
        }

        public static Velocity<T, U> Divide<T, U>(this Delta<T> a, Delta<U> b)
            where T : SpatialProperty, new()
            where U : Time.Time, new()
        {
            return new Velocity<T, U> { Value = a.Value / b.Value };
        }
    }
}
