using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6Day24_Task
{
    internal class Circle:Shape
    {
        public double Radius;

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

    }

}
