using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mass.Imperial
{
    public class Ounces : Mass
    {
        public static explicit operator Ounces(double v)
        {
            return new Ounces { Value = v };
        }


    }
}
