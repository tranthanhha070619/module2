using System;
using System.Collections.Generic;
using System.Text;

namespace Olala
{
  public  class Student : IStudent
    {
        
        public string FullName { get; set; }
        public int Id { get; set; }
        public string DateofBirth { get; set; }
        public string Native { get; set; }
        public string ClassName { get; set; }
        public string PhoneNo { get; set; }
        public int Mobile { get; set; }

        public string Display()
        {
            return $"FullName: {FullName}, Id: {Id}, DateofBrith: {DateofBirth}, Native: {Native}, ClassName: {ClassName}, PhoneNo: {PhoneNo}, Mobile: {Mobile}";

        }
    }
}
