using System;
using System.Collections;

namespace Olala
{
   public class Program
    {
       public static int id = 0;
        public static ArrayList numberList = new ArrayList();
        static void Main(string[] args)
        {
            Menu();

            
        }
        public static void Menu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("************");
                Console.WriteLine("1. Insert new Student");
                Console.WriteLine("2 View list of Student");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Exit");

               option = int.Parse(Console.ReadLine());

            }
            while (option >= 4 || option <= 0);
            ProCess(option);
        }

        public static void ProCess(int selected)
        {
            switch (selected)
            {
                case 1:
                   
                    CreateStudent();
                    break;
                case 2:
                    View();
                        break;
                case 3:
                    SearchStudent();
                    break;
                case 4:

                    break;
                default:
                    Menu();
                    break;

            }
            Menu();
                
            
        }
        public static void CreateStudent()
        {
            id = id + 1;
            
            var student = new Student();
            student.Id = id;
            Console.WriteLine("Nhap name: ");
            student.FullName = Console.ReadLine();

            Console.WriteLine("Nhap DateofBrith: ");
            student.DateofBirth = Console.ReadLine();

            Console.WriteLine("Nhap Native: ");
            student.Native = Console.ReadLine();

            Console.WriteLine("Nhap lop: ");
            student.ClassName = Console.ReadLine();

            Console.WriteLine("Nhap PhoneNo: ");
            student.PhoneNo = Console.ReadLine();

            Console.WriteLine("Nhap Mobile: ");
            student.Mobile = int.Parse(Console.ReadLine());

            numberList.Add(student);

        }
        public static void SearchStudent()
        {
            var searchname = new Student();
            Console.WriteLine("Moi nguoi dung nhap ten: ");
            searchname.FullName = (Console.ReadLine());

            foreach(Student item in numberList)
            {
                item.Display();
            }

        }
        public static void View()
        {
            foreach(Student sum in numberList)
            {
                Console.WriteLine(sum.Display());
            }
        }
    }
  
}
