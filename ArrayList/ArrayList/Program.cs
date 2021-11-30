using System;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar un ArrayList indeterminado
            ArrayList miArrayList = new ArrayList();

            // Declarar un ArrayList determinado
            ArrayList miArrayList2 = new ArrayList(100);


            // Agregar elementos al ArrayList
            miArrayList.Add(25);
            miArrayList.Add("Hola");
            miArrayList.Add(13.37);
            miArrayList.Add(13);
            miArrayList.Add(128);
            miArrayList.Add(25.3);

            // Eliminar elementos del ArrayList por valor
            miArrayList.Remove(13);

            // Eliminar elementos del ArrayList por posicion
            miArrayList.RemoveAt(0);

            // Contar elementos del ArrayList
            Console.WriteLine("El ArrayList tiene {0} elementos", miArrayList.Count);
            double suma = 0;
            foreach (Object obj  in miArrayList)
            {

                if(obj is int)
                {
                    suma += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    suma += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }

            }
                Console.WriteLine("La suma es {0}", suma);

        }
    }
}
