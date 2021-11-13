using System;

namespace ClaseRandom
{
    class Program
    {
        static void Main(string[] args)
        {

            //Random dado = new Random();
            //int numCara;
            //for (int i = 0; i < 10; i++)
            //{
            //    numCara = dado.Next(1,7);
            //    if(numCara == 6)
            //    {
            //        Console.WriteLine($"Felicidades obtuviste {numCara}!!");
            //    }
            //    else
            //    {

            //    Console.WriteLine($"Tirada {i + 1}: {numCara}");
            //    }
            //}

            Random ruedaDeLaFortuna = new Random();
            int respuesta;
            for (int i = 0; i < 3; i++)
            {
                respuesta = ruedaDeLaFortuna.Next(1, 4);
                Console.WriteLine("Escribe tu pregunta");
                Console.ReadLine();
                if (respuesta == 1)
                {
                    Console.WriteLine("Si");
                }
                else if(respuesta == 2)
                {
                    Console.WriteLine("Quizá");
                }
                else
                {
                    Console.WriteLine("No");
                }


            }
        }
    }
}
