namespace UnitsOfMeasure {

    public class Composite<T, U> : UnitBase
        where T : UnitBase, new()
        where U : UnitBase, new() {
    }
}