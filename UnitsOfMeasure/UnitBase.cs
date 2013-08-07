using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure
{
    public abstract class UnitBase
    {
        public double Value;

        public override string ToString()
        {
            return Value.ToString();
        }
    }
    
    public static class UnitBaseMixin
    {
        public static T Add<T>(this T a, T b) where T : UnitBase, new()
        {
            return new T { Value = a.Value + b.Value };
        }

        public static T Subtract<T>(this T a, T b) where T : UnitBase, new()
        {
            return new T { Value = a.Value - b.Value };
        }

        public static T Multiply<T>(this T a, double b) where T : UnitBase, new()
        {
            return new T { Value = a.Value * b };
        }

        public static T Multiply<T>(this double b, T a) where T : UnitBase, new()
        {
            return new T { Value = a.Value * b };
        }

        public static T Divide<T>(this T a, double b) where T : UnitBase, new()
        {
            return new T { Value = a.Value / b };
        }

        public static Reciprocal<T> Divide<T>(this double b, T a) where T : UnitBase, new()
        {
            return new Reciprocal<T> { Value = b / a.Value };
        }

        public static double Divide<T>(this T a, T b)
            where T : UnitBase
        {
            return a.Value / b.Value;
        }

        public static T Negate<T>(this T a) where T : UnitBase, new()
        {
            return new T { Value = -a.Value };
        }

        public static T Sqrt<T>(this Composite<T, T> a)
            where T : UnitBase, new()
        {
            return new T{ Value = Math.Sqrt(a.Value) };
        }

        public static T Abs<T>(this T a) where T : UnitBase, new()
        {
            return new T { Value = Math.Abs(a.Value) };
        }

        public static T Ceiling<T>(this T a) where T : UnitBase, new()
        {
            return new T { Value = Math.Ceiling(a.Value) };
        }

        public static T Floor<T>(this T a) where T : UnitBase, new()
        {
            return new T { Value = Math.Floor(a.Value) };
        }

        public static T Round<T>(this T a) where T : UnitBase, new()
        {
            return new T { Value = Math.Round(a.Value) };
        }

        public static T Round<T>(this T a, int decimals) where T : UnitBase, new()
        {
            return new T { Value = Math.Round(a.Value, decimals) };
        }

        public static T Min<T>(this T a, T b) where T : UnitBase, new()
        {
            return new T { Value = Math.Min(a.Value, b.Value) };
        }

        public static T Max<T>(this T a, T b) where T : UnitBase, new()
        {
            return new T { Value = Math.Max(a.Value, b.Value) };
        }
    }
}
