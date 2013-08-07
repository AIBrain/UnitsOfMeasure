using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Imperial
{
    public class Miles : Length
    {
        public static explicit operator Miles(double v)
        {
            return new Miles { Value = v };
        }

        public static implicit operator Miles(Inches obj)
        {
            return new Miles { Value = obj.Value * 1.5782828282828282828282828282828e-5 };
        }

        public static implicit operator Miles(Feet obj)
        {
            return new Miles { Value = obj.Value * 1.8939393939393939393939393939394e-4 };
        }

        public static implicit operator Miles(Metric.Millimeters obj)
        {
            return new Miles { Value = obj.Value * 3.937 };
        }

        public static implicit operator Miles(Metric.Centimeters obj)
        {
            return new Miles { Value = obj.Value * 0.3937 };
        }

        public static implicit operator Miles(Metric.Meters obj)
        {
            return new Miles { Value = obj.Value * 0.003937 };
        }

        public static implicit operator Miles(Metric.Kilometers obj)
        {
            return new Miles { Value = obj.Value * 0.000003937 };
        }
    }
}
