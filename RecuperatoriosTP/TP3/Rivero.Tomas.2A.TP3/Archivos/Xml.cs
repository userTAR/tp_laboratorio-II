using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        #region metodos
        /// <summary>
        /// Guarda los datos en archivo pasado por parámetro en formato XML
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>True si lo guardó, False si no se pudo debido a una excepción</returns>
        public bool Guardar(string archivo, T datos)
        {
            bool rta = false;
            try 
            {
                using (XmlTextWriter txw = new XmlTextWriter(archivo,System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(txw, datos);
                    rta = true;
                }
            }
            catch (DirectoryNotFoundException e)
            {
                rta = false;
                throw new ArchivosException(e);
            }
            catch(UnauthorizedAccessException e)
            {
                rta = false;
                throw new ArchivosException(e);
            }
            return rta;
        }
        /// <summary>
        /// Lee los datos del archivo pasado por parámetro
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>True si lo leyó, False si no se pudo debido a una excepción</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool rta = false;
            try 
            {
                using (XmlTextReader txr = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    datos = (T)ser.Deserialize(txr);
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
