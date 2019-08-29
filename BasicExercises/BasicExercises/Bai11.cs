using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai11
    {
        public static void Main(string[] args)
        {
            int age;
            Console.Write("Nhap tuoi cua ban: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ban gia hon {0}", age);
            Console.ReadLine();
        }
    }
}
