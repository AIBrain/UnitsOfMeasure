using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Imperial
{
    public class Inches : Length
    {
        public static explicit operator Inches(double v)
        {
            return new Inches { Value = v };
        }


        public static implicit operator Inches(Feet obj)
        {
            return new Inches { Value = obj.Value * 12 };
        }

        public static implicit operator Inches(Miles obj)
        {
            return new Inches { Value = obj.Value * 63360 };
        }

        public static implicit operator Inches(Metric.Millimeters obj)
        {
            return new Inches { Value = obj.Value * 3.937 };
        }

        public static implicit operator Inches(Metric.Centimeters obj)
        {
            return new Inches { Value = obj.Value * 0.3937 };
        }

        public static implicit operator Inches(Metric.Meters obj)
        {
            return new Inches { Value = obj.Value * 0.003937 };
        }

        public static implicit operator Inches(Metric.Kilometers obj)
        {
            return new Inches { Value = obj.Value * 0.000003937 };
        }


        public Inches Add(Delta<Feet> obj)
        {
            var v = new Feet { Value = obj.Value };
            Inches v2 = v;
            return this.Add(new Delta<Inches> { Value = v2.Value });
        }

        public Inches Add(Delta<Miles> obj)
        {
            var i = new Miles { Value = obj.Value };
            Inches v2 = i;
            return this.Add(new Delta<Inches> { Value = v2.Value });
        }

        public Inches Add(Delta<Metric.Millimeters> obj)
        {
            var v = new Metric.Centimeters { Value = obj.Value };
            Inches v2 = v;
            return this.Add(new Delta<Inches> { Value = v2.Value });
        }

        public Inches Add(Delta<Metric.Centimeters> obj)
        {
            var v = new Metric.Centimeters { Value = obj.Value };
            Inches v2 = v;
            return this.Add(new Delta<Inches> { Value = v2.Value });
        }

        public Inches Add(Delta<Metric.Meters> obj)
        {
            var v = new Metric.Meters { Value = obj.Value };
            Inches v2 = v;
            return this.Add(new Delta<Inches> { Value = v2.Value });
        }

        public Inches Add(Delta<Metric.Kilometers> obj)
        {
            var v = new Metric.Kilometers { Value = obj.Value };
            Inches v2 = v;
            return this.Add(new Delta<Inches> { Value = v2.Value });
        }
    }
}
