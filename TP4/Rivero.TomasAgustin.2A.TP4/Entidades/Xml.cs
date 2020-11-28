using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public class Xml
    {
        public static bool GuardarXml(Deposito<Avion> deposito)
        {
            bool rta = false;
            try
            {
                using (XmlTextWriter txw = new XmlTextWriter(Xml.Path, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Deposito<Avion>));
                    ser.Serialize(txw, deposito);
                    rta = true;
                }
            }
            catch (DirectoryNotFoundException e)
            {
                rta = false;
            }
            catch (UnauthorizedAccessException e)
            {
                rta = false;
            }
            return rta;
        }
        public static string Path
        {
            get
            {
                string retorno = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                retorno += @"\ListaNoVendidos";
                return retorno;
            }
        }

        public static bool LeerXml(out Deposito<Avion> deposito)
        {
            deposito = null;
            bool rta = false;
            try
            {
                using (XmlTextReader txr = new XmlTextReader(Xml.Path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Deposito<Avion>));
                    deposito = (Deposito<Avion>)ser.Deserialize(txr);
                    rta = true;
                }
            }
            catch (DirectoryNotFoundException e)
            {
                rta = false;
            }

            catch (UnauthorizedAccessException e)
            {
                rta = false;

            }
            return rta;
        }
    }
}
    
