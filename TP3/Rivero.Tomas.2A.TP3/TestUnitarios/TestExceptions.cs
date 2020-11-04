using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Instanciables;
using Excepciones;
using Archivos;

namespace TestUnitarios
{
    [TestClass]
    public class TestExceptions
    {
        [TestMethod]
        public void TestAlumnoRepetidoException()
        {
            //arrange
            bool check = false;
            Universidad uni = new Universidad();
            Alumno a2 = new Alumno(2, "Juana", "Martinez", "12234458",
               Clases_abstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
               Alumno.EEstadoCuenta.Deudor);

            Alumno a3 = new Alumno(2, "José", "Gutierrez", "12234456",
               Clases_abstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
               Alumno.EEstadoCuenta.Becado);

            //act
            try
            {
                uni += a2;
                uni += a3;
            }
            catch (AlumnoRepetidoException e)
            {
                check = true;
            }
            //assert
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void TestAlumnoRepetidoException2()
        {
            //arrange
            bool check = false;
            Universidad uni = new Universidad();
            Alumno a2 = new Alumno(2, "Juana", "Martinez", "12234458",
               Clases_abstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
               Alumno.EEstadoCuenta.Deudor);

            Alumno a3 = new Alumno(3, "José", "Gutierrez", "12234458",
               Clases_abstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
               Alumno.EEstadoCuenta.Becado);
            //act
            try
            {
                uni += a2;
                uni += a3;
            }
            catch (AlumnoRepetidoException e)
            {
                check = true;
            }
            //assert
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void TestDniInvalidoException() //DniInvalidException es para errores de FORMATO
        {
            //arrange
            bool check = false;
            //act
            try
            {
                Alumno a2 = new Alumno(2, "Juana", "Martinez", "AAAAA",
                   Clases_abstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
                   Alumno.EEstadoCuenta.Deudor);
            }
            catch (DniInvalidoException e)
            {
                check = true;
            }
            //assert
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void TestDniInvalidoException2()
        {
            //arrange
            bool check = false;
            //act
            try
            {
                Alumno a2 = new Alumno(2, "Juana", "Martinez", "100000000",
                   Clases_abstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
                   Alumno.EEstadoCuenta.Deudor);
            }
            catch (DniInvalidoException e)
            {
                check = true;
            }
            //assert
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void TestNacionalidadInvalidaException() //TestNacionalidadInvalidaException es para cuando el dni no coincide con la nacionalidad
        {
            //arrange
            bool check = false;
            Universidad uni = new Universidad();
            //act
            try
            {
                Alumno a2 = new Alumno(2, "Juana", "Martinez", "90000100",
               Clases_abstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio,
               Alumno.EEstadoCuenta.Deudor);
            }
            catch (NacionalidadInvalidaException e)
            {
                check = true;
            }
            //assert
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void TestNacionalidadInvalidaException2() //TestNacionalidadInvalidaException es para cuando el dni no coincide con la nacionalidad
        {
            //arrange
            bool check = false;
            Universidad uni = new Universidad();
            //act
            try
            {
                Alumno a2 = new Alumno(2, "Juana", "Martinez", "50000",
               Clases_abstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
               Alumno.EEstadoCuenta.Deudor);
            }
            catch (NacionalidadInvalidaException e)
            {
                check = true;
            }
            //assert
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void TestSinProfesorException()
        {
            //arrange
            bool check = false;
            Universidad uni = new Universidad();
            //act
            try
            {
                Profesor i1 = new Profesor(1, "Juan", "Lopez", "12224458",
            Clases_abstractas.Persona.ENacionalidad.Argentino);
                uni += i1;
                uni += Universidad.EClases.SPD;
            }
            catch (SinProfesorException e)
            {
                check = true;
            }
            //assert
            Assert.IsTrue(check);
        }
        [TestMethod]
        public void TestArchivosException()
        {
            //arrange
            bool check = false;
            //act
            try
            {
                Xml<int> xml = new Xml<int>();
                xml.Guardar(@"C:\Tomate", 4);
            }
            catch (ArchivosException e)
            {
                check = true;
            }

            //assert
            Assert.IsTrue(check);
        }
        
    }
}
