using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Imperial
{
    public class Feet : Length
    {
        public static implicit operator Feet(Inches obj)
        {
            return new Feet { Value = obj.Value / 12 };
        }

        public static implicit operator Feet(Miles obj)
        {
            return new Feet { Value = obj.Value * 5280 };
        }
    }
}
