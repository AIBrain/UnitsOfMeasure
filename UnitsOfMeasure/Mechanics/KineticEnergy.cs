using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mechanics
{
    public class KineticEnergy<M, L, T> : Composite<M, Composite<Velocity<L, T>, Velocity<L, T>>>
        where M : Mass.Mass, new()
        where L : Length.Length, new()
        where T : Time.Time, new()
    {
    }
}
