using System;
using System.Collections.Generic;
using System.Text;

namespace sort
{
    public class List
    {
        public static void Main()
        {
            List<Dictionary<int, string>> c6 = new List<Dictionary<int, string>>();
            var ha = new Dictionary<int, string>();
            ha.Add(1, "ha nam");
           

            var nam = new Dictionary<int, string>();
            nam.Add(2, "Nam be");
          
            foreach(var item in c6)
            {
                foreach (var member in item)
                {
                    Console.WriteLine("Id : {0}, name: {1}", member.Key, member.Value);
                }
                }
             
        }
    }
}
