using System;

namespace MetodosAnonimos
{
    class Program
    {
        public delegate string ObtenerDelegadoTexto(string nombre);
        static void Main(string[] args)
        {
            // Método anónimo o delagado en linea
            // Los métodos con nombre se compilan primero que los anónimos
            ObtenerDelegadoTexto miDelegado = delegate (string nombre)
            {
                return $"Hola, {nombre}";
            };


            Console.WriteLine(miDelegado("Guillermo"));
            Mostrar(miDelegado);
        }
        public static void Mostrar(ObtenerDelegadoTexto miDelegado)
        {
            Console.WriteLine(miDelegado("Mundo"));
        }
        public static void DecirHola()
        {
            Console.WriteLine("Hola");
        }
    }
}
