using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Imperial
{
    public class Miles : Length
    {
        public static implicit operator Miles(Inches obj)
        {
            return new Miles { Value = obj.Value / 63360 };
        }

        public static implicit operator Miles(Feet obj)
        {
            return new Miles { Value = obj.Value / 5280 };
        }
    }
}
