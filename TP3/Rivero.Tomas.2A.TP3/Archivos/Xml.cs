using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        #region metodos
        public bool Guardar(string archivo, T datos)
        {
            bool rta = false;
            using (XmlTextWriter txw = new XmlTextWriter(archivo,System.Text.Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(txw, datos);
                rta = true;
            }
                return rta;
        }
        public bool Leer(string archivo, out T datos)
        {
            bool rta = false;
            using (XmlTextReader txr = new XmlTextReader(archivo))
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                datos = (T)ser.Deserialize(txr);
                rta = true;
            }
            return rta;
        }
        #endregion
    }
}
