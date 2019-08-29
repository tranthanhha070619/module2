using System;

namespace Phuongtrinhbac2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            QuadraticEquation bai1 = new QuadraticEquation(1,3,1);
            if (bai1.getDiscriminant() < 0 )
            {
                Console.WriteLine("Phuong trinh vo nghiem: ");
            } else if (bai1.getDiscriminant() == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep: " + bai1.getRoot());
            }else if (bai1.getDiscriminant() > 0)
            {
                Console.WriteLine("Phuong trinh cos 2 nghiem {0} va {1}", bai1.getRoot1(), bai1.getRoot2());
            }
        }
    }
}
