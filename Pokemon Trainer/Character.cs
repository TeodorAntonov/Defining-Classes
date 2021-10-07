using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Trainer
{
    public abstract class Character
    {
        public Character(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
