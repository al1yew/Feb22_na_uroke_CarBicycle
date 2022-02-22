using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Bicycle : Vehicle
    {
        public override void Drive(double km)
        {
            Mileage += km;
        }
    }
}
