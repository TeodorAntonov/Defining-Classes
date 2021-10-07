using System;
using System.Linq;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<Car> carlist = new HashSet<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carCreator = Console.ReadLine().Split(" ");
                Car car = new Car(carCreator[0], double.Parse(carCreator[1]), double.Parse(carCreator[2]), 0);
                carlist.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmd = command.Split(" ");
                string driver = cmd[0];
                string carModel = cmd[1];
                double amountOfKm = double.Parse(cmd[2]);

                foreach (var car in carlist.Where(x => x.Model == carModel))
                {
                    if ((car.FuelAmount - car.FuelConsumptionPerKilometer * amountOfKm) < 0 )
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                        continue;
                    }
                    car.TravelledDistance += amountOfKm;
                    car.FuelAmount -= car.FuelConsumptionPerKilometer * amountOfKm;
                    
                }
                command = Console.ReadLine();
            }

            foreach (var item in carlist)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}
