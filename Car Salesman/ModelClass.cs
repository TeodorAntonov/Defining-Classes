using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public abstract class ModelClass
    {
        public ModelClass(string model)
        {
            Model = model;
        }
        public string Model { get; set; }
    }
}
