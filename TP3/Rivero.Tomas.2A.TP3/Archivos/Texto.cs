using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        #region metodos
        public bool Guardar(string archivo, string datos)
        {
            bool rta = false;
            using (StreamWriter sw = new StreamWriter(archivo, false, System.Text.Encoding.UTF8))
            {
                rta = true;
                sw.Write(datos);
            }

            return rta;
        }
        public bool Leer(string archivo, out string datos)
        {
            bool rta = false;
            using (StreamReader sr = new StreamReader(archivo)
            {
                rta = true;
            }

            return rta;
        }
        #endregion
    }
}
