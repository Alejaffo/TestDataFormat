using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string fechaACambiar ="20/04/2020";
            Fecha f1 = new Fecha();
            System.Console.WriteLine("Se le pasa dd/mm/aaaa y devuelve aaaa-mm-dd");
            Console.WriteLine($"{fechaACambiar} se convierte a: {f1.CambiarFormatoFecha(fechaACambiar)}");

            System.Console.WriteLine();

            fechaACambiar = "2020-04-20";
            Fecha2 f2 = new Fecha2();
            System.Console.WriteLine("Se le pasa aaaa-mm-dd y devuelve dd/mm/aaaa");
            Console.WriteLine($"{fechaACambiar} se convierte a: {f2.CambiarFormatoFecha(fechaACambiar)}");

        }

    }
}
