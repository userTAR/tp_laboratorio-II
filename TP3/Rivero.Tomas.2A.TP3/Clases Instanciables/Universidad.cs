using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
        #endregion

        #region metodos
        public bool Guardar(Universidad uni)
        {

        }
        public Universidad Leer()
        {

        }
        private string MostrarDatos(Universidad uni)
        {

        }

        #endregion
        #region sobrecargas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            return sb.ToString();
        }
        public static bool operator ==(Universidad g, Alumno a)
        {

        }
        public static bool operator !=(Universidad g, Alumno a)
        {

        }
        public static bool operator ==(Universidad g,Profesor p)
        {

        }
        public static bool operator !=(Universidad g, Profesor p)
        {

        }
        public static bool operator ==(Universidad g, EClases clase)
        {

        }
        public static bool operator !=(Universidad g, EClases clase)
        {

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
