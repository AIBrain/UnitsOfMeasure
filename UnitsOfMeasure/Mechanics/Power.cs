namespace UnitsOfMeasure.Mechanics {

    using Length;
    using Mass;
    using Time;

    public class Power<M, L, T> : Rate<Work<M, L, T>, T>
        where M : Mass, new()
        where L : Length, new()
        where T : Time, new() {
    }
}