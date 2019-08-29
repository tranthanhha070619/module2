using System;
using System.Collections.Generic;
using System.Text;

namespace Fans
{
    class Fan
    {
        int SLOW = 1;
        int MEDIUM = 2;
        int FAST = 3;
        private int speed = 1;
        private bool on = false;
        private double radius = 5;
        private string color = "blue";

        public int SLOW1 { get => SLOW; set => SLOW = value; }
        public int MEDIUM1 { get => MEDIUM; set => MEDIUM = value; }
        public int FAST1 { get => FAST; set => FAST = value; }
        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        public Fan() { }

        public string toString()
        {
            if (On)
            {
                return "fan is on"
                + Speed
                + Color
                + Radius;
            } 
            return "fan is off"
                +Color
                + Radius;           
        }

    }
}
