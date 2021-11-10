using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaDeDecisiones
{
    class Ternario
    {
        private double _temperaturaIngresada = 0;
        private string _mensajeTemperatura = String.Empty;
        private string _valorIngresado = String.Empty;

        public string VerificarTemperatura()
        {
            Console.WriteLine("Ingrese la temperatura actual");
            _valorIngresado = Console.ReadLine();

            bool doubleValido = double.TryParse(_valorIngresado, out _temperaturaIngresada);

            if (doubleValido)
            {
                _mensajeTemperatura = _temperaturaIngresada <= 15 ?
                    // si es verdadero
                    "Hace mucho frio" :
                    // si es falso
                    (_temperaturaIngresada >= 16 && _temperaturaIngresada <= 28) ?
                    // si es verdadero
                    "Hace un clima agradable" :
                    // si es falso
                    _temperaturaIngresada > 28 ?
                    // si es verdadero
                    "Hace mucho calor" :
                    // si es falso
                    "";
            }
            else
            {
                _mensajeTemperatura = "No se pudo parsear el dato";
            }

            return _mensajeTemperatura;
        }
    }
}
