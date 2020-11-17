using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Deposito<T> : Interfaz where T : Aeronave
    {
        #region atributos
        private List<T> lista;
        #endregion

        #region propiedades
        public List<T> Lista
        {
            get { return this.lista; }
        }
        #endregion

        #region metodos
        private string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            foreach(T elemento in this.Lista)
            {
                sb.Append(elemento.ToString());
            }
            return sb.ToString();
        }
        public string ImprimirTotal()
        {
            double precio = 0;
            foreach(T retorno in this.Lista)
            {
                precio += retorno.Precio;
            }
            return precio.ToString();
        }
        #endregion

        #region sobrecargas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Las aeronaves del depósito son las siguientes:");
            sb.AppendLine("-----------------------------------------------");
            sb.Append(this.MostrarInformacion());
            return sb.ToString();
        }
        #endregion
    }
}
