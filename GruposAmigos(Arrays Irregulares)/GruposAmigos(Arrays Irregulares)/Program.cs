using System;

namespace GruposAmigos_Arrays_Irregulares_
{
    class Program
    {
        static void Main(string[] args)
        {

            string[][] personas = new string[][]
            {
                new string[] {"Juan", "Felipe",},
                new string[] {"Jaime", "Rebeca","Lourdes","Claudia"},
                new string[] {"Memo", "Mary","Brandon"}
            };


            Console.WriteLine("Hola {0}, ella es {1}", personas[0][0], personas[1][1]); // "Hola Juan, ella es Rebeca"
            Console.WriteLine("Hola {0}, ella es {1}", personas[2][0], personas[1][2]); // "Hola Memo, ella es Lourdes"
            Console.WriteLine("Hola {0}, él es {1}", personas[2][1], personas[0][1]);   // "Hola Mary, él es Felipe"
            Console.WriteLine("Hola {0}, él es {1}", personas[2][2], personas[1][0]);  //  "Hola Brandon, él es Jaime"
        }
    }
}
