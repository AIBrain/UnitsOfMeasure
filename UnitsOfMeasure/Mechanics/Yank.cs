namespace UnitsOfMeasure.Mechanics {

    using Length;
    using Mass;
    using Time;

    public class Yank<M, L, T> : Rate<Force<M, L, T>, T>
        where M : Mass, new()
        where L : Length, new()
        where T : Time, new() {
    }
}