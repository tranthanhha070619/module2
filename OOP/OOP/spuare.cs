using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class spuare : Rectangle
    {
        private double side;
        public spuare()
        {
        }
        public spuare(double side) : base(side,side)
        {
        }
        public spuare(double side,string color, Boolean filled):base(side,side,color,filled)
        {
        }

        public double getSide(){
            return getWidth;
        }

        public void setSide(double side)
        {
            getLength=side;
            getWidth= side;
        }
        public String toString()
        {
            return "A Square with side="
                + getSide()
                + ", which is a subclass of "
                + base.toString();
        }
    }

}
