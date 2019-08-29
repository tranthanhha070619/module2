using System;
using System.Collections.Generic;
using System.Text;


namespace Shapes
{
    class Shape
    {
        private double side1,side2;
        protected Location c= new Location();

        public Shape() { }

        public Shape(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public string toString(bool type)
        {
            return type ? "Dien tich la: " + Area(): "Chi vi la: " + Primeter();
        }
        public void setLocation(double s1, double s2)
        {
            c.X = s1;
            c.Y = s2;
        }
        public virtual double Area()
        {
            return c.X * c.Y;
        }
        public virtual double Primeter()
        {
            return (c.X + c.Y) * 2;
        }

    }
}
