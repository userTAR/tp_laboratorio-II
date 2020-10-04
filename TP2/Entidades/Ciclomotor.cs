using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region constructor
        /// <summary>
        /// Constructor de ciclomotor, hace llamado a constructor de base
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color):base(chasis,marca,color)
        {
        }
        #endregion

        #region propiedades
        /// <summary>
        /// Las motos son chicas
        /// </summary>
        protected override ETamaño GetTamaño
        {
            get
            {
                return ETamaño.Chico;
            }
        }
        #endregion

        #region metodos
        /// <summary>
        /// Muestra todos los datos del ciclomotor, llamando a la función Mostrar() de la clase padre
        /// </summary>
        /// <returns>string con toda la información del objeto</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.GetTamaño}");
            sb.AppendLine("\n---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
