using System;
using System.Collections.Generic;
using System.Text;

namespace ThucHanh
{
    class Animal:ICanMove
    {
        public virtual string HowCanMove()
        {
            return "move";
        }
    }
}
