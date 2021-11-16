using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosYDelegados
{
    public class ServicioNotificacion
    {
        public void EnArchivoDescargado(object fuente, ArchivoEventArgs e)
        {
            Console.WriteLine($"Informamos que el archivo:'{e.Archivo.Titulo}' se ha terminado de descargar.");
        }
    }
}
