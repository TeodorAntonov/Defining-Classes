using System;
using System.Linq;
using System.Collections.Generic;

namespace RawData
{
    public class Program
    {
       public  static void Main(string[] args)
        {
            List<Car> carsList = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ");
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double tire1Presure = double.Parse(carInfo[5]);
                double tire1Age = double.Parse(carInfo[6]);
                double tire2Presure = double.Parse(carInfo[7]);
                double tire2Age = double.Parse(carInfo[8]);
                double tire3Presure = double.Parse(carInfo[9]);
                double tire3Age = double.Parse(carInfo[10]);
                double tire4Presure = double.Parse(carInfo[11]);
                double tire4Age = double.Parse(carInfo[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Tires tire1 = new Tires(tire1Age, tire1Presure);
                Tires tire2 = new Tires(tire2Age, tire2Presure);
                Tires tire3 = new Tires(tire3Age, tire3Presure);
                Tires tire4 = new Tires(tire4Age, tire4Presure);

                Car car = new Car(model, engine, cargo);
                car.TiresAll.Add(tire1);
                car.TiresAll.Add(tire2);
                car.TiresAll.Add(tire3);
                car.TiresAll.Add(tire4);

                carsList.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var item in carsList.Where(x => x.Cargo.Type == "fragile").Where(t=>t.TiresAll.Any(k => k.Pressure < 1)))
                {
                    Console.WriteLine(item.Model);
                }
            }
            else
            {
                foreach (var item in carsList.Where(x => x.Cargo.Type == "flammable").Where(x => x.Engine.Power > 250))
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
}
