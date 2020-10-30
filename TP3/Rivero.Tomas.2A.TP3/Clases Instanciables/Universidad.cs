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
            foreach (Profesor aux in g.profesores)
                if (g.profesores.Contains(aux))
                    rta = true;
            return rta;
        }
        public static bool operator !=(Universidad g, Profesor p)
        {
            return (!(g == p));
        }
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            bool rta = false;
            foreach (Profesor retorno in g.profesores)
                if (retorno == clase)
                    rta = true;
            if (!(rta))
                throw new SinProfesorException();
            return rta;
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

        }
        public static Universidad operator -(Universidad g, EClases clase)
        {

        }
        public static Universidad operator +(Universidad g, Alumno a)
        {

        }
        public static Universidad operator -(Universidad g, Alumno a)
        {

        }
        public static Universidad operator +(Universidad g, Profesor p)
        {

        }
        public static Universidad operator -(Universidad g, Profesor p)
        {

        }
        #endregion
    }
}
