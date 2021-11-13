using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string patron = @"\d";
            string texto = "Hola, mi numero telefonico es 123456";

            Regex regex = new Regex(patron);

            MatchCollection aciertos = regex.Matches(texto);
            Console.WriteLine($"{aciertos.Count} aciertos encontrados en: '{texto}'");

            foreach (Match acierto in aciertos)
            {
                GroupCollection group = acierto.Groups;
                Console.WriteLine($"El número {group[0].Value} fue encontrado en el indice {group[0].Index}");
            }
        }
    }
}
