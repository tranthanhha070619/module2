using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai37
    {
        public static void Main(string[] args)
        {
            string str = "GHP Turorial";
            Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1,2) : str ));
            Console.ReadLine();
        }
    }
}
