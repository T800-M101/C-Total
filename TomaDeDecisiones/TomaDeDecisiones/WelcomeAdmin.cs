using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaDeDecisiones
{
    class WelcomeAdmin
    {
        private bool _esAdmin = false;
        private bool _estaRegistrado = false;
        private string _nombreUsuario = "";

        public void ValidarUsuario(string estaRegistrado, string esAdmin, string nombreUsuario)
        {

            estaRegistrado = estaRegistrado.ToLower();
            if (estaRegistrado.Equals("si"))
            {
            _estaRegistrado = true;

            }


            esAdmin = esAdmin.ToLower();
            if (esAdmin.Equals("si"))
            {
                _esAdmin = true;

            }

            _nombreUsuario = nombreUsuario;
        
           

            if (_estaRegistrado)
            {

                if(_esAdmin)
                {
                    Console.WriteLine($"Hola Admin");
                    

                }

               else if(_esAdmin && _nombreUsuario != "")
                {
                    Console.WriteLine($"Hola Admin");

                    
                }
                
                else if(_esAdmin && _nombreUsuario == "")
                {

                    Console.WriteLine($"Hola usuario registrado");
                }

                else if(!_esAdmin && _nombreUsuario != "")
                {
                    Console.WriteLine($"Hola {_nombreUsuario}");

                }
                else
                {
                    Console.WriteLine($"Hola usuario registrado");

                }


            }
            else
            {

            Console.WriteLine("Por favor registrate");
            }


        }
    }
}
