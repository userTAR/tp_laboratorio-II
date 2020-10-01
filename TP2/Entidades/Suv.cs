using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region constructores
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        { }
        
        #endregion

        #region propiedades
        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
        protected override ETamaño GetTamaño
        {
            get
            {
                return ETamaño.Grande;
            }
        }
        #endregion

        #region metodos
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TAMAÑO: " + this.GetTamaño.ToString());
            sb.AppendLine("---------------------");
            return sb.ToString();
        }
        #endregion
    }
}
