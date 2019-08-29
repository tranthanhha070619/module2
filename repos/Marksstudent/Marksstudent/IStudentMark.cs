using System;
using System.Collections.Generic;
using System.Text;

namespace Marksstudent
{
    interface IStudentMark
    {
      
        void Insert(Student item);
       
        void AverageMark();

        void AveCal();
    }
}
