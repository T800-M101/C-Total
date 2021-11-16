namespace EventosYDelegados
{
    class Program
    {
        static void Main(string[] args)
        {
            var archivo = new Archivo() { Titulo = "Archivo 1" };
            var asistenteDescarga = new AsistenteDescarga(); // emisor
            var servicioDesempacar = new ServicioDesempacar(); // receptor
            var servicioNotificacion = new ServicioNotificacion(); // receptor

            asistenteDescarga.ArchivoDescargado += servicioDesempacar.EnArchivoDescargado;
            asistenteDescarga.ArchivoDescargado += servicioNotificacion.EnArchivoDescargado;

            asistenteDescarga.Descarga(archivo);
            
        }
    }
}
