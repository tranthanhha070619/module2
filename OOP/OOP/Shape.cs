using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Shape
    {
        private String color = "green";
        private Boolean filled = true;

        public Shape()
        {
        }
        public Shape(string color, Boolean filled)
        {
            this.Color = color;
            this.Filled = filled;
        }

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public String toString()
        {
            return "A Rectangle with" + Color
                + "and"
                + (Filled ? "filled" : "not filled");


        }

    }
}
