using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai33
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap so vao: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >0) {
                Console.WriteLine(number % 3 == 0 || number % 7 == 0);
                Console.ReadLine();
            }
        }
    }
}
