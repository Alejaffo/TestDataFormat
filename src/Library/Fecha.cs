using System;

namespace Library
{
    public class Fecha
    {

        /* Para este cambio de formato tomo como precondición que la fecha se pasa en el formato correcto:
        dd/mm/aaaa y retorna una fecha del tipo: aaaa-mm-dd*/
        public string CambiarFormatoFecha(string fecha)
        {
            if (string.IsNullOrWhiteSpace(fecha))
            {
                return "Formato de fecha no válido";
            }
            else
            {
                string Respuesta = "";
                string[] DiaMesAño = fecha.Split('/');
                Respuesta += DiaMesAño[2] + "-" + DiaMesAño[1] + "-" + DiaMesAño[0];
                return Respuesta;
            }
            

        }

    }
}
