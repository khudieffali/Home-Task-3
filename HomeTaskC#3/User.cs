using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskC_3
{
    internal class User
    {
        public string Name;
        public string Surname;
        public string PhoneNumber;
        public string Email;
        public string Password;


        public User(string name, string surname, string phoneNumber, string email, string password)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
        }
        public bool IsPassword(string password)
        {
            char[] arr = { '0', '1','2', '3', '4', '5', '6', '7', '8', '9' };
                if (password.Length < 6 || password.Contains(Name.ToLower()))
               {
                return false;
               
               }
                foreach (var item in arr)
                {
                password.Contains(item);
                return true;
               }
                return false;
        }
    }
}
