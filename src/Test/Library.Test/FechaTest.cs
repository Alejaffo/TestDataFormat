using NUnit.Framework;


namespace Library.Test
{
    public class FechaTest
    {

        /* Para este cambio de formato sólo chequeo con la fecha correcta y que no me pases vacío o string de espacios
        formato correcto:
        dd/mm/aaaa y retorna una fecha del tipo: aaaa-mm-dd*/

        Fecha fecha = new Fecha();
        string fechaAPasar;

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void TestFechaCorrecta()
        {
            fechaAPasar = "20/04/2020";
            string esperado = "2020-04-20";
            
            Assert.AreEqual(esperado,fecha.CambiarFormatoFecha(fechaAPasar));

        }

        [Test]
        public void TestFechaVacia()
        {
            fechaAPasar = "";
            string esperado = "Formato de fecha no válido";
            
            Assert.AreEqual(esperado,fecha.CambiarFormatoFecha(fechaAPasar));

        }

        [Test]
        public void TestFechaConEspacios()
        {
            fechaAPasar = "       ";
            string esperado = "Formato de fecha no válido";
            
            Assert.AreEqual(esperado,fecha.CambiarFormatoFecha(fechaAPasar));

        }
    }
}

