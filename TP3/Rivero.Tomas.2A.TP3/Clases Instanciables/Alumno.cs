using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_abstractas;


namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        #region atributos
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region enumerados
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        #endregion

        #region constructores
        /// <summary>
        /// Constructor por Default
        /// </summary>
        public Alumno()
        {
            this.claseQueToma = Universidad.EClases.Laboratorio;
            this.estadoCuenta = EEstadoCuenta.AlDia;
        }
        /// <summary>
        /// Constructor con id, nombre, apellido, DNI (STRING), nacionalidad y clases que toma
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        /// <summary>
        /// Constructor con id, nombre, apellido, DNI (STRING), nacionalidad, clases que toma y estado de cuenta
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Concatena los datos del alumno
        /// </summary>
        /// <returns>Los datos del alumno</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\nEstado de cuenta:{1}\n{2}\n",base.MostrarDatos(),this.estadoCuenta,ParticiparEnClase());

            return sb.ToString();
        }
        /// <summary>
        /// Concatena las clases que toma el alumno
        /// </summary>
        /// <returns>Los datos del alumno</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("TOMA CLASE DE: {0}", this.claseQueToma);

            return sb.ToString();
        }
        #endregion

        #region sobrecargas
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return (a.claseQueToma != clase);
        }
        /// <summary>
        /// Un alumno es igual a una clase si este la toma y su estado de cuenta no es de tipo DEUDOR
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor);
        }
        /// <summary>
        /// Concatena todos los datos del alumno llamando a MostrarDatos
        /// </summary>
        /// <returns>Los datos del alumno</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.MostrarDatos());

            return sb.ToString();
        }
        #endregion
    }
}
