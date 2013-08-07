using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length
{
    public class Area<L> : Composite<L, L> where L : Length, new()
    {        
    }

    public static class AreaMixin
    {
        public static Volume<L> Multiply<L>(this Area<L> a, L b) where L : Length, new()
        {
            return new Volume<L> { Value = a.Value * b.Value };
        }

        public static Volume<L> Multiply<L>(this L a, Area<L> b) where L : Length, new()
        {
            return new Volume<L> { Value = a.Value * b.Value };
        }
    }
}
