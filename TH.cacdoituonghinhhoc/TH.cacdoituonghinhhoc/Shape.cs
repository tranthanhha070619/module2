using System;
using System.Collections.Generic;
using System.Text;

namespace TH.cacdoituonghinhhoc
{
    class Shape
    {
        private string color;
        private bool filled;

        public Shape()
        {

        }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }

        public bool isFilled()
        {
            return filled;
        }
        public void setFilled(bool filled)
        {
            this.filled = filled;
        }
        public string toString()
        {
            return "A Shape with"
                + getColor()
                + "and"
                + base.ToString();
        }
    }
}
