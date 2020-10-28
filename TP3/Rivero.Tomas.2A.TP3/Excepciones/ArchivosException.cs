using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        public ArchivosException() : base("Archivo no válido")
        {

        }
        public ArchivosException(Exception innerException) : base("Archivo no válido",innerException)
        {

        }
    }
}
