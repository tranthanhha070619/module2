using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : Shape
    {
        private double radius;
        private const double pi = Math.PI;
        public Circle() { }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
     
        
        public override double Primeter()
        {
            return radius * radius * pi;
        }
    }
}
