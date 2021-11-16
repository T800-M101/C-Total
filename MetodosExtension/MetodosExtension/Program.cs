using System;

namespace MetodosExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero = 55;
            //Console.WriteLine("Ingresa un numero");
            //int numero2 = Int32.Parse(Console.ReadLine());
            //double resultado = numero.Suma(numero2);
            //Console.WriteLine($"Sumando {numero} y {numero2}...");
            //Console.WriteLine($"{numero} + {numero2} = {resultado}");



            
            //Console.WriteLine("Ingresa un numero");
            //numero2 = Int32.Parse(Console.ReadLine());
            //resultado = numero.Divide(numero2);

            //if (numero2 == 0) return;
            
            
            //Console.WriteLine($"Dividiendo {numero} y {numero2}...");
            //Console.WriteLine($"{numero} / {numero2} = {resultado}");


            //Console.WriteLine("Ingresa un numero");
            //numero2 = Int32.Parse(Console.ReadLine());
            //resultado = numero.Multipla(numero2);
            //Console.WriteLine($"Multiplicando {numero} y {numero2}...");
            //Console.WriteLine($"{numero} * {numero2} = {resultado}");

            //BOXING converting from value to reference
             int num = 123;
            Object obj = num;
            Console.WriteLine(num);
            Console.WriteLine(obj);

            //UNBOXING converting from object to value

            Object obj2 = 321;
            int num2 = (int)obj2;
            Console.WriteLine(obj2);
            Console.WriteLine(num2);


        }
    }
}
