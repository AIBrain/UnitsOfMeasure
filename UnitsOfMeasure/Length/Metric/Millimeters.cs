namespace UnitsOfMeasure.Length.Metric {

    using Imperial;

    public class Millimeters : Length {

        public static explicit operator Millimeters( double v ) {
            return new Millimeters {
                Value = v
            };
        }

        public static implicit operator Millimeters( Centimeters obj ) {
            return new Millimeters {
                Value = obj.Value * 10
            };
        }

        public static implicit operator Millimeters( Meters obj ) {
            return new Millimeters {
                Value = obj.Value * 1000
            };
        }

        public static implicit operator Millimeters( Kilometers obj ) {
            return new Millimeters {
                Value = obj.Value * 1000000
            };
        }

        public static implicit operator Millimeters( Inches obj ) {
            return new Millimeters {
                Value = obj.Value * 25.4
            };
        }

        public static implicit operator Millimeters( Feet obj ) {
            return new Millimeters {
                Value = obj.Value * 304.8
            };
        }

        public static implicit operator Millimeters( Miles obj ) {
            return new Millimeters {
                Value = obj.Value * 1609344
            };
        }
    }
}