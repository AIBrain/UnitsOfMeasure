﻿using System;

namespace UnitsOfMeasure.Angle {
    public class Degrees : Angle {

        public static explicit operator Degrees( double v ) {
            return new Degrees {
                Value = v
            };
        }

        public static implicit operator Degrees( Radians obj ) {
            return new Degrees {
                Value = obj.Value * 180 / Math.PI
            };
        }
    }
}