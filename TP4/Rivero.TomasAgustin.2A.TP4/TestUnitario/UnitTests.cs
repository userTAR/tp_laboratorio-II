using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using Excepciones;

namespace TestUnitario
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        //Chequea que el constructor de "Deposito" instancie la lista 
        public void TestAgregarADeposito()
        {
            Deposito<Helicoptero> depHeli = new Deposito<Helicoptero>();
            Helicoptero helicoptero = new Helicoptero("Robinson", "R60", 80, 60000, 1, 3, 29000);
            depHeli += helicoptero;

            Assert.IsNotNull(depHeli.Lista);
        }
        [TestMethod]
        //Chequea que se lance la excepcion "TechoOpException"
        public void TestExcepcionTechoOperativo()
        {
            bool check = false;
            try
            {
                Deposito<Helicoptero> depHeli = new Deposito<Helicoptero>();
                Helicoptero helicoptero = new Helicoptero("Robinson", "R60", 80, 60000, 1, 3,58000);
                depHeli += helicoptero;
            }
            catch(TechoOpException e)
            {
                check = true;
            }
            Assert.IsTrue(check);
        }
        [TestMethod]
        //Chequea que se lance la excepcion "TestVelocidadExcepcion"
        public void TestVelocidadExcepcion()
        {

            bool check = false;
            try
            {
                Helicoptero helicoptero = new Helicoptero("Robinson", "R60",0, 60000, 1, 3, 58000);
            }
            catch (VelocidadException e)
            {
                check = true;
            }
            Assert.IsTrue(check);
        }
    }
}
