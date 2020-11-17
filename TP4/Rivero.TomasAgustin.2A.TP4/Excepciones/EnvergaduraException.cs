using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class EnvergaduraException : Exception
    {
        public EnvergaduraException() : base("La envergadura tiene una medida inválida") { }
        public EnvergaduraException(string mensaje) : base(mensaje) { }
    }
}
