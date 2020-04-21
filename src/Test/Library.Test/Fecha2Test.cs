using NUnit.Framework;


namespace Library.Test
{
    public class Fecha2Test
    {

        /*Para este cambio de formato, recibo "aaaa*mm*dd" y tomo por válido que me pueden pasar cualquier entero como día, mes y año
        y el método tomará como válido:
        Los días entre 1 y 30 (mes comercial) 
        Los meses entre 1 y 12 y
        Los años mayores o iguales a 0.
        Si se cumple con esto muestra la fecha en formato dd/mm/aaaa y en caso contraro el texto con el error correspondiente
        (lo hice sólo a efectos de poder hacer más tests)*/

        Fecha2 fecha = new Fecha2();
        string fechaAPasar;
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void TestFechaCorrecta()
        {
            fechaAPasar = "2020*04*20";
            string esperado = "20/04/2020";
            
            Assert.AreEqual(esperado,fecha.CambiarFormatoFecha(fechaAPasar));

        }

        [Test]
        public void TestDiaMayorA31()
        {
            fechaAPasar = "2020*04*34";
            string esperado = "Día fuera de rango";
            
            Assert.AreEqual(esperado,fecha.CambiarFormatoFecha(fechaAPasar));

        }

        [Test]
        public void TestDiaMenorA0()
        {
            fechaAPasar = "2020*04*-10";
            string esperado = "Día fuera de rango";
            
            Assert.AreEqual(esperado,fecha.CambiarFormatoFecha(fechaAPasar));

        }

        [Test]
        public void TestMesMayorA12()
        {
            fechaAPasar = "2020*14*22";
            string esperado = "Mes fuera de rango";
            
            Assert.AreEqual(esperado,fecha.CambiarFormatoFecha(fechaAPasar));

        }

        [Test]
        public void TestMesMenorA0()
        {
            fechaAPasar = "2020*-12*8";
            string esperado = "Mes fuera de rango";
            
            Assert.AreEqual(esperado,fecha.CambiarFormatoFecha(fechaAPasar));

        }

        [Test]
        public void TestAñoMenorA0()
        {
            fechaAPasar = "-2020*12*8";
            string esperado = "Año fuera de rango";
            
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

