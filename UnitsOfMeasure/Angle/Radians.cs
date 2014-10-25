using System;

namespace UnitsOfMeasure.Angle {
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