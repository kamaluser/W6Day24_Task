﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6Day24_Task
{
    internal class Rectangle:Shape
    {
        public double Width;
        public double Height;
        public override double CalculateArea()
        {
            return Width*Height;
        }
    }
}
