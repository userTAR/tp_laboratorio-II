using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_abstractas
{
    public abstract class Universitario : Persona
    {
        #region atributos
        private int legajo;
        #endregion

        #region constructor
        /// <summary>
        /// Constructor por default 
        /// </summary>
        public Universitario() : base()
        {
            this.legajo = -1;
        }
        /// <summary>
        /// Constructor con legajo, nombre, apellido, dni (STRING), nacionalidad
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Muestra los datos del universitario
        /// </summary>
        /// <returns>Los datos del universitario</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\nLEGAJO NÚMERO:{1}",base.ToString(), this.legajo);

            return sb.ToString();
        }
        protected abstract string ParticiparEnClase();
        #endregion

        #region sobrecargas
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return (!(pg1 == pg2));
        }
        /// <summary>
        /// 2 Universitarios son iguales si tienen el mismo DNI o el mismo legajo
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool rta = false;
            if (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo)
                rta = true;
            return rta;
        }
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Universitario)
                rta = this == (Universitario)obj;
            return rta;
        }
        #endregion

    }
}
