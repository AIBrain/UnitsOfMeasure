using System;

namespace UnitsOfMeasure.Time {

    public class Minutes : Time {

        public static explicit operator Minutes( double v ) {
            return new Minutes {
                Value = v
            };
        }

        public static implicit operator Minutes( DateTime value ) {
            return new Minutes {
                Value = ( value.Millisecond / 1000d
                + value.Second ) / 60
                + value.Minute
                + 60 * ( value.Hour
                + 24 * ( value.DayOfYear
                + 365.25 * value.Year ) )
            };
        }

        public static implicit operator Minutes( Milliseconds value ) {
            return new Minutes {
                Value = value.Value / 60000
            };
        }

        public static implicit operator Minutes( Seconds value ) {
            return new Minutes {
                Value = value.Value / 60
            };
        }

        public static implicit operator Minutes( Hours value ) {
            return new Minutes {
                Value = value.Value * 60
            };
        }
    }
}