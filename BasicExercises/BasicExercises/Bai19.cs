using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SumTriple(5, 2));
            Console.WriteLine(SumTriple(8, 8));
            Console.WriteLine(SumTriple(25, 32));
            Console.ReadLine();

        }
        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
    }
}
