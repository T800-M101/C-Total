using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenaObjetos<String> archivos = new AlmacenaObjetos<String>(4);
            archivos.Agregar("Juan");
            archivos.Agregar("Memo");
            archivos.Agregar("Mary");
            archivos.Agregar("Brandon");

            //archivos.Agregar(new Empleado(500));
            //archivos.Agregar(new Empleado(2500));
            //archivos.Agregar(new Empleado(3500));
            //archivos.Agregar(new Empleado(4500));

            string nombrePersona = archivos.getElemento(2);
            //Empleado salarioEmpleado = archivos.getElemento(2);

            Console.WriteLine(nombrePersona);
        }
    }

    class AlmacenaObjetos<T>
    {
        private T[] _datosElemento;
        private int _i = 0;
        public AlmacenaObjetos(int z)
        {
            _datosElemento = new T[z];
        }

        public void Agregar( T obj)
        {
            _datosElemento[_i] = obj;
            _i++;
        }

        public T getElemento(int i)
        {
            return _datosElemento[i];
        }


    }

    class Empleado
    {
        private double _salario;
        public Empleado(double salario)
        {
            _salario = salario;
        }

        public double getSalario()
        {
            return _salario;
        }
    }
}
