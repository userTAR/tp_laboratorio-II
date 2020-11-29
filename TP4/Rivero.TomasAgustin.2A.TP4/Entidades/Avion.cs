using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Avion : Aeronave
    {
        #region atributos 
        private int velocidadPerdida;
        private EPaso tipoDePaso;
        private int autonomia;
        private double envergadura;
        #endregion

        #region enumerados
        /// <summary>
        /// Enumerado de tipo de paso de la hélice
        /// </summary>
        public enum EPaso
        {
            Fijo,
            Variable
        }
        #endregion

        #region propiedades
        /// <summary>
        /// Propiedades set y get de todas las variables
        /// </summary>
        public int VelocidadDePerdida
        {
            get { return this.velocidadPerdida; }
            set 
            {
                if (value > 0)
                    this.velocidadPerdida = value;
                else
                    throw new VelocidadException("La velocidad de pérdida no puede ser menor que 0 nudos");
            }
        }
        public EPaso TipoDePaso
        {
            get { return this.tipoDePaso; }
            set { this.tipoDePaso = value; }
        }
        public int Autonomia
        {
            get { return this.autonomia; }
            set { this.autonomia = value; }
        }
        public double Envergadura
        {
            get { return this.envergadura; }
            set { this.envergadura = value; }
        }
        public override EAla Ala
        {
            get { return EAla.Fija; }
        }
        #endregion

        #region constructores
        /// <summary>
        /// Constructor sin parámetros que llama al constructor base
        /// </summary>
        public Avion():base() { }
        /// <summary>
        /// Constructor con parámetros que llama al constructor base
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="velocidadCrucero"></param>
        /// <param name="velocidadDePerdida"></param>
        /// <param name="tipoDePaso"></param>
        /// <param name="autonomia"></param>
        /// <param name="envergadura"></param>
        /// <param name="numeroSerie"></param>
        public Avion(string marca, string modelo, int velocidadCrucero, int velocidadDePerdida,double precio, double numeroSerie, EPaso tipoDePaso, int autonomia, double envergadura) : base(marca, modelo, velocidadCrucero, precio, numeroSerie)
        {
            this.VelocidadDePerdida = velocidadDePerdida;
            this.TipoDePaso = tipoDePaso;
            this.Autonomia = autonomia;
            this.Envergadura = envergadura;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Concatena la información del avión
        /// </summary>
        /// <returns>string de la cadena</returns>
        protected override string InfoAeronave()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.InfoAeronave());
            sb.AppendFormat("Velocidad de pérdida: {0} // Envergadura: {1}\nTipo de paso: {2} // Autonomia: {3}\nTipo de ala: {4}\n\n", this.VelocidadDePerdida, this.Envergadura, this.TipoDePaso.ToString(), this.MostrarAutonomia(), this.Ala);
            return sb.ToString();
        }


        #endregion

        #region sobrecargas
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Retorna string con la información de la aeronave</returns>
        public override string ToString()
        {
            return this.InfoAeronave();
        }

        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Avion)
                rta = this == (Avion)obj;
            return rta;
        }
        #endregion
    }
}
