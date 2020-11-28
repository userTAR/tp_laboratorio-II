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
        #region constructores
        public Deposito()
        {
            this.lista = new List<T>();
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
            sb.AppendFormat("Las aeronaves del depósito suman: {0} y son las siguientes:\n", this.ImprimirTotal());
            sb.AppendLine("-----------------------------------------------");
            sb.Append(this.MostrarInformacion());
            return sb.ToString();
        }

        public static bool operator ==(Deposito<T> deposito, T Aeronave)
        {
            return deposito.Lista.Contains(Aeronave);
        }
        public static bool operator !=(Deposito<T> deposito, T Aeronave)
        {
            return (!(deposito == Aeronave));
        }
        public static Deposito<T> operator +(Deposito<T> deposito, T aeronave)
        {
            if (deposito != aeronave)
                deposito.Lista.Add(aeronave);
            return deposito;
        }
        public static Deposito<T> operator -(Deposito<T> deposito, T aeronave)
        {
            if (deposito == aeronave)
                deposito.Lista.Remove(aeronave);
            return deposito;
        }

        #endregion
    }
}
