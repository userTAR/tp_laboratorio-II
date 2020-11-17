using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Helicoptero : Aeronave
    {
        #region
        private int cantidadPalas;
        private double techoOperativo;
        #endregion

        #region propiedades
        /// <summary>
        /// Propiedades set / get de las variables
        /// </summary>
        public int CantidadDePalas
        {
            get { return this.cantidadPalas; }
            set 
            {
                if (value > 1)
                    this.cantidadPalas = value;
                else
                    throw new PalasException("El helicoptero necesita mínimamente 2 palas para generar sustentación");
            }
        }
        public double TechoOperativo
        {
            get { return this.techoOperativo; }
            set 
            {
                if (value > 42000)
                    throw new TechoOpException("Ningún helicoptero puede volar a " + value.ToString() + " pies, por encima de la tropósfera");
                else if (value <= 0)
                    throw new TechoOpException("El techo operativo no puede ser inferior o igual a 0");
                else
                    this.techoOperativo = value; 
            }
        }
        public override EAla Ala
        {
            get { return EAla.Rotativa; }
        }
        #endregion

        #region constructor
        /// <summary>
        /// Constructor sin parámetros que llama al constructor base
        /// </summary>
        public Helicoptero() : base(){ }
        /// <summary>
        /// Constructor con parámetros que llama al constructor base
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="velocidadCrucero"></param>
        /// <param name="cantidadDePalas"></param>
        /// <param name="techoOperativo"></param>
        /// <param name="numeroSerie"></param>
        public Helicoptero(string marca, string modelo, int velocidadCrucero, long numeroSerie, int cantidadDePalas, double techoOperativo) : base(marca, modelo, velocidadCrucero, numeroSerie)
        {
            this.CantidadDePalas = cantidadDePalas;
            this.TechoOperativo = techoOperativo;
        }
        #endregion

        #region metodos
        protected override string InfoAeronave()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.InfoAeronave());
            sb.AppendFormat("Cantidad de palas: {0} // Techo operativo: {1}\nTipo de ala: {2}\n\n", this.CantidadDePalas, this.TechoOperativo, this.Ala);
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
