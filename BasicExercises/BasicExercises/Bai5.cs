using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai5
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int number;
            number = a;
            a = b;
            b = number;
            Console.Write(a + "\n");
            Console.Write(b);
            Console.ReadLine();
            
        }
    }
}
