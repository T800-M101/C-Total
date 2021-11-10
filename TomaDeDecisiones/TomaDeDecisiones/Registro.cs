using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaDeDecisiones
{
    class Registro
    {

        private string _usuario;
        private string _password;
        public void Registarse(string usuario, string password)
        {
            _usuario = usuario;
            _password = password;
        }

        public void loguarse(string usuario, string password)
        {
            if (_usuario != usuario || _password != password )
            {
                Console.WriteLine("Usuario o contraseña invalidos");
            }
            else
            {
                 Console.WriteLine($"Bienvenido {usuario}");

            }

        }


    }
}
