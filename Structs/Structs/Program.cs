using System;

namespace Structs
{
    class Program
    {
        /*
           a) Los structs solo contienen propiedades de tipo valor
           b) No soportan herencia
           c) Si soportan interfaces
           d) Pueden tener constructores parametrizados
           e) No pueden tener una referencia a null

          Un struct es un tipo de 'valor'. Cuando se crea una estructura, la variable
          a la que se asigna la estructura contiene los datos reales de ella.
          Cuando la estructura se asigna a una nueva variable, se copia. Por lo tanto,
          la nueva variable y la variable original contienen dos copias independientes
          de los mismos datos. Los cambios realizados en una copia no afectan a la otra copia.
         */

        /*
          a) Soportan herencia
          b) Soportan Interfaces
          c) Son de tipo referencia
          d) Puden tener una referencia a null

          Una clase crea objetos por 'referencia'. Cuando se crea un objeto de la clase,
          la variable a la que se le asigna el objeto contiene solo una referencia a esa memoria.
          Cuando la referencia de objeto se asigna a una nueva variable, la nueva variable
          hace referencia al objeto original. Los cambiios realizados en una variable
          se reflejan en la otra variable porue ambas hacen referencia a los mismos datos.
         */

        /*
           a) Los structs y las clases son tipos de datos compuestos, usados para contener una 
           serie de variables que tienen una relación lógica entre sí.
           b) Pueden contener métodos y eventos.}
         */
        struct Juego
        {
            public string nombre;
            public string desarrollador;
            public void Mostrar()
            {
            Console.WriteLine($"El nombre del juego es {nombre}");
            Console.WriteLine($"El desarrolaldor es {desarrollador}");

            }

            public Juego(string nombre, string desarrollador)
            {
                this.nombre = nombre;
                this.desarrollador = desarrollador;
            }
        }
        static void Main(string[] args)
        {
            Juego juego1 = new Juego("Casa Zombie", "Nintendo");
            //juego1.nombre = "Casa Zombie";
            //juego1.desarrollador = "Nintendo";
            juego1.Mostrar();

            Juego juego2 = juego1;
            juego2.nombre = "Mario Bros";
            juego2.desarrollador = "Sony";

            juego2.Mostrar();

        }
    }
}
