using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Car : Vehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentFuel { get; set; }
        public double FuelFor1km { get; set; }

        public override void Drive(double km)
        {
            if (CurrentFuel >= FuelFor1km * km)
            {
                CurrentFuel -= FuelFor1km * km;
                Mileage += km;
                return;
            } Console.WriteLine("Benzininiz kifayet qeder deyil.");
        }
    }
}
