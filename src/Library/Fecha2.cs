using System;

namespace Library
{
    public class Fecha2
    {

        public string CambiarFormatoFecha(string fecha)
        {
            string Respuesta = "";
            string[] DiaMesAño = fecha.Split('*');

            if (string.IsNullOrWhiteSpace(fecha))
            {
                return "Formato de fecha no válido";
            }
            else
            {
                if (Int16.Parse(DiaMesAño[2]) > 31 || Int16.Parse(DiaMesAño[2]) < 1)
                {
                    return "Día fuera de rango";
                }
                else if (Int16.Parse(DiaMesAño[1]) > 12 || Int16.Parse(DiaMesAño[1]) < 1)
                {
                    return "Mes fuera de rango";
                }
                else if (Int16.Parse(DiaMesAño[0]) < 0)
                {
                    return "Año fuera de rango";
                }
                else
                {
                    Respuesta += DiaMesAño[2] + "/" + DiaMesAño[1] + "/" + DiaMesAño[0];
                    return Respuesta;
                }
            }
        }

    }
}
