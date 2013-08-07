using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mass.Metric
{
    public class Milligrams : Mass
    {
        public static explicit operator Milligrams(double v)
        {
            return new Milligrams { Value = v };
        }


    }
}
