using System;
using System.Collections.Generic;

namespace TomaDeDecisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ingresa una temperatura");

            //string temperatura = Console.ReadLine();

            //TryParse parsear = new TryParse();

            //List<Object> result = parsear.ParseString(temperatura);

            //Type dato1 = result[0].GetType();

            //Type dato2 = typeof(string);

            //Type dato3 = typeof(double);

            //double temp;

            //if(dato1 == dato2)
            //{
            //    Console.WriteLine(result[0]);
            //}

            //if(dato1 == dato3)
            //{
            //    temp = (double)result[0];

            //    if (temp < 20)
            //    {
            //        Console.WriteLine("Abrigate");

            //    }

            //    else if (temp == 20)
            //    {
            //        Console.WriteLine("Vistete cómodo");

            //    }

            //    else
            //    {
            //        Console.WriteLine("Usa ropa ligera");

            //    }
            //}


            //WelcomeAdmin bienvenda = new WelcomeAdmin();

            //Console.WriteLine("¿Estas registrado?");
            //string estaRegistrado = Console.ReadLine();


            //Console.WriteLine("¿Eres Admin?");
            //string esAdmin = Console.ReadLine();

            //Console.WriteLine("Escribe tu nombre de usuario");
            //string usuario = Console.ReadLine();
            //bienvenda.ValidarUsuario(estaRegistrado, esAdmin, usuario);

            //Registro registrarse = new Registro();

            //Console.WriteLine("Bienvenido al sistema de registro");
            //Console.WriteLine("Registra un usuario");
            //string usuario = Console.ReadLine();
            //Console.WriteLine("Registra una contraseña");
            //string password = Console.ReadLine();


            //registrarse.Registarse(usuario,password);
            //Console.WriteLine("=================================");
            //Console.WriteLine("=================================");

            //Console.WriteLine("Bienvenido al sistema de logueo");
            //Console.WriteLine("Ingresa tu usuario");
            //string miUusuario = Console.ReadLine();
            //Console.WriteLine("Ingresa tu contraseña");
            //string miPassword = Console.ReadLine();


            //registrarse.loguarse(miUusuario,miPassword);

            //Switch jugar = new Switch();
            //Console.WriteLine("Ingresa tu juagada");
            //string jugada = Console.ReadLine();

            //jugar.PiedraPapelTijera(jugada);


            //SuperJuego juego = new SuperJuego();

            //Console.WriteLine("Ingresa tu nombre");
            //string jugador = Console.ReadLine();

            //Console.WriteLine("Ingresa tus puntos logrados");
            //int puntos = Int32.Parse(Console.ReadLine());

            //juego.Intentalo(puntos,jugador);

            Ternario evaluaTemperatura = new Ternario();
            string mensaje = evaluaTemperatura.VerificarTemperatura();
            Console.WriteLine(mensaje);
        }
    }
}
