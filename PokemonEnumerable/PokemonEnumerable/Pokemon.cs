using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEnumerable
{
    public class Pokemon
    {
        private string _name;
        private int _poder;

        public Pokemon(string name, int poder)
        {
            _name = name;
            _poder = poder;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Poder
        {
            get => _poder;
            set => _poder = value;
        }

    }
}
