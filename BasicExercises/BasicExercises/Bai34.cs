using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai34
    {
        public static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Nhap vao: ");
            str = Console.ReadLine();
            Console.WriteLine((str.Length < 4 && str.Equals("Dog")) || (str.StartsWith("Dog") && str[3] == ' '));
            Console.ReadLine();
        }
    }
}
