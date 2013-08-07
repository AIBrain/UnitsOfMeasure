using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Metric
{
    public class Meters : Length
    {
        public static explicit operator Meters(double v)
        {
            return new Meters { Value = v };
        }


        public static implicit operator Meters(Millimeters obj)
        {
            return new Meters { Value = obj.Value * 0.001 };
        }

        public static implicit operator Meters(Centimeters obj)
        {
            return new Meters { Value = obj.Value * 0.01 };
        }

        public static implicit operator Meters(Kilometers obj)
        {
            return new Meters { Value = obj.Value * 1000 };
        }

        public static implicit operator Meters(Imperial.Inches obj)
        {
            return new Meters { Value = obj.Value * 0.0254 };
        }

        public static implicit operator Meters(Imperial.Feet obj)
        {
            return new Meters { Value = obj.Value * 0.3048 };
        }

        public static implicit operator Meters(Imperial.Miles obj)
        {
            return new Meters { Value = obj.Value * 1609.344 };
        }
    }
}
