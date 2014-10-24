namespace UnitsOfMeasure.Length.Metric {

    using Imperial;

    public class Centimeters : Length {

        public static explicit operator Centimeters( double v ) {
            return new Centimeters {
                Value = v
            };
        }

        public static implicit operator Centimeters( Millimeters obj ) {
            return new Centimeters {
                Value = obj.Value * 0.1
            };
        }

        public static implicit operator Centimeters( Meters obj ) {
            return new Centimeters {
                Value = obj.Value * 100
            };
        }

        public static implicit operator Centimeters( Kilometers obj ) {
            return new Centimeters {
                Value = obj.Value * 100000
            };
        }

        public static implicit operator Centimeters( Inches obj ) {
            return new Centimeters {
                Value = obj.Value * 2.54
            };
        }

        public static implicit operator Centimeters( Feet obj ) {
            return new Centimeters {
                Value = obj.Value * 30.48
            };
        }

        public static implicit operator Centimeters( Miles obj ) {
            return new Centimeters {
                Value = obj.Value * 160934.4
            };
        }
    }
}