namespace UnitsOfMeasure.Mechanics {

    using Time;

    public static class JerkMixin {

        public static Jerk<M, T> Divide<M, T>( this Acceleration<M, T> a, T b )
            where M : SpatialProperty, new()
            where T : Time, new() {
            return new Jerk<M, T> {
                Value = a.Value / b.Value
            };
        }

        public static Acceleration<M, T> Multiply<M, T>( this Jerk<M, T> a, T b )
            where M : SpatialProperty, new()
            where T : Time, new() {
            return new Acceleration<M, T> {
                Value = a.Value * b.Value
            };
        }
    }

    public class Jerk<L, T> : Rate<Acceleration<L, T>, T>
        where L : SpatialProperty, new()
        where T : Time, new() {
    }
}