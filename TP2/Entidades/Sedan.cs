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
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo):this(marca, chasis, color)
        {
            this.tipo = tipo;
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
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TAMAÑO : " + this.GetTamaño);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("\n---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
