namespace UnitsOfMeasure.Mechanics {

    using Length;
    using Mass;
    using Time;

    public class KineticEnergy<M, L, T> : Composite<M, Composite<Velocity<L, T>, Velocity<L, T>>>
        where M : Mass, new()
        where L : Length, new()
        where T : Time, new() {
    }
}