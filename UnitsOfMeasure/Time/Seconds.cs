﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfMeasure.Time
{
    public class Seconds : Time
    {
        public static implicit operator Seconds(DateTime value)
        {
            return new Seconds
            {
                Value = value.Millisecond / 1000d
                + value.Second
                + 60 * (value.Minute
                + 60 * (value.Hour
                + 24 * (value.DayOfYear
                + 365.25 * value.Year)))
            };
        }

        public static implicit operator Seconds(Milliseconds value)
        {
            return new Seconds
            {
                Value = value.Value / 1000
            };
        }

        public static implicit operator Seconds(Minutes value)
        {
            return new Seconds
            {
                Value = value.Value * 60
            };
        }

        public static implicit operator Seconds(Hours value)
        {
            return new Seconds
            {
                Value = value.Value * 3600
            };
        }
    }
}