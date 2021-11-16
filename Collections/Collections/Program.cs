using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        // Las colecciones permiten agregar elementos en tiempo de ejecución. Cosa que los arrays no.
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            //Console.WriteLine("¿Cuantos elementos quieres introducir?");
            //int elementos = Int32.Parse(Console.ReadLine());

            //for (int i = 0; i < elementos; i++)
            //{
            //    Console.WriteLine($"Agrega el elemento {i + 1}");
            //    int elemento = Int32.Parse(Console.ReadLine());
            //    numeros.Add(elemento);

            //}

            //Console.WriteLine("Imprimiendo la lista de números");
            //numeros.ForEach(numero => Console.WriteLine(numero));

            Console.WriteLine("Introduce los elementos a la colección (0 para terminar)");
            int elemento = 1;
            
            while(elemento != 0)
            {
                elemento = Int32.Parse(Console.ReadLine());
                if(elemento != 0)
                {
                 numeros.Add(elemento);
                }
            }

            //numeros.RemoveAt(numeros.Count -1);

            Console.WriteLine("Imprimiendo elementos");
            numeros.ForEach(numero => Console.WriteLine(numero));

        }
    }
}
