using System;
using System.Collections.Generic;
using System.Linq;
namespace Delegados
{
    class Program
    {
        // Se declara el delegado
        public delegate int BuscaNumeroMayor(List<int> lst);

        // Se declara un método al cual se le delegara
        static int NumeroMayor(List<int> lst)
        {
            return lst.Max(); 
        }
        static void Main(string[] args)
        {

            //Se crea la lista
            List<int> lst = new List<int> { 2, 3, 4, 5, 666, 2, 1 };
            List<int> lst2 = new List<int> { 2, 3, 4, 5, 666, 2, 1 , 999};
            List<int> lst3 = new List<int> { 2, 3, 4, 5, 666, 2, 1 , 1000};
            List<int> lst4 = new List<int> { 2, 3, 4, 2000, 5, 666, 2, 1 , 1000};


            // FORMA 1 instanciando el delegado
            BuscaNumeroMayor miDelegado = new BuscaNumeroMayor(NumeroMayor);
            Console.WriteLine(miDelegado(lst));


            // FORMA 2 de manera directa
            BuscaNumeroMayor miDelegado2 = NumeroMayor;
            Console.WriteLine(miDelegado2(lst2));



            //FORMA 3 En tiempo real con una funcion anónima
            BuscaNumeroMayor miDelegado3 = delegate (List<int> lst)
           {
               return lst.Max();
           };
            Console.WriteLine(miDelegado3(lst3));


            // FORMA 4 con expresión lambda
            BuscaNumeroMayor miDelegado4 = x => x.Max();

            // Se llama al delegado
            Console.WriteLine(miDelegado4(lst4));


            Persona p = new Persona();

            p.Registrar(miDelegado4, lst4);
        }


        public class Persona
        {
            public void Registrar(BuscaNumeroMayor fn, List<int> lst)
            {

                Console.WriteLine("Desde el método registrar");
                Console.WriteLine("Me registro en la base de datos");

                int i = fn(lst);

                Console.WriteLine($"Número de registro: {i}");
            }
        }
    }
    
}
