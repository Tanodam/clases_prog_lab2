using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class ValidarCentralita
    {
        [TestMethod]
        public void ValidarListaLlamadas()
        {
            // arrange  
            Centralita centralitaActual;
            // act  
            centralitaActual = new Centralita("Dami Phone");
            // assert  
            //Assert.Equals(centralitaActual.Llamadas, null);
            Assert.IsNotNull(centralitaActual.Llamadas);
            Assert.IsInstanceOfType(centralitaActual.Llamadas, typeof(List<Llamada>));

        }

        [TestMethod]
        public void ValidarLlamadasLocales()
        {
            //arrange
            Centralita centralitaActual = new Centralita("Dami Phone");
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l2 = new Local("Bernal", 30, "Rosario", 2.65f);
            //act
            try
            {
                centralitaActual += l1;
                centralitaActual += l2;
                Assert.Fail("No lanza exception");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(CentralitaException));
            }
            // assert  



        }
        [TestMethod]
        public void ValidarLlamadasProvinciales()
        {
            //arrange
            Centralita centralitaActual = new Centralita("Dami Phone");
            Provincial l1 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            Provincial l2 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            //act
            try
            {
                centralitaActual += l1;
                centralitaActual += l2;
                Assert.Fail("No lanza exception");
            }
            catch (AssertFailedException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(CentralitaException));
            }
            // assert  



        }
        [TestMethod]
        public void ValidarLlamadasProvLoc()
        {
            //arrange
            Centralita centralitaActual = new Centralita("Dami Phone");
            Provincial l1 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            Provincial l2 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l4 = new Local("Bernal", 30, "Rosario", 2.65f);
            //act
            try
            {
                centralitaActual += l1;
                centralitaActual += l2;
                centralitaActual += l3;
                centralitaActual += l4;

            }
            catch(CentralitaException e)
            {
                Assert.Fail(e.Message);
            }
            // assert




        }
    }
}
