using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListVSList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inmutable, limitado a un tipo de datos
            int[] puntajes = new int[] { 99, 96, 87, 76 };

            List<int> lista = new List<int>() { 1, 2, 3, 4 };

            lista.Add(0);
            lista.Add(32);
            lista.Sort();
            lista.RemoveRange(2,2);
            
            
            foreach (int dato in lista)
            {
                Console.WriteLine(dato);
            }

            Console.WriteLine(lista.Contains(4));

            int indice = lista.FindIndex(x => x==4);
            Console.WriteLine("El indice del numero 4 es {0}", indice);

            lista.RemoveAt(indice);

            Console.WriteLine("Imprimiendo lista");
            lista.ForEach(i => Console.WriteLine(i));

            ArrayList arr1 = new ArrayList();
            arr1.Add(1);
            arr1.Add("dos");
            arr1.Add("3");
            arr1.Add(new numero { n = 4});

            Console.WriteLine("Imprimiendo ArrayList");
            foreach (object obj in arr1)
            {
                
                Console.WriteLine(obj);
            }
        }
    }

    class numero
    {
        public int n { get; set; }

        public override string ToString()
        {
            return n.ToString();
        }
    }
}
