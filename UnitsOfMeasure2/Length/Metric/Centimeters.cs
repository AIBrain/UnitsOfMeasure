using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Metric
{
    public class Centimeters : Length
    {
        public static implicit operator Centimeters(Millimeters obj)
        {
            return new Centimeters { Value = obj.Value / 10 };
        }

        public static implicit operator Centimeters(Meters obj)
        {
            return new Centimeters { Value = obj.Value * 100 };
        }

        public static implicit operator Centimeters(Kilometers obj)
        {
            return new Centimeters { Value = obj.Value * 100000 };
        }
    }
}
