using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb3
{
    class Fyrkant : Teckning
    {
        public double xLength { get; private set; }

        public Fyrkant()
        {
            xLength = 10;
        }

        public override double Area()
        {
            double squareArea = 4 * xLength;

            return squareArea;
        }
    }
}
