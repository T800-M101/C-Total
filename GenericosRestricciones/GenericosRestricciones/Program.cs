using System;

namespace GenericosRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenaEmpleados<Secretaria> empleados = new AlmacenaEmpleados<Secretaria>(3);
            empleados.Agregar(new Secretaria(4500));
            empleados.Agregar(new Secretaria(1500));
            empleados.Agregar(new Secretaria(2500));

        }
    }

    class AlmacenaEmpleados<T> where T : IParaEmpleados
    {
        private int _i = 0;
        private T[] _datosEmpleado;

        public AlmacenaEmpleados(int z)
        {
            _datosEmpleado = new T[z];
        }

        public void Agregar(T obj)
        {
            _datosEmpleado[_i] = obj;
            _i++;
        }

        public T GetEmpleado(int i)
        {
            return _datosEmpleado[i];
        }
    }

    class Director:IParaEmpleados
    {
        private double _salario;

        public Director(double salario)
        {
            _salario = salario;
        }
        public double getSalario()
        {
            return _salario;
        }
    }

    class Secretaria:IParaEmpleados
    {
        private double _salario;

        public Secretaria(double salario)
        {
            _salario = salario;
        }
        public double getSalario()
        {
            return _salario;
        }

    }

    class Electricista:IParaEmpleados
    {

        private double _salario;

        public Electricista(double salario)
        {
            _salario = salario;
        }
        public double getSalario()
        {
            return _salario;
        }

    }

    class Estudiante
    {
        private double _edad;
        public Estudiante(double edad)
        {
            _edad = edad;
        }

        public double Edad()
        {
            return Edad();
        }
    }
    interface IParaEmpleados
    {
        double getSalario();
    }
}
