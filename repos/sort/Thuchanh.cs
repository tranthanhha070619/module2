using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;
namespace sort
{
  public  class Thuchanh
    {
        public static void Main()
        {
            Hashtable name = new Hashtable();
            Hashtable name1 = new Hashtable(5);

            name1.Add("A", "B");
            name1.Add("C", "D");
            Hashtable name3 = new Hashtable(name1);
            
            Hashtable hash = new Hashtable();
           
            hash.Add("soho", "rihi");
            hash.Add("hehe", "nono");
            hash.Add("TeTe", "be be");
            foreach(DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + "-- " + item.Value);
            }
        }
       
    }
        
    }

    
    