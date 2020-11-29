using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensionAvion
    {
        /// <summary>
        /// Devuelve la autonomia del avion
        /// </summary>
        /// <param name="avion"></param>
        /// <returns>string con la autonomia</returns>
        public static string MostrarAutonomia(this Avion avion)
        {
            return avion.Autonomia.ToString() + "Hs";
        }
    }
}
