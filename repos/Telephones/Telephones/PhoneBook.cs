using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Telephones.Modul;
namespace Telephones
{

    public class PhoneBook : Phone
    {
        public ArrayList PhoneList = new ArrayList();

        public override void insertPhone(string name, string phone)
        {
            if (PhoneList != null && UserIsExited(name))
            {
                foreach (NewItem newItem in PhoneList)
                {
                    if (newItem.Name == name)
                    {
                        if (newItem.PhoneNumber != phone)
                        {
                            newItem.PhoneNumber += ":" + phone;
                        }
                    }
                }
            }
            else
            {
                var newItem = new NewItem();
                newItem.Name = name;
                newItem.PhoneNumber = phone;
                PhoneList.Add(newItem);
                //var pI = new NewItem()
                //{
                //    Name = name,
                //    PhoneNumber = phone
                //};

            }
        }
        public override void removePhone(string name)
        {
            if (PhoneList != null && UserIsExited(name))
            {
                foreach (NewItem newItem in PhoneList)
                {
                    if (newItem.Name == name)
                    {
                        PhoneList.Remove(newItem);
                        break;
                    }

                }
            }

        }

        public override void seachPhone(string name)
        {
            if(PhoneList!= null && PhoneList.Count > 0)
            {
                foreach(NewItem newitems in PhoneList)
                {
                    if(name == newitems.Name)
                    {
                        Console.WriteLine(newitems.Name);
                        Console.WriteLine(newitems.PhoneNumber);
                    }
                }
            }
        }

        public override void sort()
        {
            throw new NotImplementedException();
        }

        public override void updatePhone(string name, string newphone)
        {
            if (PhoneList != null && UserIsExited(name))
            {
                foreach (NewItem newItem in PhoneList)
                {
                    if (newItem.Name == name)
                    {
                        PhoneList.Remove(newItem);
                    }
                }
            }
        }
        public bool UserIsExited(string userName)
        {
            if (PhoneList != null)
            {
                foreach (NewItem newItem in PhoneList)
                {



                    if (newItem.Name == userName)
                        return true;
                }
            }
            return false;
        }
    }
}
