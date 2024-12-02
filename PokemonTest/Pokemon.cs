using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTest
{
    internal class Pokemon
    {
        private string Name { get; set; }
        public int Health;
        public int Strength;
        public string Type;

        public Pokemon(string name, int health, int strength, string type)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Type = type;
        }

        public void PrintStats()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Health);
            Console.WriteLine(Strength);
            Console.WriteLine(Type);
        }

        public string GetName()
        {
            return Name;
        }
    }
}
