using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle:Shape
    {
        private double side1;
        private double side2;

        public Rectangle() { }

        public Rectangle(double side1, double side2):base(side1,side2)
        {
 
        }
    }
}
