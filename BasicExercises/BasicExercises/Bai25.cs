using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("In cac so le tu 1 den 99");
            for(int n = 1;n < (99 + 1); n++)
            {
                if(n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                    Console.ReadKey();

                }
            }
        }
    }
}
