using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Practical_1
{
  public  class Shop 
    {
        public ArrayList ProductList = new ArrayList();
        public void AddProduct() {
            var product = new Product();
            Console.WriteLine("Nhap ten: ");
            product.Name = Console.ReadLine();

            Console.WriteLine("Nhap Gia: ");
            product.Price = int.Parse( Console.ReadLine());

            Console.WriteLine("Nhap mo ta: ");
            product.Description = Console.ReadLine();

            ProductList.Add(product);
        }
        public void RemoveProduct(string name) {
            Product product = new Product();
            foreach(Product item in ProductList)
            {
                if (item.Name == name)
                {
                    ProductList.Remove(item);
                }
            }
        }
        public void IterateProductList() { }
        public void SearchProduct() { }
    }
}
