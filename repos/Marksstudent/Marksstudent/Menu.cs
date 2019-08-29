using System;
using System.Collections.Generic;
using System.Text;

namespace Marksstudent
{
   public class Menu
    {
       public static StudentMark student = new StudentMark();
        public static int Id = 0;
        public static void Main()
        {
            
        }
        public void Display()
        {
            Console.WriteLine("Full name\tClass\tSemester");
            if(student.studentList != null && student.studentList.Count > 0)
            {
                foreach(Student student in student.studentList) {
                    Console.WriteLine(student.FullName + "\t" + student.Class + "\t" + student.Semester);
                }
            }

        }
        public void InsertStudent()
        {
            student.Id = Id;
            Console.WriteLine("Nhap Full name ");
            var fullname = Console.ReadLine();
            Console.WriteLine("Nhap lop: ");
            var lop = Console.ReadLine();
            Console.WriteLine("Nhap semester ");
            var semester = int.Parse(Console.ReadLine());

            var item = new Student()
            {
                FullName = fullname,
                Class = lop,
                Semester = semester
            };
            student.Insert(item);
        }
        public void drawMenu()
        {
            int choice = -1;
            while(choice != 4)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Insert new Student ");
                Console.WriteLine("2. View list of Students ");
                Console.WriteLine("3. Average Mark ");
                Console.WriteLine("4. Exit ");
                int selected;
                bool check = int.TryParse(Console.ReadLine(), out selected);
                if(check && selected < 5)
                {
                    switch (selected)
                    {
                        case 1:
                            InsertStudent();
                            Id = Id + 1;
                        break;
                        case 2:
                            Display();
                            break;
                        case 3:
                            break;
                        case 4:
                        default:
                            break;
                        
                    }
                }
                
            }
        }
    }
}
