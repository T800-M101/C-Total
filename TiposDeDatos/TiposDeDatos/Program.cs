using System;

namespace TiposDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            // DATOS PRIMITIVOS

            // sbyte => números entre -128 y 127 (sbyte x = 120)
            // short => números entre -32767 y 32767  (short x = 30000)
            // int =>   números entre -2,147,483,648 y 2,147,483,647  (int x = 2000000000)
            // long =>  números entre -9,223,327,036,854,775,808 y 9,223,327,036,854,775,807  (long x = 9000000000000000000)

            // float => decimales en un rango de  1.5x 10 ^-45 hasta 3.4x 10 ^38
            // precisión de 7 dígitos  (float x = 99.99f) se debe colocar la f al final del número
            // Se usa generalmente para bibliotecas gráficas (alta demanda de poder de procesamiento)


            // double => similar a float pero una precisión de 15 dígitos (double x = 1.5)
            // Se usa en general para valores del mundo real (salvo para cálculos de dinero)

            // decimal => similar a double pero con una precisión de 28 dígitos
            // Se usa con más frecuencia en aplicaciones financieras (alto nivel de precisión)

            // bool => verdader y falso (bool interruptor = false)

            // char => sólo permite un caracter leteral o unicode (char letraUnica = 'A') se usa con comillas simples

            // string => permite múltiples letras y unicode (string nombreUsuario = "Jason1995") se usan comillas dobles

            //string mensaje = "Mi nombre es Guillermo";
            //string mensajeMayusculas = mensaje.ToUpper();
            //Console.WriteLine(mensajeMayusculas);

            // METODOS CONSOLE

            // Console.Write() => Imprime en pantalla y mantiene el curso en la misma linea

            // Console.WriteLine() => Imprime en pantalla y lleva el curso a la sigueinte linea

            // Console.Read() => Toma un input de tipo string y devuelve el valor ASCII de ese input
            // int valorAscii = Console.Read();
            // Console.WriteLine($"El valor ASCII es {valorAscii} ");

            // Console.ReadLine() => Toma un input de tipo string o integer y lo devuelve como valor de salida
            // Console.ReadKey() => Toma un input de tipo string y devuele la información de la tecla

            // CAMBIAR COLORES A LA CONSOLA
            // ==== cambia el color de las letras ====
            //Console.ForegroundColor = ConsoleColor.Green; 
            //Console.WriteLine("Hola Mundo");

            // ==== cambia el color de fondo====
            //Console.BackgroundColor = ConsoleColor.Green; 
            //Console.Clear();
            //Console.WriteLine("Hola Mundo");



            //CONVERSIONES EXPLICITAS (casting)
            //double miDouble = 13.37;
            //int miInt;
            //miInt = (int)miDouble;
            //Console.WriteLine(miInt);


            //CONVERSIONES IMPLICITA (no es casting)
            //int num = 123456;
            //long numg = num;

            //CONVERSION DE TIPO
            //string miString = miDouble.ToString();

            //bool elSolBrilla = true;
            //string miBoolString = elSolBrilla.ToString();
            //Console.WriteLine(miBoolString);

            //string miString = "15";
            //string miSegundoString = "10";

            //string resultado = miString + miSegundoString;
            //Console.WriteLine(resultado);

            //int num1 = Int32.Parse(miString);
            //int num2 = Int32.Parse(miSegundoString);
            //int resultado2 = num1 + num2;
            //Console.WriteLine(resultado2);

            //METODO SUBSTRING Y METODO TRIM

            //string nombre = "Guillermo";
            //string apellido = "Moran";
            //string nombreCompleto = String.Concat(" ", nombre, " ", apellido, " ");
            //Console.WriteLine(nombre.Substring(2));
            //Console.WriteLine(nombreCompleto.Trim());
            //Console.WriteLine(nombreCompleto.Trim().IndexOf("le"));
            //Console.WriteLine(String.IsNullOrWhiteSpace(nombre));
            //Console.WriteLine(String.Format("Mi nombre es {1}", nombre, apellido));


            //METODO String.Format => Inserta un string dentro de otro string
            //string nombre;
            //Console.WriteLine("Por favor, ingresa tu nombre y presiona Enter");
            //nombre = Console.ReadLine();
            //string miNombreMayusculas = String.Format("Mi nombre en mayusculas es {0}",nombre.ToUpper());
            //string miNombreMinusculas = String.Format("Mi nombre en minusculas es {0}",nombre.ToLower());
            //string miNombreTrimeado = String.Format("Mi nombre trimeado es {0}",nombre.Trim());
            //string miNombreSubString = String.Format("Mi nombre substring es {0}",nombre.Trim().Substring(3,2));
            //Console.WriteLine(miNombreMayusculas);
            //Console.WriteLine(miNombreMinusculas);
            //Console.WriteLine(miNombreTrimeado);
            //Console.WriteLine(miNombreSubString);

            //Console.WriteLine("Ingrese un texto aqui:");
            //string texto = Console.ReadLine();
            //Console.WriteLine("Ingrese la letra que desea buscar:");
            //string letra = Console.ReadLine();
            //int indiceDeLetra = texto.IndexOf(letra);
            //Console.WriteLine("La letra que buscas esta en el indice: {0}", indiceDeLetra);


            //Console.WriteLine("Escribe tu nombre");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Escribe tu apellido");
            //string apellido = Console.ReadLine();
            //string nombreCompleto = String.Concat(nombre, " ", apellido);
            //Console.WriteLine(nombreCompleto);


            //byte miByte = 25;
            //Console.WriteLine(miByte);
            //sbyte miSbyte = 15;
            //Console.WriteLine(miSbyte);
            //int miInt = 12318925;
            //Console.WriteLine(miInt);
            //uint miUint = 123091;
            //Console.WriteLine(miUint);
            //short miShort = -32768;
            //Console.WriteLine(miShort);
            //ushort miUshort = 65535;
            //Console.WriteLine(miUshort);
            //float miFloat = -31.1289f;
            //Console.WriteLine(miFloat);
            //double miDouble = -12.1231250;
            //Console.WriteLine(miDouble);
            //char miChar = 'A';
            //Console.WriteLine(miChar);
            //bool miBool = true;
            //Console.WriteLine(miBool);
            //string miTexto = "Yo controlo el texto";
            //Console.WriteLine(miTexto);
            //string number = "50";

            //int numeroParseado = Int32.Parse(number);
            //Console.WriteLine(numeroParseado);



            /*Dentro de las conversiones tenemos varios tipos:
             1. Conversion explicita o CASTING que convierte un numero de un tipo en otro => int miInt = (int)miDouble,   miDouble = (double)miInt
             2. Conversiones implicitas que simplemente transforman un numero más pequeño en uno más grande porque esta dentro de su rango => miLong = miInt
             3. Conversiones de tipo que convierten un numero a string => string miInt = miInt.ToString()
             4. Parsing que convierte un string a dato numérico
            */
        }
    }
}
