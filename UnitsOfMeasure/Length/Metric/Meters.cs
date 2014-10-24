namespace UnitsOfMeasure.Length.Metric {

    using Imperial;

    public class Meters : Length {

        public static explicit operator Meters( double v ) {
            return new Meters {
                Value = v
            };
        }

        public static implicit operator Meters( Millimeters obj ) {
            return new Meters {
                Value = obj.Value * 0.001
            };
        }

        public static implicit operator Meters( Centimeters obj ) {
            return new Meters {
                Value = obj.Value * 0.01
            };
        }

        public static implicit operator Meters( Kilometers obj ) {
            return new Meters {
                Value = obj.Value * 1000
            };
        }

        public static implicit operator Meters( Inches obj ) {
            return new Meters {
                Value = obj.Value * 0.0254
            };
        }

        public static implicit operator Meters( Feet obj ) {
            return new Meters {
                Value = obj.Value * 0.3048
            };
        }

        public static implicit operator Meters( Miles obj ) {
            return new Meters {
                Value = obj.Value * 1609.344
            };
        }
    }
}