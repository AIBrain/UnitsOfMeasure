using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length
{
    public abstract class Length : SpatialProperty
    {
    }

    public static class LengthMixin
    {
        public static Area<L> Multiply<L>(this L a, L b) where L : Length, new()
        {
            return new Area<L> { Value = a.Value * b.Value };
        }
    }
}
