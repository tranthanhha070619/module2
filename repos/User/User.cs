using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
  public  class User:IUser
    {
        public List<int?> Phonelist = new List<int?>();
        public int id;
        public string name;
        public string password;

        public int Id { get => id; set => id = value; }
        public string Name { get => name ; set => name = value; }
        public string Password { get => password; set => password = value; }

        public string Display()
        {
            if (Phonelist == null || Phonelist.Count == 0)
            {
                return $"Id: {Id}, Name {Name}, Password {Password}";
            }
            else
            {
                return $"Id: {Id}, Name {Name}, Password {Password}, PhoneList: {string.Join(",",Phonelist)}";
            }
            }
        }
    }
}
