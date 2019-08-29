using System;
using System.Collections.Generic;
using System.Text;

namespace sort
{
    public class SortList
    {
        public static void Main(){
            // SortedList<string, string> EmployeeList = new SortedList<string, string>();
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();
            EmployeeList.Add("ha","cau ca");
            EmployeeList.Add("huy", "de");
            EmployeeList.Add("Bao", "dam");

            Console.WriteLine("show all values");
            foreach (var item in EmployeeList.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("show all key");
            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("show all key");
            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine("key: {0}, value: {1}", key, EmployeeList[key]);
            }
            ////remove item ly key

            //EmployeeList.Remove("ha");

            //string huyValue;
            //EmployeeList.Remove("huy", out  huyValue);
            //Console.WriteLine(huyValue);

            //EmployeeList.RemoveAt(EmployeeList.Count - 1);
            //enumnator
            var enumnator = EmployeeList.GetEnumerator();
            while (enumnator.MoveNext())
            {
                Console.WriteLine("key: {0}, value: {1}", enumnator.Current.Key, enumnator.Current.Value);
            }
        }

    }
}
