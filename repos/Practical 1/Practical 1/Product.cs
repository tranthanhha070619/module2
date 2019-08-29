using System;
using System.Collections.Generic;
using System.Text;
namespace Practical_1
{
  public  class Product
    {
        private int price;
        public string Name;
        public string Description;
        public int Price {
            get => Price;
            set
            {
                if(value > 0 && value <= 100)
                {
                    price = value;
                }
            }
        }
        //public int[] rate
        //{
        //    get => rate;

        //    set
        //    {
        //        if (value >= 1 && value <= 5)
        //        {
        //            rate = value;
        //        }

        //    }
        //    }
        //}
        public void ViewInfo() {
            Console.WriteLine($" ten: {Name}");

            Console.WriteLine($" price: {Price}");

            Console.WriteLine($" descripted: {Description}");
        }
    }
}
