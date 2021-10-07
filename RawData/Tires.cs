using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tires
    {
        public Tires(double age, double pressure)
        {
            Age = age;
            Pressure = pressure;
        }

        public double Age { get; set; }
        public double Pressure { get; set; }
    }
}
