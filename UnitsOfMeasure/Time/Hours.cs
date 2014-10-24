using System;

namespace UnitsOfMeasure.Time {

    public class Hours : Time {

        public static explicit operator Hours( double v ) {
            return new Hours {
                Value = v
            };
        }

        public static implicit operator Hours( DateTime value ) {
            return new Hours {
                Value = ( ( value.Millisecond / 1000d
                + value.Second ) / 60
                + value.Minute ) / 60
                + value.Hour
                + 24 * ( value.DayOfYear
                + 365.25 * value.Year )
            };
        }

        public static implicit operator Hours( Milliseconds value ) {
            return new Hours {
                Value = value.Value / 3600000
            };
        }

        public static implicit operator Hours( Seconds value ) {
            return new Hours {
                Value = value.Value / 3600
            };
        }

        public static implicit operator Hours( Minutes value ) {
            return new Hours {
                Value = value.Value / 60
            };
        }
    }
}