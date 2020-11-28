using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public abstract class Aeronave
    {
        #region atributos
        private string marca;
        private string modelo;
        private double numeroDeSerie;
        private int velocidadCrucero;
        private double precio;
        #endregion

        #region enumerados
        /// <summary>
        /// Enumerado de tipo de ala
        /// </summary>
        public enum EAla
        {
            Fija,
            Rotativa
        }
        #endregion

        #region propiedades
        /// <summary>
        /// Get/Set de marca
        /// </summary>
        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }
        /// <summary>
        /// Get/Set de modelo
        /// </summary>
        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }
        /// <summary>
        /// Get/Set de velocidadCrucero
        /// </summary>
        public int VelocidadCrucero
        {
            get { return this.velocidadCrucero; }
            set 
            {
                if (value > 0)
                    this.velocidadCrucero = value;
                else
                    throw new VelocidadException("La velocidad crucero no puede ser igual o menor que 0 nudos");
            }
        }
        public double NumeroDeSerie
        {
            get { return this.numeroDeSerie; }
            set { this.numeroDeSerie = value; }
        }
        public double Precio
        {
            get { return this.precio; }
            set
            {
                if (value > 0)
                    this.precio = value;
                else
                    throw new PrecioException();
            }
        }
        public abstract EAla Ala { get; }
        #endregion

        #region constructores
        /// <summary>
        /// Constructor sin parámetros
        /// </summary>
        public Aeronave() { }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="velocidad"></param>
        /// <param name="numeroSerie"></param>
        public Aeronave(string marca, string modelo, int velocidad, double precio, double numeroSerie)
        {
            this.Marca = marca;
            this.Modelo= modelo;
            this.VelocidadCrucero= velocidad;
            this.NumeroDeSerie = numeroSerie;
            this.Precio = precio;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Concatena toda la información de la aeronave
        /// </summary>
        /// <returns>String con los datos de la aeronave</returns>
        protected virtual string InfoAeronave()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Marca: {0} // Modelo: {1} // Precio : ${2}\n", this.marca, this.modelo, this.Precio);
            sb.AppendFormat("Velocidad Crucero: {0}\n", this.velocidadCrucero);
            return sb.ToString();
        }
        #endregion

        #region sobrecargas
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Aeronave)
                rta = this == (Aeronave)obj;
            return rta;
        }

        public static bool operator ==(Aeronave a1, Aeronave a2)
        {
            return a1.Marca == a2.Marca && a1.NumeroDeSerie == a2.NumeroDeSerie;
        }
        public static bool operator !=(Aeronave a1, Aeronave a2)
        {
            return (!(a1 == a2));
        }
        #endregion
    }
}
