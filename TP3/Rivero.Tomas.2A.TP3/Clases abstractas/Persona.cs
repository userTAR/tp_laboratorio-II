using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excepciones;

namespace Clases_abstractas
{
    public abstract class Persona
    {
        #region atributos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion

        #region enumerados
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion

        #region propiedades
        /// <summary>
        /// Retorna apellido validado
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set 
            { 
                if(ValidarNombreApellido(value)!=null)
                    this.apellido = value; 
            }
        }
        /// <summary>
        /// Retorna DNI validado
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = this.ValidarDni(this.Nacionalidad,value); }
        }
        /// <summary>
        /// Retorna nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
        /// <summary>
        /// Retorna nombre validado
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set 
            { 
                if(ValidarNombreApellido(value)!=null)
                    this.nombre = value; 
            }
        }
        /// <summary>
        /// Retorna DNI validado
        /// </summary>
        public string StringToDNI
        {
            set { this.dni = this.ValidarDni(this.Nacionalidad, value); }
        }
        #endregion

        #region constructores
        /// <summary>
        /// Constructor por Default
        /// </summary>
        public Persona()
        {
            this.Nombre = default;
            this.Apellido = default;
            this.DNI = 0;
        }
        /// <summary>
        /// Constructor con nombre, apellido y nacionalidad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        /// <summary>
        /// Constructor con nombre, apellido, dni de tipo INT, nacionalidad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre,apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        /// <summary>
        /// Constructor con nombre, apellido, dni de tipo STRING, nacionalidad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Valida que el DNI no tenga más de 9 caracteres y que el número corresponda a la nacionalidad
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>El dato si está correcto, si no, lanza excepción correspondiente</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            string datoString = dato.ToString(); 
            if (datoString.Length >= 9) 
            {
                throw new DniInvalidoException();
            }
            switch (nacionalidad)
            {
                case ENacionalidad.Extranjero:
                    if (dato > 1 && dato < 89999999)
                        throw new NacionalidadInvalidaException("El DNI no condice con la nacionalidad");
                    break;
                case ENacionalidad.Argentino:
                    if (dato > 90000000 && dato < 99999999)
                        throw new NacionalidadInvalidaException("El DNI no condice con la nacionalidad");
                    break;
                default:
                    throw new NacionalidadInvalidaException();
                    
            }
            return dato;
        }
        /// <summary>
        /// Valida que el DNI no contenga letras, convierte el STRING a INT y llama a la función ValidarDni
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>El dato si está correcto, si no, lanza excepción correspondiente</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int datoParseado = 0;
            if(Regex.IsMatch(dato, @"^[\p{L}]+$") == true)
                throw new DniInvalidoException();
            try
            {
                datoParseado = int.Parse(dato);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            datoParseado = ValidarDni(nacionalidad, datoParseado);
            
            return datoParseado;
        }
        /// <summary>
        /// Valida que el dato no sea nulo y que contenga solo letras
        /// </summary>
        /// <param name="dato"></param>
        /// <returns>El dato si está correcto, si no, retorna null</returns>
        private string ValidarNombreApellido(string dato) //excepcion aca
        {
            string ret;
            if (dato != null && Regex.IsMatch(dato, @"^[\p{L}]+$") == true) //no entra nunca. verificar
                ret = dato;
            else
                ret = null;
            return ret;
        }
        #endregion
        
        #region sobrecargas
        /// <summary>
        /// Sobrecarga de ToString() que muestra los atributos de la persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}\nNACIONALIDAD: {2}", this.Apellido, this.Nombre, this.Nacionalidad.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
