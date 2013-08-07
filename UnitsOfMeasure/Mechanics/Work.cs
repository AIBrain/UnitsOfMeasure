using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mechanics
{
    public class Work<M, L, T> : Composite<Force<M, L, T>, L>
        where M : Mass.Mass, new()
        where L : Length.Length, new()
        where T : Time.Time, new()
    {
    }
}
