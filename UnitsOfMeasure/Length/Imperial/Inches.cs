using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Imperial
{
    public class Inches : Length
    {
        public static implicit operator Inches(Feet obj)
        {
            return new Inches { Value = obj.Value * 12 };
        }

        public static implicit operator Inches(Miles obj)
        {
            return new Inches { Value = obj.Value * 63360 };
        }
    }
}
