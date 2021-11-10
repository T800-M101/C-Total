using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaDeDecisiones
{
    class Switch
    {
        private string _piedraPapelTijera = "piedra";

        public void PiedraPapelTijera(string jugada)
        {
            _piedraPapelTijera = jugada.ToLower();
            switch (_piedraPapelTijera)
            {
                case "piedra":
                    Console.WriteLine("Piedra mata a tijera");
                    break;

                case "papel":
                    Console.WriteLine("Papel mata a piedra");
                    break;

                case "tijera":
                    Console.WriteLine("Tijera mata a papel");
                    break;
                default:
                    Console.WriteLine("Este elemento no forma parte del juego");
                    break;

            }
        }
    }
}
