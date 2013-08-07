using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mechanics
{
    public class Density<M, L> : Composite<M, Reciprocal<Length.Volume<L>>>
        where M : Mass.Mass, new()
        where L : Length.Length, new()
    {
    }
}
