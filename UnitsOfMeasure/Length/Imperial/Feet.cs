using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Imperial
{
    public class Feet : Length
    {
        public static explicit operator Feet(double v)
        {
            return new Feet { Value = v };
        }

        public static implicit operator Feet(Inches obj)
        {
            return new Feet { Value = obj.Value * 0.08333333333333333333333333333333 };
        }

        public static implicit operator Feet(Miles obj)
        {
            return new Feet { Value = obj.Value * 5280 };
        }

        public static implicit operator Feet(Metric.Millimeters obj)
        {
            return new Feet { Value = obj.Value * 3280.8 };
        }

        public static implicit operator Feet(Metric.Centimeters obj)
        {
            return new Feet { Value = obj.Value * 328.08 };
        }

        public static implicit operator Feet(Metric.Meters obj)
        {
            return new Feet { Value = obj.Value * 3.2808 };
        }

        public static implicit operator Feet(Metric.Kilometers obj)
        {
            return new Feet { Value = obj.Value * 0.0032808 };
        }

        public Feet Add(Delta<Inches> obj){
            var v = new Inches { Value = obj.Value };
            Feet v2 = v;
            return this.Add(new Delta<Feet> { Value = v2.Value });
        }

        public Feet Add(Delta<Miles> obj)
        {
            var i = new Miles { Value = obj.Value };
            Feet v2 = i;
            return this.Add(new Delta<Feet> { Value = v2.Value });
        }

        public Feet Add(Delta<Metric.Millimeters> obj)
        {
            var v = new Metric.Centimeters { Value = obj.Value };
            Feet v2 = v;
            return this.Add(new Delta<Feet> { Value = v2.Value });
        }

        public Feet Add(Delta<Metric.Centimeters> obj)
        {
            var v = new Metric.Centimeters { Value = obj.Value };
            Feet v2 = v;
            return this.Add(new Delta<Feet> { Value = v2.Value });
        }

        public Feet Add(Delta<Metric.Meters> obj)
        {
            var v = new Metric.Meters { Value = obj.Value };
            Feet v2 = v;
            return this.Add(new Delta<Feet> { Value = v2.Value });
        }

        public Feet Add(Delta<Metric.Kilometers> obj)
        {
            var v = new Metric.Kilometers { Value = obj.Value };
            Feet v2 = v;
            return this.Add(new Delta<Feet> { Value = v2.Value });
        }
    }
}
