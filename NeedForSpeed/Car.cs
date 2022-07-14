using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car :Vehicle
    {
        private const double DefaultFuelConsumption = 3;
        public Car(int horsePowe, double fuel)
            :base(horsePowe,fuel)
        {

        }

        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
