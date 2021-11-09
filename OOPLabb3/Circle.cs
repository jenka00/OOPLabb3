using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLabb3
{

    class Circle : Teckning
    {
        public double Radius { get; private set; }
        
        float pi = 3.14f;

        public Circle()
        {
            Radius = 4;
        }

        public override double Area()
        {
           double circleArea = (Radius * Radius * pi);

           return circleArea;
        }
    }
}