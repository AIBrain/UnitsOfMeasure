using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mass.Imperial
{
    public class Tons : Mass
    {
        public static explicit operator Tons(double v)
        {
            return new Tons { Value = v };
        }


    }
}
