using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Clases_Instanciables
{
    public class Universidad
    {
        #region atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion
        #region enumerados
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
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
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }
        public Jornada this[int indice]
        {
            get
            {
                if (indice >= this.jornada.Count || indice < 0)
                    return null;
                else
                    return this.jornada[indice];
            }
            set
            {
                if (indice >= 0 && indice < this.jornada.Count)
                {
                    this.jornada[indice] = value;
                }
            }
        }
        #endregion
        #region constructores
        public Universidad()
        {
            alumnos = new List<Alumno>();
            jornada = new List<Jornada>();
            profesores = new List<Profesor>();
        }
        #endregion

        #region metodos
        public bool Guardar(Universidad uni)
        {

        }
        public Universidad Leer()
        {

        }
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Lista de profesores:\n");
            foreach(Profesor retorno in uni.profesores)
                sb.AppendFormat("{0}\n", retorno.ToString());
            sb.AppendFormat("---------------\n");
            sb.AppendFormat("Lista de jornadas:\n");
            foreach(Jornada retorno in uni.jornada)
                sb.AppendFormat("{0}\n", retorno.ToString());
            sb.AppendFormat("---------------\n");
            sb.AppendFormat("Lista de alumnos:\n");
            foreach (Alumno retorno in uni.alumnos)
                sb.AppendFormat("{0}\n", retorno.ToString());

            return sb.ToString();
        }

        #endregion
        #region sobrecargas
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool rta = false;
            foreach (Alumno aux in g.alumnos)
                if (g.alumnos.Contains(aux))
                    rta = true;
            return rta;
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return (!(g == a));
        }
        public static bool operator ==(Universidad g,Profesor p)
        {
            bool rta = false;
            if (g.profesores.Contains(p))
                rta = true;
            return rta;
        }
        public static bool operator !=(Universidad g, Profesor p)
        {
            return (!(g == p));
        }
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            Profesor retorno = null; ;
            foreach (Profesor aux in g.profesores)
                if (aux == clase)
                    retorno = aux;
            if (retorno == null)
                throw new SinProfesorException();
            return retorno;
        }
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            Profesor retorno = null;
            foreach (Profesor aux in g.profesores)
                if (aux != clase)
                    retorno = aux;
            return retorno;
        }
        public static Universidad operator +(Universidad g, EClases clase)
        {
            List<Alumno> alumnoAux = new List<Alumno>();
            foreach(Profesor aux in g.profesores)
            {
                if (aux == clase)
                {
                    g.jornada.Add(new Jornada(clase, aux));
                    break;
                }
                else
                    throw new SinProfesorException();
            }
            foreach(Alumno aux in g.Alumnos)
            {
                if (aux == clase)
                    alumnoAux.Add(aux);
            }

            return g;
        }
        public static Universidad operator -(Universidad g, EClases clase)
        {

        }
        public static Universidad operator +(Universidad g, Alumno a)
        {
            if (!(g == a))
                g.alumnos.Add(a);
            return g;
        }
        public static Universidad operator -(Universidad g, Alumno a)
        {
            if (g == a)
                g.alumnos.Remove(a);
            return g;
        }
        public static Universidad operator +(Universidad g, Profesor p)
        {
            if (g != p)
                g.profesores.Add(p);
            return g;
        }
        public static Universidad operator -(Universidad g, Profesor p)
        {
            if (g == p)
                g.profesores.Remove(p);
            return g;
        }
        #endregion
    }
}
