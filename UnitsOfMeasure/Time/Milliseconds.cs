﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Time
{
    public class Milliseconds : Time
    {
        public static implicit operator Milliseconds(DateTime value)
        {
            return new Milliseconds
            {
                Value = value.Millisecond
                    + 1000 * (value.Second
                    + 60 * (value.Minute
                    + 60 * (value.Hour
                    + 24 * (value.DayOfYear
                    + 365.25 * value.Year))))
            };
        }

        public static implicit operator Milliseconds(Seconds value)
        {
            return new Milliseconds
            {
                Value = value.Value * 1000
            };
        }

        public static implicit operator Milliseconds(Minutes value)
        {
            return new Milliseconds
            {
                Value = value.Value * 60000
            };
        }

        public static implicit operator Milliseconds(Hours value)
        {
            return new Milliseconds
            {
                Value = value.Value * 3600000
            };
        }
    }
}