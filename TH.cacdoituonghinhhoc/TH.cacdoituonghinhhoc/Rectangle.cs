using System;
using System.Collections.Generic;
using System.Text;

namespace TH.cacdoituonghinhhoc
{
    class Rectangle : Shape
    {
        private double width;
        private double length;

        public Rectangle()
        {

        }
        public Rectangle(double width,double length)
        {
            this.width = width = 1.0;
            this.length = length = 1.0;
        }
        public Rectangle(double width,double length, string color,bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }
        public double getWidth()
        {
            return width;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public double getLength()
        {
            return length;
        }
        public void setLength(double length)
        {
            this.length = length;
        }
        public double getArea()
        {
            return width * length;
        }
        public double getPerimeter()
        {
            return (width + length) * 2;
        }
        public string toString()
        {
            return "A Rectangle with"
                + getWidth()
                + "and"
                + getLength()
                + "which is a subclass of"
                + base.toString();
                
        }
    }

}
