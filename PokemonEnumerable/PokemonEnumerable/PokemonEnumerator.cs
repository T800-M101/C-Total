using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEnumerable
{
    class PokemonEnumerator : IEnumerator
    {
        public Pokemon[] pokemonList;
        private int _position = -1;

        public PokemonEnumerator(Pokemon[] list)
        {
            pokemonList = list;
        }
        public object Current => pokemonList[_position];

        public bool MoveNext()
        {
            _position++;
            return (_position < pokemonList.Length) ? true : false;
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
