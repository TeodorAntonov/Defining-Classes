using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Trainer
{
    public class Pokemon : Character
    {
        private int _health;

        public Pokemon(string name, string element, int health) : base(name)
        {
            Element = element;
            Health = health;
        }

        public string Element { get; set; }

        public int Health { get => this._health; set => this._health = value; }
    }
}
