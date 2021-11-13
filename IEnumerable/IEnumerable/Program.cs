using System;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             public interface IEnumerable
             {
                 IEnumerator GetEnumerator();  
             }

            public interface IEnumerator
             {
                 bool MoveNext();
                 object Current { get;}
                 void Reset();
             }

             */

            // Foreach no es un ciclo es un patrón de diseño iterador "Patrón iterador"
            // Cuando queremos recorrer una clase con Foreach debemos implementar a clase IEnumerable

            // Creamos la tienda
            CTiendaAutos tienda = new CTiendaAutos();

            // Recorremos casa uno de los elementos de la estructrura que expone

            foreach (CAuto miAuto in tienda)
            {
                miAuto.CalcularTenencia(0.05);
                miAuto.MostrarInformacion();
            }
            
        }
    }
}
