using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai38
    {
        public static void Main(string[] args)
        {
            string str = "RACCING BOY";
            var result = "";

            if (str.Length >= 1 && str[0] == 'R')
                result += str[0];

            if (str.Length >= 2 && str[1] == 'A')
                result += str[1];

            Console.WriteLine(result);
            Console.ReadLine();
            
        }
        }
}
