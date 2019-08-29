using System;
using System.Collections.Generic;
using System.Text;

namespace Userss
{
   
   public class User : IUser
    {
       
       private int iD;
        private string name;
        private string password;
        public int ID { get =>  iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string PassWord { get =>password ; set => password = value; }

        public List<int?> phoneList = new List<int?>();
        public string Display()
        {
            if (phoneList == null || phoneList.Count == 0)
            
                return $"id {ID}, name {Name}, password {PassWord}";
            else
                return $"id {ID}, name {Name}, password {PassWord}, phoneList: {string.Join(",",phoneList)}";
        }
    }
}
