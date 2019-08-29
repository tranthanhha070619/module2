using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Chicken : Animal,IEdible
    {
        public override string MakeSound()
        {
            return "chip chip";
        }
        public string HowToEat()
        {
            return "Chicken eat fruit";
        }
    }
}
