using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskC_3
{
    internal class Motorcycle
    {
        public string Brand;
        public string Model;
        public int Year;
        public byte MaxSpeed;
        public bool HasSideCar;
        
        public Motorcycle(string brand, string model, int year, byte maxSpeed, bool hasSideCar)
        {
            Brand = brand;  
            Model = model;
            Year = year;
            MaxSpeed = maxSpeed;
            HasSideCar = hasSideCar;
        }
    }
}
