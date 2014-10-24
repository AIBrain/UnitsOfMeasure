namespace UnitsOfMeasure.Time {

    public class Rate<T, U> : Composite<T, Reciprocal<U>>
        where T : UnitBase, new()
        where U : Time, new() {
    }
}