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
        /// <summary>
        /// enumerado de tipo
        /// </summary>
        public enum ETipo { CuatroPuertas, CincoPuertas }
        #endregion

        #region atributos
        ETipo tipo;
        #endregion

        #region constructor
        /// <summary>
        /// Constructor de Sedan, llamando a constructor de base e inicializando el tipo a CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            tipo = ETipo.CuatroPuertas;
        }
        /// <summary>
        /// Constructor de Sedan, llamando a la primer sobrecarga del constructor y cambiando 
        /// el tipo al pasado por parámetro
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
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
        /// <summary>
        /// Concatena toda la información sobre el objeto SEDAN, llamando a mostrar de clase padre
        /// </summary>
        /// <returns>string con toda la información del objeto</returns>
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
