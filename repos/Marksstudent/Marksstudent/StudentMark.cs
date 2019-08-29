using System;
using System.Collections.Generic;
using System.Text;

namespace Marksstudent
{
    public class StudentMark : IStudentMark
    {
        public List<Student> studentList = new List<Student>();


        public int Id { get; internal set; }

        Student str = new Student();
        public void Insert(Student item)
        {
            studentList.Add(item);
        }
        public void AveCal()
        {
            Console.WriteLine("Diem mon 1: ");
            var mon1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Diem mon 2: ");
            var mon2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Diem mon 3: ");
            var mon3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Diem mon 4: ");
            var mon4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Diem mon 5: ");
            var mon5 = int.Parse(Console.ReadLine());

            var Diemtrungbinh = (mon1 + mon2 + mon3 + mon4 + mon5) / 5;
        }

        public void AverageMark()
        {


        }
    }
}
