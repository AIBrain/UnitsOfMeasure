namespace UnitsOfMeasure.Mass.Metric {

    public class Milligrams : Mass {

        public static explicit operator Milligrams( double v ) {
            return new Milligrams {
                Value = v
            };
        }
    }
}