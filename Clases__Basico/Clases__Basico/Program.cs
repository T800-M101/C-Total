using System;

namespace Clases__Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea objeto desde la clase
            // Es una instancia de Humano
            // También se puede considerar un tipo de dato
            //Humano juan = new Humano("Juan", "Perez", "negro", 34);
            //Humano memo = new Humano("Memo", "Morán", 49);
            //Humano brandon = new Humano("Brandón","Morán", "verde");
            //Humano mary = new Humano("Mary", "Morán");
            //juan.Presentarme();
            //memo.Presentarme();
            //brandon.Presentarme();
            //mary.Presentarme();



            //Caja caja = new Caja(25.5,10,13.4);

            //caja.MuestraInfo();

            //Console.WriteLine($"La superficie frontal es de {caja.SuperficieFrontal}");

            Miembros nuevoMiembro = new Miembros();
            nuevoMiembro.Amigo(true);

            
        }
    }
}
