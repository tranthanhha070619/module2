using System;
using System.Collections.Generic;
using System.Text;

namespace sort
{
   public class LinkedList
    {
        public static void Main()
        {
            LinkedList<string> Relationship = new LinkedList<string>();
            Relationship.AddFirst("ha");
            var huy = Relationship.First;
            Relationship.AddAfter(huy,"huy");
            var tu = Relationship.First;
            Relationship.AddAfter(tu, "tu");
            var findHuy = Relationship.Find("huy");
            Relationship.AddAfter(findHuy, "nam");
            foreach(var nodes in Relationship)
            {
                Console.WriteLine("item: {0}", nodes);
            }
        }
    }
}
