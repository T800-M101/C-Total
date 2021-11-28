using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // ============== DO WHILE ============================================

            //int largoDeTexto = 0;

            //do
            //{

            //    Console.WriteLine("Por favor, ingresa el nombre de un amigo:");
            //    string nombreAmigo = Console.ReadLine();
            //    int largoActual = nombreAmigo.Length;
            //    Console.WriteLine($"{nombreAmigo} tiene {largoActual} letras.");
            //    largoDeTexto += largoActual;
            //    Console.WriteLine($"Llevas acumuladas {largoDeTexto} letras. Tienes espacio para {20 - largoDeTexto} más.");

            //} while (largoDeTexto < 20);

            //Console.WriteLine("Gracias, eso es todo.");

            // =============== WHILE ========================
            //int contador = 0;
            //string textoIngresado = "";

            //while (textoIngresado.Equals(""))
            //{
            //    Console.WriteLine("Por favor, presiona enter cada vez" +
            //                      "que un alumno ingrese al bus. Para finalizar ingresa otro valor");
            //    textoIngresado = Console.ReadLine();

            //    contador++;
            //}
            //Console.WriteLine($"Alumnos en el bus: {contador}");

            // ===================== BREAK & CONTINUE ===============================
            //for (int contador = 0; contador < 10; contador++)
            //{
            //    Console.WriteLine(contador);
            //    if (contador == 3)
            //    {
            //        Console.WriteLine("Me detengo porque alcance el 3");
            //        break;
            //    }
            //}


            //int contador = 0;
            //double calificaciones = 0;
            //string ingresar = "";
            //double promedio = 0;

            //while(ingresar == "")
            //{
            //    double valorParseado;
            //    Console.WriteLine("Ingrese la calificación de alumno o escriba fin para salir");
            //    ingresar = Console.ReadLine();

            //    bool exito = double.TryParse(ingresar, out valorParseado);
            //    if (exito)
            //    {
            //    calificaciones += valorParseado;
            //    contador++;
            //    ingresar = "";
            //    promedio = calificaciones / contador;

            //    }



            //}

            //if (promedio > 0) Console.WriteLine($"El promedio de los alumnos es: {promedio}");
            //if (promedio == 0) Console.WriteLine("El promedio de los alumnos es 0");

            string ingreso = "0";
            int contador = 0;
            List<int> calificaciones = new List<int>();
            //calificaciones.Add(0);
            int numeroActual = 0;
            string calificacionesString = "";

            while (ingreso != "fin")
            {
                calificacionesString = "";
                calificaciones.ForEach(cal => {
                    calificacionesString += cal.ToString();
                    calificacionesString += ",";
                    
                     
                });

                Console.WriteLine($"Las calificaciones ingresadas son: {calificacionesString}");
                Console.WriteLine($"La cantidad de calificaciones ingresadas es de: {contador}");
                Console.WriteLine($"Cuando desee finalizar la carga de datos escriba 'fin'");
                Console.WriteLine($"Por favor ingrese la siguiente calificación");

                ingreso = Console.ReadLine();

                if (ingreso.Equals("fin"))
                {
                    Console.WriteLine("----------------------------------------------");
                    double temp = 0;
                     calificaciones.ForEach(cal =>
                    {
                        temp += (double)cal;
                        
                    });
                    double promedio = temp / (double)contador;
                    Console.WriteLine($"El promedio obtenido por el alumno fue: {promedio}");
                }

                if (int.TryParse(ingreso, out numeroActual) && numeroActual > 0 && numeroActual < 11)
                {
                    calificaciones.Add(numeroActual); 
                }
                else
                {
                    if (!ingreso.Equals("fin"))
                    {
                        Console.WriteLine("Por favor ingrese un número entre 1 y 10");
                    }
                    continue;
                }
                contador++;
            }

        }
    }
}
