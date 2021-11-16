using System;

namespace GenericosHerencia
{
    class Program
    {
        // Las desventajas de usar genéricos mediante herencia es:
        // a) Uso cntinuo de Casting
        // b) Los errores surgen en tiempo de ejecución y no en tiempo de compilación
        static void Main(string[] args)
        {
            AlmacenaObjetos archivos = new AlmacenaObjetos(4);
            //archivos.Agregar("Juan");
            //archivos.Agregar("Memo");
            //archivos.Agregar("Mary");
            //archivos.Agregar("Brandon");

            archivos.Agregar(new Empleado(500));
            archivos.Agregar(new Empleado(2500));
            archivos.Agregar(new Empleado(3500));
            archivos.Agregar(new Empleado(4500));

            //string nombrePersona = (string)archivos.getElemento(2);
            Empleado salarioEmpleado = (Empleado)archivos.getElemento(2);

            Console.WriteLine(salarioEmpleado.getSalario());
        }
    }

    class AlmacenaObjetos
    {
        private Object[] _datosElemento;
        private int _i = 0;
        public AlmacenaObjetos(int z)
        {
            _datosElemento = new Object[z];
        }

        public void Agregar(Object obj)
        {
            _datosElemento[_i] = obj;
            _i++;
        }

        public Object getElemento(int i)
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
