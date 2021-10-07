using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine : ModelClass
    {
        public Engine(string model, int power, int? displacement, string efficiency) : base(model)
        {
            Power = power;
            Displacement = displacement != null ? displacement.Value.ToString() : "n/a";
            Efficiency = efficiency != string.Empty ? efficiency.ToString() : "n/a";
        }

        public int Power { get; set; }
        public string Displacement { get; }
        public string Efficiency { get; set; }
        public override string ToString()
        {
            return $"{Model}:{Environment.NewLine}    Power: {Power}{Environment.NewLine}    Displacement: {Displacement}{Environment.NewLine}    Efficiency: {Efficiency}";
        }
    }
}
