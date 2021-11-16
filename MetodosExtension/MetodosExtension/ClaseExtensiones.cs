using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    // La clase donde se guardan los métodos de extención debe ser static
    static class ClaseExtensiones
    {
        // El método de exyensión debe ser static y public. El parámetro this se refiere al tipo de dato que se va a extender
        public static int Suma(this int i, int numero)
        {
            return i + numero;
        }

        public static int Multipla(this int i, int numero)
        {
            return i * numero;
        }


        public static int Divide(this int i, int numero)
        {
            int result = 0; ;
            try
            {
                 result = i / numero;
               
                
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("No se puede dividir por cero");
            }
            return result;

        }


        public static int multiplica(int i, int numero)
        {
            return i * numero;
        }
    }
}
