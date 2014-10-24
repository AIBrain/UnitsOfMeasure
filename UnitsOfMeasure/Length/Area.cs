namespace UnitsOfMeasure.Length {

    public static class AreaMixin {

        public static Volume<L> Multiply<L>( this Area<L> a, L b ) where L : Length, new() {
            return new Volume<L> {
                Value = a.Value * b.Value
            };
        }

        public static Volume<L> Multiply<L>( this L a, Area<L> b ) where L : Length, new() {
            return new Volume<L> {
                Value = a.Value * b.Value
            };
        }
    }

    public class Area<L> : Composite<L, L> where L : Length, new() {
    }
}