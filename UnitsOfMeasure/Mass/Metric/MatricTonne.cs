namespace UnitsOfMeasure.Mass.Metric {

    public class MetricTonne : Mass {

        public static explicit operator MetricTonne( double v ) {
            return new MetricTonne {
                Value = v
            };
        }
    }
}