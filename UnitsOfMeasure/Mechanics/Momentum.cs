namespace UnitsOfMeasure.Mechanics {

    using Mass;
    using Time;

    public class Momentum<M, L, T> : Composite<M, Velocity<L, T>>
        where M : Mass, new()
        where L : SpatialProperty, new()
        where T : Time, new() {
    }
}