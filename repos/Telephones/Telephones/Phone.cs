using System;
using System.Collections.Generic;
using System.Text;

namespace Telephones
{
   public abstract class Phone
    {
        
        public abstract void insertPhone(string name, string phone);
        public abstract void removePhone(string name);
        public abstract void updatePhone(string name, string newphone);
        public abstract void seachPhone(string name);
        public abstract void sort();

    }
}
