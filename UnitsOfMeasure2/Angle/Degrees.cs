using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Angle
{
    public class Degrees : Angle
    {
        public static implicit operator Degrees(Radians obj)
        {
            return new Degrees
            {
                Value = obj.Value * 180 / Math.PI
            };
        }
    }

    public static class DegreesMixin
    {
        public static double Cos(this Degrees a)
        {
            return ((Radians)a).Cos();
        }
    }
}
