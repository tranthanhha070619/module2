using System;
using System.Collections.Generic;
using System.Text;

namespace Lam
{
  public  class StudentMark : IStudentMark
    {
       public int[] SubjectMarkList = new int[5];
        public string Fullname { get; set; }
        public int Id { get; set; }
        public string ClassName { get; set;}

        public int Semester { get; set; }
        public float AverageMark { get; private set; }

        public string Display()
        {
            return $"Fullname : {Fullname},Id : {Id},Class: {ClassName}, Semester: {Semester},AverageMark : {AverageMark}";
        }
        public  void AveCal()
        {
            var sum = 0;
            for(int i = 0; i< SubjectMarkList.Length; i++)
            {
                sum += SubjectMarkList[i];
            }
            AverageMark = (float)(sum / SubjectMarkList.Length);
            Console.WriteLine(AverageMark);
        }
    }
}
