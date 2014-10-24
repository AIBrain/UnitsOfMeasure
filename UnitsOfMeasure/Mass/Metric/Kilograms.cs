namespace UnitsOfMeasure.Mass.Metric {

    public class Kilograms : Mass {

        public static explicit operator Kilograms( double v ) {
            return new Kilograms {
                Value = v
            };
        }
    }
}