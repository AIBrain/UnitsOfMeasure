namespace UnitsOfMeasure.Mass.Imperial {

    public class Pounds : Mass {

        public static explicit operator Pounds( double v ) {
            return new Pounds {
                Value = v
            };
        }
    }
}