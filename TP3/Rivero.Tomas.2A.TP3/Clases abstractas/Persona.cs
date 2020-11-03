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
        public string Apellido
        {
            get { return this.apellido; }
            set 
            { 
                if(ValidarNombreApellido(value)!=null)
                    this.apellido = value; 
            }
        }
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = this.ValidarDni(this.Nacionalidad,value); }
        }
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set 
            { 
                if(ValidarNombreApellido(value)!=null)
                    this.nombre = value; 
            }
        }
        public string StringToDNI
        {
            set { this.dni = this.ValidarDni(this.Nacionalidad, Convert.ToInt32(value)); }
        }
        #endregion

        #region constructores
        public Persona()
        {
            this.Nombre = default;
            this.Apellido = default;
            this.DNI = default;
        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre,apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region metodos
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (/*Regex.IsMatch(dato.ToString(), @"^[\p{L}]+$") == true ||*/ (dato.ToString().Length > 0 && dato.ToString().Length < 9)) // rompe acá

            {
                throw new DniInvalidoException();
            }
            switch (nacionalidad)
            {
                case ENacionalidad.Extranjero:
                    if (dato < 1 && dato > 89999999)
                        throw new NacionalidadInvalidaException("El DNI no condice con la nacionalidad");
                    break;
                case ENacionalidad.Argentino:
                    if (dato < 90000000 && dato > 99999999)
                        throw new NacionalidadInvalidaException("El DNI no condice con la nacionalidad");
                    break;
                default:
                    throw new NacionalidadInvalidaException();
                    
            }
            return dato;
        }
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int datoParseado = 0;
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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}\nNACIONALIDAD: {2}", this.Apellido, this.Nombre, this.Nacionalidad.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
