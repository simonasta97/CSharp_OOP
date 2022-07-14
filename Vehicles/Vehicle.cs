﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public double TankCapacity { get; set; }
        protected abstract double AdditionalConsumption { get; }
        public Vehicle(double fuelQuantity, double fuelConsumption,double tankCapacity)
        {
            TankCapacity = tankCapacity;

            if (fuelQuantity > TankCapacity)
            {
                FuelQuantity = 0;
            }
            else
            {
                FuelQuantity = fuelQuantity;
            }

            FuelConsumption = fuelConsumption;
        }
        public string Drive(double distance)
        {
            double requiredFuel = (FuelConsumption + AdditionalConsumption) * distance;
            if (requiredFuel <= FuelQuantity)
            {
                FuelQuantity -= requiredFuel;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }
        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }

            if (fuel + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            FuelQuantity += fuel;
        }


        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
