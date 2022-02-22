using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    abstract class Vehicle
    {
        public double Mileage { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }

        public virtual string ShowInfo() => $"Brand: {Brand}.\nColor: {Color}.\nMileage: {Mileage} kilometers.";

        public abstract void Drive(double km);
    }
}
