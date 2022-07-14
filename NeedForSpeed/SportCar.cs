using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DefaultFuelConsumption = 10;
        public SportCar(int horsePowe, double fuel) 
            : base(horsePowe, fuel)
        {
        }
        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
