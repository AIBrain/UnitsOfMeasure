using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length
{
    public class Volume<T> : Composite<Composite<T, T>, T> where T : Length, new()
    {
    }
}
