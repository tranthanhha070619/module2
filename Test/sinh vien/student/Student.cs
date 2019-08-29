using System;
using System.Collections.Generic;
using System.Text;

namespace student
{
    class Student : IStudent
    {
        private string fullName;
        private int iD;
        private string dateOfBirth;
        private string native;
        private string className;
        private string phoneNo;
        private int mobile;

        public string FullName { get => fullName; set => fullName = value; }
        public int ID { get => iD; set => iD = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Native { get => native; set => native = value; }
        public string ClassName { get => className; set => className = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public int Mobile { get => mobile; set => mobile = value; }

        public string Display()
        {
           
}
