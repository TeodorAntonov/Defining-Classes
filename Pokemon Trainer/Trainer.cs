using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Trainer
{
    public class Trainer : Character
    {
        public Trainer(string name, int numberOfBadges, List<Pokemon> pokemonCollection, int id) : base(name)
        {
            NumberOfBadges = numberOfBadges;
            PokemonCollection = pokemonCollection;
            ID = id;
        }

        public int NumberOfBadges { get; set; }
        public int ID { get; set; }
        public List<Pokemon> PokemonCollection { get; set; }
    }
}
