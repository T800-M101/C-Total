using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEnumerable
{
    public class Pokemones : IEnumerable
    {

        public Pokemon[] pokemonList;

        public Pokemones()
        {
            pokemonList = new Pokemon[]
            {
                new Pokemon("Bulbasor",2800),
                new Pokemon("Charmander",3000),
                new Pokemon("Charizard",3800),
                new Pokemon("Squirtle",2950),
                new Pokemon("Pikachu",3850)
            };
        }
        public IEnumerator GetEnumerator()
        {
            return new PokemonEnumerator(pokemonList);
        }
    }
}
