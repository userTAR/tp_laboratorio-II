using Clases_abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public class Profesor : Universitario
    {
        #region atributos
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region Constructores
        static Profesor()
        {
            Profesor.random = new Random();
        }
        public Profesor()
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        public Profesor(int id,string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion

        #region metodos
        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n{1}\n", base.MostrarDatos(),ParticiparEnClase());

            return sb.ToString();
        }
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASES DEL DÍA:\n");
            foreach(Universidad.EClases retorno in this.clasesDelDia)
            {
                sb.AppendFormat("{0}\n", retorno.ToString());
            }

            return sb.ToString();
        }
        #endregion

        #region sobrecargas
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool rta = false;
            foreach(Universidad.EClases retorno in i.clasesDelDia)
            {
                if (retorno == clase)
                    rta = true;
            }
            return rta;
        }
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return (!(i == clase));
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.MostrarDatos());

            return sb.ToString();
        }
        #endregion
    }
}
