﻿using System;

namespace ClaseMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 13;
            int b = 9;

            Console.WriteLine($"Redondeo hacia arriba de 15.3 es {Math.Ceiling(15.3)}");
            Console.WriteLine($"Redondeo hacia abajo de 15.3 es {Math.Floor(15.3)}");
            Console.WriteLine($"El valor mas bajo entre {a} y {b} es {Math.Min(a,b)}");
            Console.WriteLine($"El valor mas alto entre {a} y {b} es {Math.Max(a,b)}");
            Console.WriteLine($"3 elevado a la 5 es {Math.Pow(3,5)}");
            Console.WriteLine($"Pi es {Math.PI}");
            Console.WriteLine($"La raiz cuadrada de 25 es  {Math.Sqrt(25)}");
            Console.WriteLine($"El absoluto de -25 es  {Math.Abs(-25)}");
            Console.WriteLine($"El coseno de 1 es  {Math.Cos(1)}");

        }
    }
}
