using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Metric
{
    public class Millimeters : Length
    {
        public static implicit operator Millimeters(Centimeters obj)
        {
            return new Millimeters { Value = obj.Value * 10 };
        }

        public static implicit operator Millimeters(Meters obj)
        {
            return new Millimeters { Value = obj.Value * 1000 };
        }

        public static implicit operator Millimeters(Kilometers obj)
        {
            return new Millimeters { Value = obj.Value * 1000000 };
        }
    }
}
