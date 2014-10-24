using System;

namespace UnitsOfMeasure.Angle {

    public static class RadiansMixin {

        public static Radians Acos( this double a ) {
            return new Radians {
                Value = Math.Acos( a )
            };
        }

        public static Radians Asin( this double a ) {
            return new Radians {
                Value = Math.Asin( a )
            };
        }

        public static Radians Atan( this double a ) {
            return new Radians {
                Value = Math.Atan( a )
            };
        }

        public static Radians Atan2( this double a, double b ) {
            return new Radians {
                Value = Math.Atan2( a, b )
            };
        }

        public static Radians Atan2<T>( this T a, T b ) where T : SpatialProperty, new() {
            return new Radians {
                Value = Math.Atan2( a.Value, b.Value )
            };
        }

        public static double Cos( this Radians a ) {
            return Math.Cos( a.Value );
        }

        public static double CoSec( this Radians a ) {
            return 1 / Math.Sin( a.Value );
        }

        public static double Cosh( this Radians a ) {
            return Math.Cosh( a.Value );
        }

        public static double CoTan( this Radians a ) {
            return 1 / Math.Tan( a.Value );
        }

        public static double Sec( this Radians a ) {
            return 1 / Math.Cos( a.Value );
        }

        public static double Sin( this Radians a ) {
            return Math.Sin( a.Value );
        }

        public static double Sinh( this Radians a ) {
            return Math.Sinh( a.Value );
        }

        public static double Tan( this Radians a ) {
            return Math.Tan( a.Value );
        }

        public static double Tanh( this Radians a ) {
            return Math.Tanh( a.Value );
        }
    }

    public class Radians : Angle {

        public static explicit operator Radians( double v ) {
            return new Radians {
                Value = v
            };
        }

        public static implicit operator Radians( Degrees obj ) {
            return new Radians {
                Value = obj.Value * Math.PI / 180
            };
        }
    }
}