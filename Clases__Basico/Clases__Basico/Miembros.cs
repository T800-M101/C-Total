using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases__Basico
{
    class Miembros
    {
        // Miembros - Campos Privados - Variables (En minúsculas) 
        private string _nombrePersona;
        private string _tituloTrabajo;
        private int _salario;

        // Miembros - Campos Publicos
        public int edad;

        // Miembros - Propiedades (En mayúsculas)
        public string TituloTrabajo { get; set; }

        public string TituloTrabajo2 
        {
            get 
            {
                return _tituloTrabajo;
            }
            set 
            {
                _tituloTrabajo = value;
            }


        }

        // Miembros - Métodos privados

        private void CompartirInfoPrivada()
        {
            Console.WriteLine($"Hola mi salario es: {_salario}");
        }

        // Miembros - Métodos públicos
        public void Amigo(bool esAmigo)
        {
            if (esAmigo)
            {
                CompartirInfoPrivada();
            }
            else
            {
                Console.WriteLine($"Hola, mi nombre es {_nombrePersona}");
            }
        }

        // Miembro Constructor
        public Miembros()
        {
             edad = 30;
            _nombrePersona = "Memo";
            _salario = 5000;
            _tituloTrabajo = "Desarrollador";

            Console.WriteLine("Objeto creado");
        }

        // Miembro Finalizador o Destructor 
        // a) No puede heredarse
        // b) No puede llamarse en niguna parte, ocurre ante determinados eventos especialmente 
        //    cuando el objeto salga de su alcence

        ~Miembros()
        {
            // Limpia declaraciones
            Console.WriteLine("Destrucción de objeto");
        }

    }
}
