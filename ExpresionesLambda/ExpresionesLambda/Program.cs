using System;
using System.Collections.Generic;

namespace ExpresionesLambda
{
    /*
      Una expresión Lambda es una función anónima que se puede usar para crear delegados o tipos de árbol de expresión.
      Al usar expresiones lambda, puedes ecribir funciones locales que pueden pasarse como argumentos
      o devolverse como el valor de las llamadas a funciones.
      Las expresiones Lambda son particularmente útiles para escribir expresiones de consulta LINQ

     */
    class Program
    {
        public delegate int Calculos(int i);

        public delegate bool Comparacion(int i, Numero n);
        static void Main(string[] args)
        {

            Console.WriteLine("Usando delegados");
            HacerAlgo();
            Console.WriteLine("Usando lambdas");

            HacerAlgoLambda();


            
        }

        public static void HacerAlgo()
        {
            Calculos mate = new Calculos(Cuadrado);
            Console.WriteLine($"El cuadrado de 8 es {mate(8)}");

            List<int> list = new List<int> { 1,2,3,4,5,6,7 };
            List<int> numerosPares = list.FindAll(delegate (int i) 
            {
                return (i % 2 == 0); 
            });

            Console.WriteLine("Números pares");
            foreach (int par in numerosPares)
            {
                
                Console.WriteLine(par);
            }


            Console.WriteLine("Números Impares");

            List<int> numerosImpares = list.FindAll(delegate (int i)
            {
                return (i % 2 == 1);
            });

            foreach (int impar in numerosImpares)
            {
                Console.WriteLine(impar);
            }
        }

        public static void  HacerAlgoLambda()
        {
            Calculos mate = new Calculos(Cuadrado);
            Console.WriteLine($"El cuadrado de 8 es {mate(8)}");

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            List<int> numerosPares = list.FindAll( i => i % 2 == 0);
            Console.WriteLine("Números pares");
            numerosPares.ForEach(i => Console.WriteLine(i));


            Console.WriteLine("Números Impares");

            List<int> numerosImpares = list.FindAll(i => i % 2 == 1);
            numerosImpares.ForEach(i => Console.WriteLine(i));

            // Asignando una nueva instancia del delegado Calculos
            mate = new Calculos(x => x*x*x);
            Console.WriteLine("8 elevado a la cubo es:");
            Console.WriteLine(mate(8));

            // Hacer comparacion
            Comparacion comp = (a, numero) => a == numero.n;
            Console.WriteLine(comp(5, new Numero { n = 5}));
           
        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static int Cuadrado(int i)
        {
            return i * i;
        }

        public static int PorDiez(int i)
        {
            return i * 10;
        }
    }

    public class Numero
    {
        public int n { get; set; }
    }


}
