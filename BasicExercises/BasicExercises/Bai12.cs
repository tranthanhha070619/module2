using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai12
    {
        public static void Main(string[] args)
        {
            int number;

            Console.Write("Nhap so vao: ");
            number = Convert.ToInt32(Console.ReadLine());

            //Console.Write(number);
            //Console.Write(" ");
            //Console.Write(number);
            //Console.Write(" ");
            //Console.Write(number);
            //Console.Write(" ");
            //Console.Write(number);
            //Console.WriteLine();

            //Console.Write(number);
            //Console.Write(number);
            //Console.Write(number);
            //Console.WriteLine(number);
            //Console.WriteLine();
            Console.WriteLine("{0} {0} {0} {0}", number);

            Console.WriteLine("{0}{0}{0}{0}", number);

            Console.WriteLine("{0} {0} {0} {0}", number);

            Console.WriteLine("{0}{0}{0}{0}", number);

            Console.ReadLine();
        }
    }
}
