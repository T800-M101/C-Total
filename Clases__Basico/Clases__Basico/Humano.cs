using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases__Basico
{
    class Humano
    {
        // Miembro variable
        private string _primerNombre;
        private string _apellido;
        private string _colorOjos;
        private int _edad;



        // Constructor por defecto
        public Humano()
        {
            Console.WriteLine("Contructor llamado. Objeto creado");
        }

        // Miembro constructor parametrizado
        public Humano(string nombre, string apellido, string colorOjos, int edad)
        {
            _primerNombre = nombre;
            _apellido = apellido;
            _colorOjos = colorOjos;
            _edad = edad;
        }


        public Humano(string nombre, string apellido, string colorOjos)
        {
            _primerNombre = nombre;
            _apellido = apellido;
            _colorOjos = colorOjos;
            
        }


        public Humano(string nombre, string apellido, int edad)
        {
            _primerNombre = nombre;
            _apellido = apellido;
            _edad = edad;

        }

        public Humano(string nombre, string apellido)
        {
            _primerNombre = nombre;
            _apellido = apellido;
           

        }

        // Miembro método
        public void Presentarme()
        {
            if(_primerNombre != null && _apellido != null && _colorOjos != null && _edad != 0)
            {
              Console.WriteLine($"Hola, soy {_primerNombre} {_apellido}. Mis ojos son de color {_colorOjos} y tengo {_edad} años.");
            }

            if (_primerNombre != null && _apellido != null && _colorOjos != null && _edad == 0 )
            {
             Console.WriteLine($"Hola, soy {_primerNombre} {_apellido}. Mis ojos son de color {_colorOjos}");
            }
            
            if(_primerNombre != null && _apellido != null && _colorOjos == null && _edad != 0)
            {
                Console.WriteLine($"Hola, soy {_primerNombre} {_apellido}. Tengo {_edad} años.");
            }
            
            if(_primerNombre != null && _apellido != null && _colorOjos == null && _edad == 0)
            {
                Console.WriteLine($"Hola, soy {_primerNombre} {_apellido}.");
            }



            
        }
    }
}
