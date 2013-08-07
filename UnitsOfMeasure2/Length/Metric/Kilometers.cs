using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Metric
{
    public class Kilometers : Length
    {
        public static implicit operator Kilometers(Millimeters obj)
        {
            return new Kilometers { Value = obj.Value / 1000000 };
        }

        public static implicit operator Kilometers(Centimeters obj)
        {
            return new Kilometers { Value = obj.Value / 100000 };
        }

        public static implicit operator Kilometers(Meters obj)
        {
            return new Kilometers { Value = obj.Value / 1000 };
        }
    }
}
