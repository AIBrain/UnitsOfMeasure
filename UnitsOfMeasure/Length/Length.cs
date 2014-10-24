namespace UnitsOfMeasure.Length {

    public static class LengthMixin {

        public static Area<L> Multiply<L>( this L a, L b ) where L : Length, new() {
            return new Area<L> {
                Value = a.Value * b.Value
            };
        }
    }

    public abstract class Length : SpatialProperty {
    }
}