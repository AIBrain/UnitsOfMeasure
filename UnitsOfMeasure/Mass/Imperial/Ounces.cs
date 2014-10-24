namespace UnitsOfMeasure.Mass.Imperial {

    public class Ounces : Mass {

        public static explicit operator Ounces( double v ) {
            return new Ounces {
                Value = v
            };
        }
    }
}