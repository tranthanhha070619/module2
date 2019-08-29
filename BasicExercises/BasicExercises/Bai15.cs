using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0));
            Console.ReadLine();
        }
        public static string remove_char(string str, int number)
        {
            return str.Remove(number, 1);
           
        }
    }
}
