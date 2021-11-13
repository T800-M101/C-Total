using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable2
{
    class CContenedora : IEnumerable
    {
        private int[] _valores = new int[10];

        public CContenedora()
        {
            for (int n = 0; n < 10; n++)
            {
                _valores[n] = n * n;
            }

        }

       // Implementamos el GetEnumerator necesario por IEnumerable
        public IEnumerator GetEnumerator()
        {
            //throw new NotImplementedException();
            return (new ContenedorEnum(_valores));
        }

        class ContenedorEnum : IEnumerator
        {
            public int[] arreglo;
            private int _posicion = -1;

            public ContenedorEnum(int[] arreglo)
            {
                this.arreglo = arreglo; 

            }

            public bool MoveNext()
            {
                _posicion++;
                return _posicion < this.arreglo.Length ? true : false;
                
            }

            public void Reset()
            {
                _posicion = -1;
            }

            public object Current { get { return arreglo[_posicion]; }}
        }
    }
}
