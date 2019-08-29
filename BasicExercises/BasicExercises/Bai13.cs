using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai13
    {
        public static void Main(string[] args)
        {
            int number;

            Console.Write("Nhap so vao: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" {0}{0}{0}", number);
            Console.WriteLine("{0}   {0}", number);
            Console.WriteLine("{0}   {0}", number);
            Console.WriteLine("{0}   {0}", number);
            Console.WriteLine(" {0}{0}{0}", number);

            Console.ReadLine();
        }
    }
}
