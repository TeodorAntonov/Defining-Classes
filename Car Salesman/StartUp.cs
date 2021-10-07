using System;
using System.Linq;
using System.Collections.Generic;

namespace CarSalesman
{
   public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> carsList = new List<Car>();
            List<Engine> engines = new List<Engine>();

            int enginesLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < enginesLines; i++)
            {
                string[] aboutEngine = Console.ReadLine().Split(" ");
                string model = aboutEngine[0];
                int power = int.Parse(aboutEngine[1]);

                int? displacement = null;
                string efficiency = string.Empty;
                if (aboutEngine.Length > 2)
                {
                    if (int.TryParse(aboutEngine[2], out var displacementVal))
                    {
                        displacement = displacementVal;
                    }
                    else if (aboutEngine.Length == 3)
                    {
                        efficiency = aboutEngine[2];
                    }
                    if (aboutEngine.Length == 4)
                    {
                        efficiency = aboutEngine[3];
                    }
                   
                }

                Engine engineNew = new Engine(model, power, displacement, efficiency);

                engines.Add(engineNew);
            }

            int carsLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsLines; i++)
            {
                string[] aboutCars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = aboutCars[0];
                string engineOfCar = aboutCars[1];

                int? weight = null;
                string color = string.Empty;
                if (aboutCars.Length > 2)
                {
                    if (int.TryParse(aboutCars[2], out var weighVal))
                    {
                        weight = weighVal;
                    }
                    else if (aboutCars.Length == 3)
                    {
                        color = aboutCars[2];
                    }
                    if (aboutCars.Length == 4)
                    {
                        color = aboutCars[3];
                    }
                   
                }

                foreach (var engineSelector in engines)
                {
                    if (engineSelector.Model == engineOfCar)
                    {
                        Car newCar = new Car(model, engineSelector, weight, color);
                        carsList.Add(newCar);
                        break;
                    }
                }
            }

            foreach (var car in carsList)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
