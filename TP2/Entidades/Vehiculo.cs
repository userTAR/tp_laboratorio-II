using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region enumerados
        /// <summary>
        /// Marcas de vehículos
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        /// <summary>
        /// Tamaños de vehículos
        /// </summary>
        public enum ETamaño
        {
            Chico, Mediano, Grande
        }
        #endregion

        #region atributos
        EMarca marca;
        string chasis;
        ConsoleColor color;
        #endregion

        #region constructor
        /// <summary>
        /// Constructor de vehículo, inicializando el chasis, marca y color según parámetros de la función
        /// </summary>
        /// <param name="chasis"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        #endregion

        #region propiedades
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamaño GetTamaño { get; }
        #endregion

        #region metodos
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion

        #region sobrecargas
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CHASIS: {p.chasis}\r\n");
            sb.AppendLine($"MARCA : {p.marca.ToString()}\r\n");
            sb.AppendLine($"COLOR : {p.color.ToString()}\r\n");
            sb.AppendLine("---------------------\n");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return (!(v1.chasis == v2.chasis));
        }
        public override bool Equals(object obj)
        {
            bool rta = false;
            
            if (obj is Vehiculo)
                rta = this == (Vehiculo)obj;

            return rta;
        }
        #endregion
    }
}
