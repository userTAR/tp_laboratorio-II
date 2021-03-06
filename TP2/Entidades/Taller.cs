﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Taller
    {
        #region atributos
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        #endregion

        #region enumerados
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }
        #endregion

        #region constructores
        /// <summary>
        /// Constructor privado de Taller, inicializa solamente la lista
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        /// <summary>
        /// Constructor público de Taller, llama al constructor privado y luego inicializa la 
        /// cantidad de espacios disponibles según parámetro de la función
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region sobrecargas
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Listar(this, ETipo.Todos);
        }
        #endregion

        #region metodos
        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tenemos {this.vehiculos.Count} lugares ocupados de un total de {this.espacioDisponible} disponibles");

            foreach (Vehiculo v in this.vehiculos)
            {
                switch(tipo)
                {
                    case ETipo.Ciclomotor:
                        if(v is Ciclomotor)
                            sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Sedan: 
                        if(v is Sedan)
                            sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.SUV: 
                        if(v is Suv)
                            sb.AppendLine(v.Mostrar());
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }
            return sb.ToString();
        }


        #endregion

        #region operadores
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            bool check = false;
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                    check = true;
            }
            if (check == false)
                taller.vehiculos.Add(vehiculo);
            
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            bool check = false;
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                    check = true;
            }
            if (check == true)
                taller.vehiculos.Remove(vehiculo);

            return taller;
        }
        #endregion
    }
}

