using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region enumerados
        public enum ETipo { CuatroPuertas, CincoPuertas }
        #endregion
        #region atributos
        ETipo tipo;
        #endregion

        #region constructor
        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            tipo = ETipo.CuatroPuertas;
        }
        #endregion
        #region propiedades
        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamaño GetTamaño
        {
            get
            {
                return ETamaño.Mediano;
            }
        }
        #endregion

        #region sobrecargas
        public override sealed string Mostrar()// quedé en esta función
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(this);
            sb.AppendLine("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb;
        }
        #endregion
    }
}
