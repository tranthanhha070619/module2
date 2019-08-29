using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Lam
{
    class Menu
    {
        StudentMark student;
        public ArrayList mylist = new ArrayList();
        public int id = 0;
        public void Average()
        {
            foreach (StudentMark student in mylist)
            {
                student.AveCal();
            }

        }
        public void View()
        {
            foreach (StudentMark item in mylist)
            {
                Console.WriteLine(item.Display());
            }
        }
        public void Insert()
        {
            StudentMark student = new StudentMark();
            Console.WriteLine("nhap name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Nhap lop: ");
            var lop = Console.ReadLine();

            Console.WriteLine("Nhap Semester: ");
            var semester = int.Parse(Console.ReadLine());
            student.Fullname = name;
            student.ClassName = lop;
            student.Semester = semester;
            student.Id = id;
            for (int i = 0; i < student.SubjectMarkList.Length; i++)
            {
                Console.WriteLine("Please input marks of subject {0} ", (i + 1) + " :");
                student.SubjectMarkList[i] = int.Parse(Console.ReadLine());
            }
            student.AveCal();
            mylist.Add(student);

        }
        public void DrawMenu()
        {

            var choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("****************");
                Console.WriteLine("1.Insert new Student ...");
                Console.WriteLine("2. View list of Studnet...");
                Console.WriteLine("3. Averega Mark ...");
                Console.WriteLine("4. Exit ");

                Console.WriteLine("Option:   ");

                var selected = int.Parse(Console.ReadLine());
                switch (selected)
                {
                    case 1:
                        id++;

                        Insert();
                        break;
                    case 2:
                        View();
                        break;
                    case 3:
                        Average(); break;
                    case 4:
                        break;

                }
            }
        }
    }
}
