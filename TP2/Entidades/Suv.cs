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
        /// <summary>
        /// Constructor de Suv, llamando al constructor de la clase padre
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
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
        /// <summary>
        /// Concatena toda la información sobre el objeto Suv, llamando a mostrar de clase padre
        /// </summary>
        /// <returns>string con toda la información del objeto</returns>
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
