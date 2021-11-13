using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class CAuto : IAutomovil
    {
        private double _costo;
        private double _tenencia;
        string _modelo;
        double _valorFijo = 5000.0;
        //Constructor
        public CAuto(string modelo, double costo)
        {
            // Inicializamos los datos
            _costo = costo;
            _modelo = modelo;
        }

        // Métodos de la interfaz
        public void CalcularTenencia(double impuesto)
        {
            // Calculamos el impuesto
            _tenencia = _valorFijo + _costo * impuesto;
        }

        public void MostrarInformacion()
        {
            // Mostramos la informaciín necesaria
            Console.WriteLine($"Tu automovil: {_modelo}");
            Console.WriteLine($"Costo {_costo}, con una tenencia de {_tenencia}");
            Console.WriteLine($"Total {_costo + _tenencia}");
            Console.WriteLine($"----------------");
        }
    }
}
