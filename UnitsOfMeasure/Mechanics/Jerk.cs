using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mechanics
{
    public class Jerk<L, T> : Rate<Acceleration<L, T>, T>
        where L : SpatialProperty, new()
        where T : Time.Time, new()
    {
    }

    public static class JerkMixin
    {
        public static Delta<Acceleration<M, T>> Multiply<M, T>(this Jerk<M, T> a, T b)
            where M : SpatialProperty, new()
            where T : Time.Time, new()
        {
            return new Delta<Acceleration<M, T>> { Value = a.Value * b.Value };
        }

        public static Jerk<M, T> Divide<M, T>(this Delta<Acceleration<M, T>> a, Delta<T> b)
            where M : SpatialProperty, new()
            where T : Time.Time, new()
        {
            return new Jerk<M, T> { Value = a.Value / b.Value };
        }
    }
}
