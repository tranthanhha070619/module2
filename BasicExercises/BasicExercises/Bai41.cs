using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai41
    {
        public static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Input a string (conatins at least one 'w' char) : ");
            string str = Console.ReadLine();
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == 'w')
                {
                    count++;
                }
            }
            Console.WriteLine(count > 0 && count < 4);
            
            Console.ReadKey();
        }
    }
}
