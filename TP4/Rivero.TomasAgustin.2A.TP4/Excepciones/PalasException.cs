using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class PalasException : Exception
    {
        public PalasException() : base("El dato de palas es inválido") { }
        public PalasException(string mensaje) : base(mensaje) { }
    }
}
