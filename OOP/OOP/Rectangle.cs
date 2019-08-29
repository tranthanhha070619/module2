using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Rectangle : Shape
    {
        private double width = 1.0, length = 1.0;

     public Rectangle()
        {
        }
      public Rectangle(double width,double length)
        {
            this.width = width;
            this.length = length;
        }
       public Rectangle(double width, double length,string color,Boolean filled) :base(color,filled)
        {
            this.width = width;
            this.length = length;
        }

        public double getWidth { get => width; set => width = value; }
        public double getLength { get => length; set => length = value; }

        public double getArea()
        {
            return width * length;
        }
        public double getPerimeter()
        {
            return 2 * (width + length);
        }


        public String toString()
        {
            return "A Rectangle width"
                + getWidth 
                + "and"
                + getLength
                + "which is a subclass of"
                +base.toString();
        }
    }
    
}
