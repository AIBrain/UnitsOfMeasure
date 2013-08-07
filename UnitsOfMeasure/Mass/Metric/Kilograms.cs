using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mass.Metric
{
    public class Kilograms : Mass
    {
        public static explicit operator Kilograms(double v)
        {
            return new Kilograms { Value = v };
        }


    }
}
