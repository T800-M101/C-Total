using System;

namespace ArraysComoParametros
{
    class Program
    {
        static void Main(string[] args)
        {

            //double[] arrayDePuntajes = new double[] { 7.8, 9,4,10,9.8};

            //double result = ObtenerPromedio(arrayDePuntajes);
            //Console.WriteLine("El promedio es: {0}", result);


            double[] saldosClientes = new double[] { 200, 150, 400,800};
            IncrementarSaldo(saldosClientes, 200);

          

        }



        //static double ObtenerPromedio(double [] arrayDePuntajes)
        //{
        //    int cantidad = arrayDePuntajes.Length;
        //    double promedio;
        //    double suma = 0;

        //    for (int i = 0; i < cantidad; i++)
        //    {
        //        suma += arrayDePuntajes[i];
        //    }

        //    return promedio = suma / cantidad;

        //}

        static void IncrementarSaldo(double[] saldosClientes, double credito)
        {
            for (int i = 0; i < saldosClientes.Length; i++)
            {
                saldosClientes[i] = saldosClientes[i] + credito;
            }

            foreach (double saldo in saldosClientes)
            {
              Console.WriteLine("Los nuevos saldos son: {0}", saldo);
            }
        }
    }
}
