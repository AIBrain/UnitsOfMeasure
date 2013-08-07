using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Length
{
    public class Volume<L> : Composite<Area<L>, L> where L : Length, new()
    {
    }
}
