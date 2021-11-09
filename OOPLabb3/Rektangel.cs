using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb3
{
    class Rektangel : Teckning
    {
        public double xLength { get; private set; }

        public double yLength { get; private set; }

        public Rektangel()
        {
            xLength = 5;

            yLength = 10;
        }

        public override double Area()
        {
            double rectangleArea = xLength * yLength;

            return rectangleArea;
        }
    }
}
