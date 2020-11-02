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
        private Jornada()
        {
            alumnos = new List<Alumno>();
        }
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        #endregion

        #region metodos
        public static bool Guardar(Jornada jornada)
        {
            bool retorno = false;

            Texto jornadaXml = new Texto();
            retorno = jornadaXml.Guardar("jornadaXml.xml", jornada.ToString());
            if (!retorno)
                throw new ArchivosException();
            return retorno;
        }
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
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
                j.alumnos.Add(a);
            return j;
        }
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
