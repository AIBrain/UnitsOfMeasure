namespace UnitsOfMeasure.Mechanics {

    using Length;
    using Mass;
    using Time;

    public class Work<M, L, T> : Composite<Force<M, L, T>, L>
        where M : Mass, new()
        where L : Length, new()
        where T : Time, new() {
    }
}