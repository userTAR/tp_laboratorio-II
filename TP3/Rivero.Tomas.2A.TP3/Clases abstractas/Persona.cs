using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            set { this.apellido = value; }
        }
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string StringToDNI
        {
            set { this.dni = Convert.ToInt32(value); }
        }
        #endregion

        #region constructores
        public Persona()
        {
            this.Nombre = "Sin Nombre";
            this.Apellido = "Sin Apellido";
            this.DNI = -1;
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

        }
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {

        }
        private string ValidarNombreApellido(string dato)
        {

        }
        #endregion

        #region sobrecargas
        public override string ToString()
        {
            
        }
        #endregion
    }
}
