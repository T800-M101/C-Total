using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaDeDecisiones
{
    class SuperJuego
    {
        
        private int _puntajeRecord = 100;
        private string _jugadorRecord = "memo";

        public void Intentalo(int puntos, string jugador)
        {

            if(puntos > _puntajeRecord)
            {
                _puntajeRecord = puntos;
                _jugadorRecord = jugador;
                Console.WriteLine($"La nueva puntación más alta es {_puntajeRecord}.");
                Console.WriteLine($"La puntuación más alta fue lograda por {_jugadorRecord}.");
            }
            else
            {
              Console.WriteLine($"La puntuación más alta de {_puntajeRecord} no se ha podido súperar, y aún esta en manos de {_jugadorRecord}");

            }




        }
    }
}
