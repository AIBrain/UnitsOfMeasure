namespace UnitsOfMeasure.Mechanics {

    using Length;
    using Mass;

    public class Pressure<M, L> : Composite<M, Reciprocal<Area<L>>>
        where M : Mass, new()
        where L : Length, new() {
    }
}