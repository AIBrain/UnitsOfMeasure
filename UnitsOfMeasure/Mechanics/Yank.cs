﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Mechanics
{
    public class Yank<M, L, T> : Rate<Force<M, L, T>, T>
        where M : Mass.Mass, new()
        where L : Length.Length, new()
        where T : Time.Time, new()
    {
    }
}