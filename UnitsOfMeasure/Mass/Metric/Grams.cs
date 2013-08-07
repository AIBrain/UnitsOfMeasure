using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mass.Metric
{
    public class Grams : Mass
    {
        public static explicit operator Grams(double v)
        {
            return new Grams { Value = v };
        }


    }
}
