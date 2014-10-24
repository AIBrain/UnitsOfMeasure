namespace UnitsOfMeasure.Mechanics {

    using Time;

    public static class VelocityMixin {

        public static Velocity<L, T> Divide<L, T>( this L a, T b )
            where L : SpatialProperty, new()
            where T : Time, new() {
            return new Velocity<L, T> {
                Value = a.Value / b.Value
            };
        }

        public static L Multiply<L, T>( this Velocity<L, T> a, T b )
            where L : SpatialProperty, new()
            where T : Time, new() {
            return new L {
                Value = a.Value * b.Value
            };
        }
    }

    public class Velocity<L, T> : Rate<L, T>
        where L : SpatialProperty, new()
        where T : Time, new() {
    }
}