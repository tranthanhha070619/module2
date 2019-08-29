using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(result(10, 30));
            Console.WriteLine(result(50, 20));
            Console.WriteLine(result(20, 30));
            Console.ReadLine();
        }
         public static int result(int a, int b)
        {
            if(a > b)
            {
                return (a - b) * 2;
            }
                return (b - a);
           
        }

    }
}
