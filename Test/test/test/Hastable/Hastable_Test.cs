using System;
using System.Collections.Generic;
using System.Text;


namespace test.Hastable
{
    class Hastable_Test
    {
        public static void Main()
        {
            List<int> myLish = new List<int>();
            myLish.Add(1);
            myLish.Add(24);
            myLish.Add(14);
            myLish.Add(13);
            /*yLish.AddRange(IEnumerable <int> 2);*/
            myLish.Add(13);
            Console.WriteLine(myLish.Count);
            Console.WriteLine(myLish.Capacity);
            //#region Hastable easy
            //Hashtable MyHash = new Hashtable();
            //Hashtable MyHash2 = new Hashtable(5);
            //MyHash2.Add("B", "Bao dep trai");
            //MyHash2.Add("T", "Tri dep trai");
            //Hashtable MyHash3 = new Hashtable(MyHash2);
            //Console.WriteLine(MyHash2.Count);
           
            ////Console.WriteLine(MyHash2.Keys.);

            //Console.WriteLine(MyHash2.ContainsValue("Bao dep trai"));

            //#endregion
            

            //#region Luu y hastable

            //Hashtable hash = new Hashtable();
            //hash.Add("K", "Kteam");
            //hash.Add("B", "Bao dep trai");
            //hash.Add("N", "Baovip");

            //hash["N1"] = "Nam moi";
            //hash["M"] = "";
            
            //Console.WriteLine("Key: L"+hash["L"]);

            //if (hash["T"] == null)
            //{
            //    Console.WriteLine("key T is null");
            //}
            //foreach (DictionaryEntry item in hash)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //}

            //Console.WriteLine(hash.Count);



            //#endregion


        }
        
    }
}
