using System;
using System.Collections.Generic;
using System.Text;

namespace TH.cacdoituonghinhhoc
{
    class Circle : Shape
    {
        private double radius;

        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius = 1.0;
        }
        public Circle(double radius, string color,bool filled) :base(color,filled)
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
        public double getArea()
        {
            return radius * radius * Math.PI;
        }
        public double getPerimeter()
        {
            return 2 * radius * Math.PI;
        }
        public string toString()
        {
            return "A Circle with "
                + getRadius()
                + "which is a subclass of "
                + base.toString();

                }
    }
   
}
