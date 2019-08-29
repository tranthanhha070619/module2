using System;
using System.Collections;

namespace Practical_1
{
  public  class Program
    {
       public static void Main()
        {
            Menu();
        }
       public static void Menu()
        {
            var shop = new Shop();
            Console.WriteLine("**************");
            Console.WriteLine("1. Add new product");
            Console.WriteLine("2. Remove product");
            Console.WriteLine("3. Iterate product list");
            Console.WriteLine("4. Search product");
            Console.WriteLine("5. Exit");
            int number = int.Parse(Console.ReadLine());
            while (true)
            {               
                if (number > 5 || number < 0)
                {
                    break;
                }

                switch(number)
                {                    
                 
                    case 1:
                        shop.AddProduct();
                        break;

                    case 2:
                        Console.WriteLine("nhap ten muon xoa: ");
                        string name = Console.ReadLine();
                        shop.RemoveProduct(name);
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        return
                            ;
                }

                Console.WriteLine("**************");
                Console.WriteLine("1. Add new product");
                Console.WriteLine("2. Remove product");
                Console.WriteLine("3. Iterate product list");
                Console.WriteLine("4. Search product");
                Console.WriteLine("5. Exit");
                number = int.Parse(Console.ReadLine());

            }
        }
        public static void SortProduct()
        {
            
        }
    }
}
