namespace UnitsOfMeasure.Length.Metric {

    using Imperial;

    public class Kilometers : Length {

        public static explicit operator Kilometers( double v ) {
            return new Kilometers {
                Value = v
            };
        }

        public static implicit operator Kilometers( Millimeters obj ) {
            return new Kilometers {
                Value = obj.Value * 0.000001
            };
        }

        public static implicit operator Kilometers( Centimeters obj ) {
            return new Kilometers {
                Value = obj.Value * 0.00001
            };
        }

        public static implicit operator Kilometers( Meters obj ) {
            return new Kilometers {
                Value = obj.Value * 0.001
            };
        }

        public static implicit operator Kilometers( Inches obj ) {
            return new Kilometers {
                Value = obj.Value * 0.0000254
            };
        }

        public static implicit operator Kilometers( Feet obj ) {
            return new Kilometers {
                Value = obj.Value * 0.0003048
            };
        }

        public static implicit operator Kilometers( Miles obj ) {
            return new Kilometers {
                Value = obj.Value * 1.609344
            };
        }
    }
}