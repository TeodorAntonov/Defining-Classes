using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private double travelledDistance;
        private double fuelAmount;
        public Car(string model, double fuelAmount, double fuelConsumptiom, double travelledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptiom;
            TravelledDistance = travelledDistance;
        }
        public string Model { get; set; }
        public double FuelAmount
        {
            get
            {
                return fuelAmount;
            }
            set
            {
                fuelAmount = value;
                //if (fuelAmount <= 0)
                //{
                //    Console.WriteLine("Insufficient fuel for the drive");
                //    return;
                //}
            }
        }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance 
        {
            get 
            {
                return travelledDistance;
            }
            set 
            {
                travelledDistance = value;
            }   
        }
    }
}
