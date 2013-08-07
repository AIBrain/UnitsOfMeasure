using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure
{
    public class Rate<T, U> : Composite<Delta<T>, Reciprocal<Delta<U>>>
        where T : UnitBase, new()
        where U : Time.Time, new()
    {
    }
}
