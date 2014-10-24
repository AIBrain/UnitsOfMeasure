namespace UnitsOfMeasure.Mechanics {

    using Length;
    using Mass;

    public class Density<M, L> : Composite<M, Reciprocal<Volume<L>>>
        where M : Mass, new()
        where L : Length, new() {
    }
}