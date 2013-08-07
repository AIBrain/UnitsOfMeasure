using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure
{
    public class Rate<T, U> : Composite<T, Reciprocal<U>>
        where T : UnitBase, new()
        where U : Time.Time, new()
    {
    }
}
