namespace UnitsOfMeasure.Mass.Metric {

    public class Grams : Mass {

        public static explicit operator Grams( double v ) {
            return new Grams {
                Value = v
            };
        }
    }
}