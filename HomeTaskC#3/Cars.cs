using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskC_3
{
    internal class Cars
    {
        public string Brand;
        public string Model;
        public int ProductionDate;
        public string FuelType;
        public string Color;

        public Cars(string brand, string model, int productionDate, string fuelType, string color)
        {
            Brand = brand;
            Model = model;
            ProductionDate = productionDate;
            FuelType = fuelType;
            Color = color;
        }

        public void PrintInfo(Cars car)
        {

            Console.WriteLine($"{Brand}, {Model}, {ProductionDate}, {FuelType}, {Color}");
        }
    }
}
