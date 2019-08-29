using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Circle : Shape
    {
        private double radius = 1.0;

        public Circle()
        {
        }
      public Circle(double radius)
        {
            this.Radius = radius;
        }

        public Circle(double radius,string color,Boolean filled) :base(color,filled)
        {
            this.Radius = radius;          
        }

        public double Radius { get => radius; set => radius = value; }

        public double getArea()
        {
            return Radius * Radius * Math.PI;
        }
        public double getPerimeter()
        {
            return 2 * Radius * Math.PI;
        }
        public String toString()
        {
            return "A Circle with"
                + Radius
                + "which is a subclass of "
                + base.ToString();
        }
    }
   
}
