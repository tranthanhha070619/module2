using System;
using System.Collections.Generic;
using System.Text;

namespace sort
{
   public class StackQueue
    {
        public static void Main()
        {
            Stack<int> Money = new Stack<int>();
            Money.Push(500);
            Money.Push(200);
            Money.Push(100);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>");
            foreach (var item in Money)
            {
                Console.WriteLine("Item: {0}", item);
            }
            Console.WriteLine("item on top: {0}", Money.Peek());

            Queue<string> Tacks = new Queue<string>();
            Tacks.Enqueue("ha ha ha");
            Tacks.Enqueue("do do do");
            Tacks.Enqueue("he he he");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>");
            foreach (var item in Tacks)
            {
                Console.WriteLine("Item: {0}", item);
            }
            Console.WriteLine("item on top: {0}", Tacks.Peek());
        }

    }
}
