using System;

namespace EjemploDelegados
{
    class Program
    {
        /*
           Un delegado es un tipo que representa referencias a métodos con una lista de parámetros
           y un tipo de valor devuelto. Cuando se crea un instancia de un delegado, puedes asociar
           su instancia a cualquier método mediante una signatura compatible y un tipo de valor devuelto.
           Puedes invocar (o llamar) al método a través de la instancia del delegado.

        a) Los delegados son similares a los punteros de funciones en C++ (pero totalmente orientados a objetos en C#)
        b) Los delegados pueden usarse para definir métodos CallBack
        c) Los delegados se pueden cambiar
            - Muy importante para eventos: un evento puede llamar a varios métodos
        d) Los métodos no necesitan conincidir exactamente con el tipo del delegado (covarianza y contravarianza)
        e) Los delegados permiten el uso de funciones anónimas (que permiten pasar bloques de código como parametros en lugar de un
           método definido por separado. Son funciones sin nombre)

        * La covarianza permite pasar un tipo derivado cuando se espera un tipo de base.
           Ejemplo: FileStream cuando se esperaba Stream

        * La contravarianza permite pasar un tipo de base cuando se espera un tipo derivado
          Ejemplo: Stream cuando se esperaba FileStream

         */

        public delegate double HacerCalculo(double x, double y);

        public static double Suma(double a, double b)
        {
            Console.WriteLine($"a + b es: {a+b}");
            return a + b;
        }

        public static double Division(double a, double b)
        {
            Console.WriteLine($"a / b es: {a / b}");
            return a / b;
        }

        public static double Resta(double a, double b)
        {
            Console.WriteLine($"a - b es: {a - b}");
            return a - b;
        }
        static void Main(string[] args)
        {

            //  ============ DELEGADOS SIMPLES ==========================
            // Aqui no se usan los parentesis porque no se esta llamanado al método suma, solo se  esta apuntando a él.
            HacerCalculo miSuma = Suma;

            //miSuma(5.0,5.0);

            HacerCalculo miDivision = Division;

            //miDivision(5.0,5.0);

            // ============ DELEGADOS MULTIDIFUSION =============================

            HacerCalculo calculoMultiple = miSuma + miDivision;
            calculoMultiple += Resta;

            calculoMultiple(3.2,3.2);

           
        }
    }
}
