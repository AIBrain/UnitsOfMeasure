namespace UnitsOfMeasure.Mechanics {

    using Time;

    public static class AccelerationMixin {

        public static Acceleration<T, U> Divide<T, U>( this Velocity<T, U> a, U b )
            where T : SpatialProperty, new()
            where U : Time, new() {
            return new Acceleration<T, U> {
                Value = a.Value / b.Value
            };
        }

        public static Velocity<T, U> Multiply<T, U>( this Acceleration<T, U> a, U b )
            where T : SpatialProperty, new()
            where U : Time, new() {
            return new Velocity<T, U> {
                Value = a.Value * b.Value
            };
        }
    }

    public class Acceleration<L, T> : Rate<Velocity<L, T>, T>
        where L : SpatialProperty, new()
        where T : Time, new() {
    }
}