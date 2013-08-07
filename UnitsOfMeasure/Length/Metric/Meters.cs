using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length.Metric
{
    public class Meters : Length
    {
        public static explicit operator Meters(double v)
        {
            return new Meters { Value = v };
        }


        public static implicit operator Meters(Millimeters obj)
        {
            return new Meters { Value = obj.Value * 0.001 };
        }

        public static implicit operator Meters(Centimeters obj)
        {
            return new Meters { Value = obj.Value * 0.01 };
        }

        public static implicit operator Meters(Kilometers obj)
        {
            return new Meters { Value = obj.Value * 1000 };
        }

        public static implicit operator Meters(Imperial.Inches obj)
        {
            return new Meters { Value = obj.Value * 0.0254 };
        }

        public static implicit operator Meters(Imperial.Feet obj)
        {
            return new Meters { Value = obj.Value * 0.3048 };
        }

        public static implicit operator Meters(Imperial.Miles obj)
        {
            return new Meters { Value = obj.Value * 1609.344 };
        }

        public Meters Add(Delta<Imperial.Inches> obj)
        {
            var i = new Imperial.Inches { Value = obj.Value };
            Meters v2 = i;
            return this.Add(new Delta<Meters> { Value = v2.Value });
        }

        public Meters Add(Delta<Imperial.Feet> obj)
        {
            var v = new Imperial.Feet { Value = obj.Value };
            Meters v2 = v;
            return this.Add(new Delta<Meters> { Value = v2.Value });
        }

        public Meters Add(Delta<Imperial.Miles> obj)
        {
            var v = new Imperial.Miles { Value = obj.Value };
            Meters v2 = v;
            return this.Add(new Delta<Meters> { Value = v2.Value });
        }

        public Meters Add(Delta<Metric.Millimeters> obj)
        {
            var v = new Millimeters { Value = obj.Value };
            Meters v2 = v;
            return this.Add(new Delta<Meters> { Value = v2.Value });
        }

        public Meters Add(Delta<Metric.Centimeters> obj)
        {
            var v = new Centimeters { Value = obj.Value };
            Meters v2 = v;
            return this.Add(new Delta<Meters> { Value = v2.Value });
        }

        public Meters Add(Delta<Metric.Kilometers> obj)
        {
            var v = new Kilometers { Value = obj.Value };
            Meters v2 = v;
            return this.Add(new Delta<Meters> { Value = v2.Value });
        }
    }
}
