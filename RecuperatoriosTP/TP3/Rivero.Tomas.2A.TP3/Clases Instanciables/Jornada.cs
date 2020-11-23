using Archivos;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public class Jornada
    {
        #region atributos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        #endregion

        #region constructores
        /// <summary>
        /// Constructor privado que instancia la lista
        /// </summary>
        private Jornada()
        {
            alumnos = new List<Alumno>();
        }
        /// <summary>
        /// Constructor con clase y el profesor que la da
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Guarda la jornada en un archivo de texto
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns>True si está correcto, si no, lanza excepción correspondiente</returns>
        public static bool Guardar(Jornada jornada)
        {
            bool retorno = false;

            Texto jornadaXml = new Texto();
            retorno = jornadaXml.Guardar("jornadaXml.xml", jornada.ToString());
            if (!retorno)
                throw new ArchivosException();
            return retorno;
        }
        /// <summary>
        /// Lee una jornada de un archivo de texto
        /// </summary>
        /// <returns>True si está correcto, si no, lanza excepción correspondiente</returns>
        public string Leer()
        {
            bool retorno;
            string datos;

            Texto jornadaAux = new Texto();
            retorno = jornadaAux.Leer("jornadaXml.xml", out datos);
            if (retorno)
                return datos;
            else
                throw new ArchivosException();
        }
        #endregion

        #region sobrecargas
        /// <summary>
        /// Jornada es igual a Alumno si el alumno pertenece a la jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>True si lo contiene, si no, False</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;
            if (j.alumnos.Contains(a))
                retorno = true;
            return retorno;
        }
        public static bool operator !=(Jornada j, Alumno a)
        {
            return (!(j == a));
        }
        /// <summary>
        /// Agrega un alumno a una jornada, si este no está previamente en la jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>La jornada</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
                j.alumnos.Add(a);
            return j;
        }
        /// <summary>
        /// Concatena todos los datos de la jornada
        /// </summary>
        /// <returns>Los datos de la jornada</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASE DE {0} POR {1}\n", this.Clase, this.Instructor.ToString());
            sb.AppendFormat("Alumnos de la clase:\n");
            foreach (Alumno aux in this.alumnos)
                sb.AppendFormat("{0}\n", aux.ToString());
            return sb.ToString();
        }
        #endregion
    }
}
