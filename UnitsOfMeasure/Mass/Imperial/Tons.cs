namespace UnitsOfMeasure.Mass.Imperial {

    public class Tons : Mass {

        public static explicit operator Tons( double v ) {
            return new Tons {
                Value = v
            };
        }
    }
}