using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases__Basico
{
    class Caja
    {
        // Las variables se escriben con minúsculas y se usan cuando se require que el valor no cambie.
        //private double _largo;
        //private double _alto;
        //private double _ancho;

        private double _volumen;

        // Las propiedades se escriben con mayúsculas 
        // Propiedades auto-implementadas
        public double Largo { get; set; }
        public double Alto { get; set; }
        public double Ancho { get; set; }

        public Caja(double alto, double largo, double ancho)
        {
            Largo = largo;
            Alto = alto;
            Ancho = ancho;
        }

        public void MuestraInfo()
        {
            Console.WriteLine($"El largo es {Largo}. El alto es {Alto}. El ancho es {Ancho}. Por lo tanto el volumen es {Volumen}");
        }

        //public double Largo
        //{
        //    get { return _largo; }
        //    set { _largo = value; }
        //}

        //public double Alto
        //{
        //    get { return _alto; }
        //    set { _alto = value; }
        //}

        //public double Ancho
        //{
        //    get { return _ancho; }
        //    set
        //    {
        //       if(value < 0) value = -value; //throw new Exception("El tamaño debe ser positivo.");
        //         _alto = ValueTask;  
        //    }
        //}

        public double Volumen
        {
            set { _volumen = value; }
            get { return Alto * Ancho * Largo; }
        }

        public double SuperficieFrontal 
        {
            get { return Alto * Largo; }       
        }


       
    }
}
