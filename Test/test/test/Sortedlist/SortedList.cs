using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace test.Sortedlist
{
    class SortedList1
    {
        public static void Main()
        {
            SortedList sortedList = new SortedList();
            SortedList MySl2 = new SortedList(10);
            sortedList.Add("Bao", "Bao dep trai");

            #region stack

            Stack MyStack = new Stack();
            Stack MyStack2 = new Stack(5);

            // Co thể thêm stack từ 1 array
            ArrayList myArray = new ArrayList(10);
            Stack Mystack3 = new Stack(myArray);
            Mystack3.Push("Bao vip");
            Mystack3.Push("haha");
            Mystack3.Push("dep trai");
            Console.WriteLine("So phan tu cua stack:  "+Mystack3.Count);

            Console.WriteLine("Phan tu dau cua stack la : {0}",Mystack3.Peek());
            Console.WriteLine("So phan tu cua stack sau khi goi ham peek:  " + Mystack3.Count);

            // xóa phần tử khỏi stack ( Pop)
            Console.WriteLine("Popping");
            int leng = Mystack3.Count;

            for(int i = 0; i<leng; i++)
            {
                Console.Write(" " + Mystack3.Pop());
            }
            Console.WriteLine();
            Console.WriteLine("sau khi pop "+Mystack3.Count);

            #endregion
        }


    }

    //class PersonComparer : IComparer
    //{
    //        public int Compare(object x, object y)
    //    {
    //        Person a = x as Person;
    //    }
    //}
}
