using System;
using System.Collections.Generic;
using System.Text;

namespace MARKS
{
    interface IStudentMark
    {
        string FullName();
        int ID();
        string Class();
        int Semester();
        float AverageMark();

        void Display();
    }
}
