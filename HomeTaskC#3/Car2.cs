using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskC_3
{
    internal class Car2
    {
        public string Brand;
        public string Model;
        public int Year;
        public byte MaxSpeed;
        public byte NumSeats;

        public Car2(string brand, string model, int year, byte maxSpeed, byte numSeats)
        {
            Brand = brand;
            Model = model;
            Year = year;
            MaxSpeed = maxSpeed;
            NumSeats = numSeats;
        }
    }
}
