using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Color = "Black";
            car.Brand = "Mercedes";
            car.Mileage = 325.8;
            car.FuelCapacity = 100;
            car.FuelFor1km = 0.5;
            car.CurrentFuel = 80;

            Console.WriteLine($"{car.ShowInfo()}\nCapacity: {car.FuelCapacity}\nFuel for 1 km: {car.FuelFor1km}\nCurrent fuel: {car.CurrentFuel}");

            car.Drive(10);

            Console.WriteLine($"{car.ShowInfo()}\nCapacity: {car.FuelCapacity}\nFuel for 1 km: {car.FuelFor1km}\nCurrent fuel: {car.CurrentFuel}");
        }
    }
}
