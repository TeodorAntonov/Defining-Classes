using System;
using System.Linq;
using System.Collections.Generic;

namespace Pokemon_Trainer
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Trainer> trainersList = new SortedDictionary<string, Trainer>();
            string command = Console.ReadLine();
            var id = 0;
            while (command != "Tournament")
            {
                string[] cmd = command.Split(" ");
                string name = cmd[0];
                string pokemon = cmd[1];
                string element = cmd[2];
                int health = int.Parse(cmd[3]);

                Pokemon poke = new Pokemon(pokemon, element, health);

                if (!trainersList.ContainsKey(name))
                {
                    Trainer trainer = new Trainer(name, 0, new List<Pokemon>(), id);
                    trainer.PokemonCollection.Add(poke);
                    trainersList.Add(name, trainer);
                    id++;
                }
                else
                {
                    trainersList[name].PokemonCollection.Add(poke);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                var element = command;
                //foreach (var trainer in trainersList.Values)
                //{
                //    var pokemon = trainer.PokemonCollection.FirstOrDefault(p => p.Element == command);
                //    if (pokemon == null)
                //    {
                //        trainer.PokemonCollection.ForEach(p =>
                //        {
                //            p.Health -= 10;
                //        });

                //        var deadPokemon = trainer.PokemonCollection.Where(p => p.Health <= 0);
                //        trainer.PokemonCollection.RemoveAll(p => deadPokemon.Contains(p));
                //    }
                //    else
                //    {
                //        trainer.NumberOfBadges++;
                //    }
                //}


                foreach (var trainer in trainersList.Values)
                {
                    int removePokemon = 0;
                    var pokemonToRemove = new List<Pokemon>();
                    foreach (var pokemon in trainer.PokemonCollection)
                    {
                        if (pokemon.Element == element)
                        {
                            trainer.NumberOfBadges++;
                            break;
                        }
                        else
                        {
                            removePokemon++;
                        }
                    }

                    for (int i = 0; i < trainer.PokemonCollection.Count; i++)
                    {
                        if (trainer.PokemonCollection.Count == removePokemon)
                        {
                            trainer.PokemonCollection[i].Health -= 10;
                        }
                        if (trainer.PokemonCollection[i].Health <= 0)
                        {
                            pokemonToRemove.Add(trainer.PokemonCollection[i]);
                        }
                    }

                    foreach (var pokeToRemove in pokemonToRemove)
                    {
                        trainer.PokemonCollection.Remove(pokeToRemove);
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var trainer in trainersList.OrderByDescending(x => x.Value.NumberOfBadges).ThenBy(x => x.Value.ID))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.NumberOfBadges} {trainer.Value.PokemonCollection.Count}");
            }
        }
    }
}
