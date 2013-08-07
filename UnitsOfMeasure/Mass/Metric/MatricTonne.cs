using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mass.Metric
{
    public class MetricTonne : Mass
    {
        public static explicit operator MetricTonne(double v)
        {
            return new MetricTonne { Value = v };
        }


    }
}
