using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mechanics
{
    public class Jerk<T, U> : Composite<Delta<Delta<Delta<T>>>, Reciprocal<Delta<U>>>
        where T : SpatialProperty, new()
        where U : Time.Time, new()
    {
    }

    public static class JerkMixin
    {
        public static Delta<Acceleration<T, U>> Multiply<T, U>(this Jerk<T, U> a, U b)
            where T : SpatialProperty, new()
            where U : Time.Time, new()
        {
            return new Delta<Acceleration<T, U>> { Value = a.Value * b.Value };
        }

        public static Jerk<T, U> Divide<T, U>(this Delta<Acceleration<T, U>> a, Delta<U> b)
            where T : SpatialProperty, new()
            where U : Time.Time, new()
        {
            return new Jerk<T, U> { Value = a.Value / b.Value };
        }
    }
}
