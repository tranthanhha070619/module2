using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Bai28
    {
        public static void Main(string[] args)
        {
            string chain = "Dao cac ky tu trong chuoi";
            Console.WriteLine("\n" + chain);
            string result = "";
            List<string> wordsList = new List<string>();
            string[] words = chain.Split(new[]{
                " "
               }, StringSplitOptions.None);
            for(int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            wordsList.Add(result);
            foreach(String s in wordsList)
            {
                Console.WriteLine("\n" + s);
                Console.ReadLine();
            }
        }
    }
}
