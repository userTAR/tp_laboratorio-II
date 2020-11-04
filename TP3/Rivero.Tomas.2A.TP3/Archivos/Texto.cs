using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        #region metodos
        /// <summary>
        /// Guarda el string de datos en archivo pasado por parámetro
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>True si lo guardó, False si no se pudo debido a una excepción</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool rta = false;
            try 
            {
                using (StreamWriter sw = new StreamWriter(archivo, false, System.Text.Encoding.UTF8))
                {
                    rta = true;
                    sw.Write(datos);
                }
            }
            catch(DirectoryNotFoundException e)
            {
                rta = false;
                throw new ArchivosException(e);
            }
            catch (UnauthorizedAccessException e)
            {
                rta = false;
                throw new ArchivosException(e);
            }

            return rta;
        }
        /// <summary>
        /// Lee el string del archivo pasado por parámetros
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>True si lo leyó, False si no se pudo debido a una excepción</returns>
        public bool Leer(string archivo, out string datos)
        {
            bool rta = false;
            try 
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    datos = sr.ReadToEnd();
                    rta = true;
                }
            }
            catch (DirectoryNotFoundException e)
            {
                rta = false;
                throw new ArchivosException(e);
            }
            catch (UnauthorizedAccessException e)
            {
                rta = false;
                throw new ArchivosException(e);
            }
            return rta;
        }
        #endregion
    }
}
