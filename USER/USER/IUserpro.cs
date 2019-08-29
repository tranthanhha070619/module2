using System;
using System.Collections.Generic;
using System.Text;

namespace USER
{
    interface IUserPro
    {
        int ID { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        //int? PhoneList = new int;
    }
}
