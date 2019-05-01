using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double sideBase, double sideCat) : base(sideBase, sideCat, sideCat)
        {
        }

        public bool IsIsoscelesTriangle()
        {
            return this.sideB == this.sideC;
        }
    }
}