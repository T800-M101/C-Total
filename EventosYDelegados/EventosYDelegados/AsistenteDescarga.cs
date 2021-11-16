using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventosYDelegados
{
    public class ArchivoEventArgs : EventArgs
    {
        public Archivo Archivo { get; set; }
    }
    public class AsistenteDescarga
    {
        // Paso 1 - Crear el delegado
        // public delegate void GestorEventoArchivoDescargado(object fuente, ArchivoEventArgs args);

        // Paso 2 - Crear el evento basado en el delegado
        // public event GestorEventoArchivoDescargado ArchivoDescargado;
        public event EventHandler<ArchivoEventArgs> ArchivoDescargado;
        // Paso 3 - Preparar el evento
        protected virtual void EnArchivoDescargado(Archivo archivo)
        {
            if(ArchivoDescargado != null)
            {
                // this es el objeto AsistenteDescarga (la clase entera)
                ArchivoDescargado(this, new ArchivoEventArgs(){ Archivo = archivo});
            }
        }

        public void Descarga(Archivo archivo)
        {
            Console.WriteLine("Descargando archivo...");
            Thread.Sleep(4000);

            // Paso 3.1 - Iniciar el evento
            EnArchivoDescargado(archivo);

        }
    }
}
