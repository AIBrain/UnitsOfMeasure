using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Metric
{
    public class Meters : Length
    {
        public static implicit operator Meters(Millimeters obj)
        {
            return new Meters { Value = obj.Value / 1000 };
        }

        public static implicit operator Meters(Centimeters obj)
        {
            return new Meters { Value = obj.Value / 100 };
        }

        public static implicit operator Meters(Kilometers obj)
        {
            return new Meters { Value = obj.Value * 1000 };
        }
    }
}
