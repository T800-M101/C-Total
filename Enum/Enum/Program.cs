using System;

namespace Enum
{
    /*
      Es un grupo de contstantes que deben ser creadas a nivel del namespace
     }*/

    enum Dia { Lu, Ma, Mi, Ju, Vi, Sa, Do};

    enum Mes { Ene = 1, Feb, Mar, Abr, May, Jun, Jul, Ago,Sep, Oct, Nom, Dic};
    class Program
    {
        static void Main(string[] args)
        {

            Dia viernes = Dia.Vi;
            Dia sabado = Dia.Sa;
            Console.WriteLine($"Mis dias favoritos son {viernes} y {sabado} ");
            Console.WriteLine($"El indice de {Dia.Lu} es {(int)Dia.Lu}");
            Console.WriteLine($"El indice de {Mes.Feb} es {(int)Mes.Feb}");
        }
    }
}
