namespace UnitsOfMeasure.Mechanics {

    using Mass;
    using Time;

    public class Force<M, L, T> : Composite<M, Acceleration<L, T>>
        where M : Mass, new()
        where L : SpatialProperty, new()
        where T : Time, new() {
    }
}