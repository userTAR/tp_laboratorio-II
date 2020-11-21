using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Planeador : Aeronave
    {
        #region atributos
        private double envergadura;
        #endregion

        #region propiedades
        /// <summary>
        /// Propiedades get / set de las variables
        /// </summary>
        public double Envergadura
        {
            get { return this.envergadura; }
            set 
            {
                if (value > 0)
                    this.envergadura = value;
                else
                    throw new EnvergaduraException("Un planeador no puede tener una envergadura menor o igual a 0");
            }
        }
        public override EAla Ala
        {
            get { return EAla.Fija; }
        }
        #endregion

        #region constructores
        /// <summary>
        /// Constructor sin parámetros que llama al base
        /// </summary>
        public Planeador() : base() { }
        /// <summary>
        /// Constructor con parámetros que llama al base
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="velocidadCrucero"></param>
        /// <param name="numeroSerie"></param>
        /// <param name="envergadura"></param>
        public Planeador(string marca, string modelo, int velocidadCrucero, double precio, double numeroSerie, double envergadura) : base(marca, modelo, velocidadCrucero, precio, numeroSerie)
        {
            this.Envergadura = envergadura;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Concatena la información del planeador
        /// </summary>
        /// <returns>string de la cadena</returns>
        protected override string InfoAeronave()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.InfoAeronave());
            sb.AppendFormat("Envergadura: {0} // Tipo de ala: {1}\n\n", this.Envergadura, this.Ala);
            return sb.ToString();
        }
        #endregion

        #region sobrecargas
        public override string ToString()
        {
            return this.InfoAeronave();
        }
        #endregion
    }
}
