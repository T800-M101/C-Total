using System;
using System.Globalization;

namespace FechaHora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dar formato a una fecha
            DateTime tiempo = new DateTime(1971,12,25);
            Console.WriteLine($"Mi fecha de naciminetos es {tiempo}");

            // Mostrar fecha actual
            Console.WriteLine(DateTime.Today);

            // Mostrar hora actual
            Console.WriteLine(DateTime.Now);

            // Saber el dia de mañana

            DateTime tomorrow = ProximoDia();
            Console.WriteLine($"Mañana será {tomorrow}");

            // Obtener el dia de hoy
            DateTime fechaActual = DateTime.Now;
            string hoy = fechaActual.ToString("dddd", CultureInfo.CreateSpecificCulture("es-MX"));
            string mes = fechaActual.ToString("MMMM", CultureInfo.CreateSpecificCulture("es-MX"));
           
            // string hoy = DateTime.Today.DayOfWeek;
            Console.WriteLine($"Hoy es {hoy} de {mes}");

            // Primer dia de un año
            Console.WriteLine(PrimerDiaDelAnio(1999));

            // Cuantos dias tiene un mes en particular
            int dias = DateTime.DaysInMonth(2021,2);
            Console.WriteLine($"El mes de Febrero de 2021 tuvo {dias} dias");

            // Devolver una parte de la fecha
            DateTime ahora = DateTime.Now;
            Console.WriteLine($"Minuto: {ahora.Minute}");

            Console.WriteLine($"Ahora son las {ahora.Hour} horas con {ahora.Minute} minutos y {ahora.Second} segundos");

            // Dias de diferencia
            Console.WriteLine("Por favor ingresa una fecha con el siguiente formato: aaaa-mm-dd");
            string ingreso = Console.ReadLine();

            if(DateTime.TryParse(ingreso, out tiempo))
            {
                Console.WriteLine(tiempo);
                TimeSpan diasEnteros = ahora.Subtract(tiempo);
                Console.WriteLine($"Dias que pasaron desde esa fecha: {diasEnteros.Days}");
            }
            else
            {
                Console.WriteLine("Ingreso incorrecto.");
            }




        }

        static DateTime ProximoDia()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime PrimerDiaDelAnio(int anio)
        {
            return new DateTime(anio, 1, 1);
        }
    }
}
