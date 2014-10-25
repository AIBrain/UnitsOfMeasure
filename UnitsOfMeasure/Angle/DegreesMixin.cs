namespace UnitsOfMeasure.Angle {
    public static class DegreesMixin {

        public static double Cos( this Degrees a ) {
            return ( ( Radians )a ).Cos();
        }
    }
}