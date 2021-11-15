using System;

namespace Nulabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.1416;

            bool? valor = new bool?();
            Console.WriteLine($"Nuestros valores son: {num1}, {num2}, {num3}, {num4}, {valor}");

            bool? esHombre = null;

            if(esHombre == true)
            {
                Console.WriteLine("El usuario es hombre");
            }
            else if(esHombre == false)
            {
                Console.WriteLine("El usuario es mujer");
            }
            else
            {
                Console.WriteLine("No se especificó genero");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if (num6 == null)
            {
                num8 = 0.00;
            }
            else
            {
                num8 = (double)num6;
            }

            Console.WriteLine($"El valor de num8 es {num8}");

            num8 = num6 ?? 8.53; //13.1
            Console.WriteLine($"El valor de num8 es {num8}");
            num8 = num7 ?? 8.53; //8.53
            Console.WriteLine($"El valor de num8 es {num8}");

        }
    }
}
