using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mechanics
{
    public class Acceleration<T, U> : Composite<Delta<Velocity<T, U>>, Reciprocal<Delta<U>>>
        where T : SpatialProperty, new()
        where U : Time.Time, new()
    {
    }

    public static class AccelerationMixin
    {
        public static Delta<Velocity<T, U>> Multiply<T, U>(this Acceleration<T, U> a, U b)
            where T : SpatialProperty, new()
            where U : Time.Time, new()
        {
            return new Delta<Velocity<T, U>> { Value = a.Value * b.Value };
        }

        public static Acceleration<T, U> Divide<T, U>(this Delta<Velocity<T, U>> a, Delta<U> b)
            where T : SpatialProperty, new()
            where U : Time.Time, new()
        {
            return new Acceleration<T, U> { Value = a.Value / b.Value };
        }
    }
}
