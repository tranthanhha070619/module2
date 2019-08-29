using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai22
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so: \n");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(number));
            Console.ReadLine();
        }
        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true;
            return false;
        }
    }
}
