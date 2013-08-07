using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mass.Imperial
{
    public class Pounds : Mass
    {
        public static explicit operator Pounds(double v)
        {
            return new Pounds { Value = v };
        }


    }
}
