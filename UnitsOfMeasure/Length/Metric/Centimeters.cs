﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Metric
{
    public class Centimeters : Length
    {
        public static explicit operator Centimeters(double v)
        {
            return new Centimeters { Value = v };
        }


        public static implicit operator Centimeters(Millimeters obj)
        {
            return new Centimeters { Value = obj.Value * 0.1 };
        }

        public static implicit operator Centimeters(Meters obj)
        {
            return new Centimeters { Value = obj.Value * 100 };
        }

        public static implicit operator Centimeters(Kilometers obj)
        {
            return new Centimeters { Value = obj.Value * 100000 };
        }

        public static implicit operator Centimeters(Imperial.Inches obj)
        {
            return new Centimeters { Value = obj.Value * 2.54 };
        }

        public static implicit operator Centimeters(Imperial.Feet obj)
        {
            return new Centimeters { Value = obj.Value * 30.48 };
        }

        public static implicit operator Centimeters(Imperial.Miles obj)
        {
            return new Centimeters { Value = obj.Value * 160934.4 };
        }
    }
}
