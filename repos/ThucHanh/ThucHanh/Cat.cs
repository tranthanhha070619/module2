using System;
using System.Collections.Generic;
using System.Text;

namespace ThucHanh
{
    class Cat:Animal,ICanEat,ICanDrink
    {
        public override string HowCanMove()
        {
            return "speed";
        }
        public string HowCanDrink()
        {
            return "uc uc";
        }
        public string HowCanEat()
        {
            return "ca,thit";
        }
    }
}
