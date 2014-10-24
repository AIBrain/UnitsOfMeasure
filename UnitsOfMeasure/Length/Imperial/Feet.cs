namespace UnitsOfMeasure.Length.Imperial {

    using Metric;

    public class Feet : Length {

        public static explicit operator Feet( double v ) {
            return new Feet {
                Value = v
            };
        }

        public static implicit operator Feet( Inches obj ) {
            return new Feet {
                Value = obj.Value * 0.08333333333333333333333333333333
            };
        }

        public static implicit operator Feet( Miles obj ) {
            return new Feet {
                Value = obj.Value * 5280
            };
        }

        public static implicit operator Feet( Millimeters obj ) {
            return new Feet {
                Value = obj.Value * 3280.8
            };
        }

        public static implicit operator Feet( Centimeters obj ) {
            return new Feet {
                Value = obj.Value * 328.08
            };
        }

        public static implicit operator Feet( Meters obj ) {
            return new Feet {
                Value = obj.Value * 3.2808
            };
        }

        public static implicit operator Feet( Kilometers obj ) {
            return new Feet {
                Value = obj.Value * 0.0032808
            };
        }
    }
}