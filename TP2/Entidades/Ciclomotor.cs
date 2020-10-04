using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color):base(chasis,marca,color)
        {
        }

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

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.GetTamaño}");
            sb.AppendLine("\n---------------------");

            return sb.ToString();
        }
    }
}
