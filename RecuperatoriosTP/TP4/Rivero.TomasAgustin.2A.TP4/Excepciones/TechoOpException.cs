using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class TechoOpException : Exception
    {
        public TechoOpException() : base("El techo operativo es inválido") { }
        public TechoOpException(string mensaje) : base(mensaje) { }
    }
}
