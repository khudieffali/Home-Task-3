﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskC_3
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public byte Age;
        public bool IsAdult;

        public Person(string name,string surname,byte age)
        {
                Name = name;
                Surname = surname;
                Age = age;  
                if(Age>18) IsAdult = true;
                else IsAdult = false;
        }


    }
}
