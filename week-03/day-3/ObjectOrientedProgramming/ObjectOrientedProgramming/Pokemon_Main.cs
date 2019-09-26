using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemonOfAsh = InitializePokemon();

            // Every pokemon has a name and a type.
            // Certain types are effective against others, e.g. water is effective against fire.

            // Ash has a few pokemon.
            // A wild pokemon appeared!

            Pokemon wildPokemon = new Pokemon("Oddish", PokemonType.Leaf, PokemonType.Water);

            // Which pokemon should Ash use?

            Console.Write("I choose iyou, ");
            for (int i = 0; i < pokemonOfAsh.Count; i++)
            {
                if (pokemonOfAsh[i].IsEffectiveAgainst(wildPokemon) == true)
                {
                    Console.WriteLine(pokemonOfAsh[i].Name);
                }

            }
            Console.ReadKey();
        }

        private static List<Pokemon> InitializePokemon()
        {
            return new List<Pokemon>
            {
                new Pokemon("Balbasaur", PokemonType.Leaf, PokemonType.Water),
                new Pokemon("Pikatchu", PokemonType.Electric, PokemonType.Water),
                new Pokemon("Charizard", PokemonType.Fire, PokemonType.Leaf),
                new Pokemon("Balbasaur", PokemonType.Water, PokemonType.Fire),
                new Pokemon("Kingler", PokemonType.Water, PokemonType.Fire)
            };
        }
    }
}
