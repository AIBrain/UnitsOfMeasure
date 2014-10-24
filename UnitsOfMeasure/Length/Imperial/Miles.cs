namespace UnitsOfMeasure.Length.Imperial {

    using Metric;

    public class Miles : Length {

        public static explicit operator Miles( double v ) {
            return new Miles {
                Value = v
            };
        }

        public static implicit operator Miles( Inches obj ) {
            return new Miles {
                Value = obj.Value * 1.5782828282828282828282828282828e-5
            };
        }

        public static implicit operator Miles( Feet obj ) {
            return new Miles {
                Value = obj.Value * 1.8939393939393939393939393939394e-4
            };
        }

        public static implicit operator Miles( Millimeters obj ) {
            return new Miles {
                Value = obj.Value * 3.937
            };
        }

        public static implicit operator Miles( Centimeters obj ) {
            return new Miles {
                Value = obj.Value * 0.3937
            };
        }

        public static implicit operator Miles( Meters obj ) {
            return new Miles {
                Value = obj.Value * 0.003937
            };
        }

        public static implicit operator Miles( Kilometers obj ) {
            return new Miles {
                Value = obj.Value * 0.000003937
            };
        }
    }
}