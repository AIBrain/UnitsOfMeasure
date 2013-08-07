using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Metric
{
    public class Millimeters : Length
    {
        public static explicit operator Millimeters(double v)
        {
            return new Millimeters { Value = v };
        }


        public static implicit operator Millimeters(Centimeters obj)
        {
            return new Millimeters { Value = obj.Value * 10 };
        }

        public static implicit operator Millimeters(Meters obj)
        {
            return new Millimeters { Value = obj.Value * 1000 };
        }

        public static implicit operator Millimeters(Kilometers obj)
        {
            return new Millimeters { Value = obj.Value * 1000000 };
        }

        public static implicit operator Millimeters(Imperial.Inches obj)
        {
            return new Millimeters { Value = obj.Value * 25.4 };
        }

        public static implicit operator Millimeters(Imperial.Feet obj)
        {
            return new Millimeters { Value = obj.Value * 304.8 };
        }

        public static implicit operator Millimeters(Imperial.Miles obj)
        {
            return new Millimeters { Value = obj.Value * 1609344 };
        }

        public Millimeters Add(Delta<Imperial.Inches> obj)
        {
            var i = new Imperial.Inches { Value = obj.Value };
            Millimeters v2 = i;
            return this.Add(new Delta<Millimeters> { Value = v2.Value });
        }

        public Millimeters Add(Delta<Imperial.Feet> obj)
        {
            var v = new Imperial.Feet { Value = obj.Value };
            Millimeters v2 = v;
            return this.Add(new Delta<Millimeters> { Value = v2.Value });
        }

        public Millimeters Add(Delta<Imperial.Miles> obj)
        {
            var v = new Imperial.Miles { Value = obj.Value };
            Millimeters v2 = v;
            return this.Add(new Delta<Millimeters> { Value = v2.Value });
        }

        public Millimeters Add(Delta<Metric.Centimeters> obj)
        {
            var v = new Centimeters { Value = obj.Value };
            Millimeters v2 = v;
            return this.Add(new Delta<Millimeters> { Value = v2.Value });
        }

        public Millimeters Add(Delta<Metric.Meters> obj)
        {
            var v = new Meters { Value = obj.Value };
            Millimeters v2 = v;
            return this.Add(new Delta<Millimeters> { Value = v2.Value });
        }

        public Millimeters Add(Delta<Metric.Kilometers> obj)
        {
            var v = new Kilometers { Value = obj.Value };
            Millimeters v2 = v;
            return this.Add(new Delta<Millimeters> { Value = v2.Value });
        }
    }
}
