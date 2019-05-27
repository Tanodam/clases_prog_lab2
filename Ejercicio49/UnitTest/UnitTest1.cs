using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Ejercicio_36;

namespace UnitTest
{
    [TestClass]
    public class TestUnitarioEj46
    {
        [TestMethod]
        public void ValidarListaCompetidores()
        {/*Crear un test unitario que valide que la lista de vehículos de la competencia 
            esté instanciada al crear un nuevo objeto.
            */
            //arrange
            Competencia<VehiculoCarrera> competencia;
            //act
            competencia = new Competencia<VehiculoCarrera>(5, 28, TipoCompetencia.F1);
            //assert
            Assert.IsNotNull(competencia);
        }
        /*Realizar un test unitario que controle que la excepción CompetenciaNoDisponible
         * se lance al querer cargar un AutoF1 en una competencia del tipo MotoCross.*/
        [TestMethod]
        public void ValidarLanzaExepcionAUtoF1enCompetenciaTipoMotoCross()
        {
            //arrange
            AutoF1 autito;
            Competencia<VehiculoCarrera> competencia;
            //act
            competencia = new Competencia<VehiculoCarrera>(15, 8, TipoCompetencia.MotoCross);
            autito = new AutoF1(15, "Peugeot");
            try
            {
                if (competencia + autito)
                {
                    /// Todo piola
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                //assert
                Assert.Fail(e.Message);
            }

        }
        /*Realizar otro test que controle que la excepción CompetenciaNoDisponible no se lance al querer cargar un objeto del tipo MotoCross 
         * en una competencia del tipo MotoCross.*/
        [TestMethod]
        public void ValidarNOLanzaExepcionAUtoF1enCompetenciaTipoMotoCross()
        {
            //arrange
            MotoCross motito;
            Competencia<VehiculoCarrera> competencia;
            //act
            competencia = new Competencia<VehiculoCarrera>(15, 8, TipoCompetencia.MotoCross);
            motito = new MotoCross(15, "Jonda");
            try
            {
                if (competencia + motito)
                {
                    //todo piola
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                //assert
                Assert.Fail(e.Message);
            }
        }
        /*Comprobar que al cargar un nuevo vehículo en la competencia esté figure 
         * en la lista. Utilizar el operador + y el ==.*/
        [TestMethod]
        public void ValidarQueVehiucloEsteYaEnLista()
        {
            //arrange
            bool autoCargado= false;
            Competencia<VehiculoCarrera> competencia = new Competencia<VehiculoCarrera>(12, 20, TipoCompetencia.F1);
            AutoF1 autito = new AutoF1(15, "Jonda");
            //act
            autoCargado = competencia + autito;
            //Assert
            Assert.IsTrue(competencia == autito); // Es true porque el vehiculo ya esta agregado
        }

        /*Comprobar que al quitar un vehículo existente en la competencia esté ya no figure en la lista.
         * Utilizar el operador - y el !=.*/
        [TestMethod]
        public void ValidarQueVehiucloYaNoEsteEnLista()
        {
            //arrange
            bool autoCargado = false;
            Competencia<VehiculoCarrera> competencia = new Competencia<VehiculoCarrera>(12, 20, TipoCompetencia.F1);
            AutoF1 autito = new AutoF1(15, "Jonda");
            //act
            autoCargado = competencia + autito;//agrego auto
            autoCargado = competencia - autito;//saco auto
            //Assert
            Assert.IsTrue(competencia != autito);//Es true porque el auto ya fue quitado de la lista en el -
        }
    }
}
