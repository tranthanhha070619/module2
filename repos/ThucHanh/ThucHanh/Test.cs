using System;
using System.Collections.Generic;
using System.Text;

namespace ThucHanh
{
    class Test
    {
        public static void Main()
        {
            var meo = new Cat();
            Console.WriteLine("Con meo an: {0}", meo.HowCanDrink());
            Console.WriteLine("Meo an thit: {0}", meo.HowCanEat());
            Console.WriteLine("Con meo chay: {0}", meo.HowCanMove());
            Console.ReadKey();

        }
    }
}
