using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Time
{
    public abstract class Time : UnitBase
    {
    }

    public static class TimeMixin
    {
        public static T Integrate<T, U>(this Composite<T, Reciprocal<U>> a, U b)
            where T : UnitBase, new()
            where U : Time, new()
        {
            return new T { Value = a.Value * b.Value };
        }
    }
}
