using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure
{
    public class Composite<T, U> : UnitBase
        where T : UnitBase, new()
        where U : UnitBase, new()
    {
    }
}
