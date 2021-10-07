using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car : ModelClass
    {
        public Car(string modelCar, Engine engine, int? weight, string color) : base(modelCar)
        {
            Engine = engine;
            Weight = weight != null ? weight.Value.ToString() : "n/a";
            Color = color != string.Empty ? color.ToString() : "n/a"; ;
        }

        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {           
            return $"{Model}:{Environment.NewLine}  {Engine}{Environment.NewLine}  Weight: {Weight}{Environment.NewLine}  Color: {Color}";
        }
    }
}
