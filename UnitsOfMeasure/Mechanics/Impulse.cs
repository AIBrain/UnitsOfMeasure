namespace UnitsOfMeasure.Mechanics {

    using Mass;
    using Time;

    public class Impulse<M, L, T> : Rate<Momentum<M, L, T>, T>
        where M : Mass, new()
        where L : SpatialProperty, new()
        where T : Time, new() {
    }
}