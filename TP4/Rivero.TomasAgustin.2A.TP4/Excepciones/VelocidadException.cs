using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class VelocidadException : Exception
    {
        public VelocidadException() : base("La velocidad no es válida al ámbito correspondiente")
        {

        }
        public VelocidadException(string mensaje) : base(mensaje)
        {

        }
    }
}
