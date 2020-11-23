using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region atributos
        private double numero;
        #endregion

        #region constructores
        /// <summary>
        /// constructor del objeto Numero sin parametros *inicializa en 0 el numero*
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// constructor del objeto Numero que iguala el valor pasado por parametro al numero del objeto
        /// </summary>
        /// <param name="numero">numero de tipo doble</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// constructor del objeto Numero que llama a la funcion SetNumero e iguala el numero del string pasado por parametro
        /// </summary>
        /// <param name="strNumero">numero de tipo string</param>
        public Numero(string strNumero)
        {
            this.SetNumero(strNumero);
        }
        #endregion

        #region setter
        public void SetNumero(string strNumero)
        {
            this.numero = 0;
            if(this.ValidarNumero(strNumero)!=0)
            {
                this.numero = Convert.ToDouble(strNumero);
            }
        }
        #endregion

        #region validaciones
        /// <summary>
        /// determina si el numero es binario o no 
        /// </summary>
        /// <param name="binario">numero binario de tipo string</param>
        /// <returns>false si no es binario *true si es binario*</returns>
        private static bool EsBinario(string binario)
        {
            int i;
            bool retorno = false;

            for (i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1' || binario[i] == '0')
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// valida que sea un numero
        /// </summary>
        /// <param name="strNumero">numero de tipo string</param>
        /// <returns>el mismo valor del parametro si es un numero *devuelve 0 si no es un numero*</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno=1;
            bool check;

            check = double.TryParse(strNumero, out retorno);
            if(!check)
            {
                retorno = 0;
            }
            return retorno;
        }
        /// <summary>
        /// transforma un numero decimal a uno binario
        /// </summary>
        /// <param name="numero">numero de tipo int</param>
        /// <returns>el numero binario en tipo string</returns>
        private static string DecimalABinario(int numero)
        {
            string retorno = "";
            do
            {
                if (numero % 2 == 0)
                    retorno = '0' + retorno;
                else
                    retorno = '1' + retorno;
                numero = numero / 2;
                if (numero < 2)
                {
                    retorno = '1' + retorno;
                }
            } while (numero >= 2);
            return retorno;
        }
        #endregion

        #region metodos
        /// <summary>
        /// transforma un numero de binario a decimal
        /// </summary>
        /// <param name="binario">numero binario de tipo string</param>
        /// <returns>el numero decimal en tipo string</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno="Valor inválido";
            bool check = EsBinario(binario);
            if(check==true)
            {
                retorno = Convert.ToInt64(binario, 2).ToString();
            }
            return retorno;
        }
        /// <summary>
        /// transforma un numero de binario a decimal
        /// </summary>
        /// <param name="numero">numero de tipo double</param>
        /// <returns>el numero decimal en tipo string</returns>
        public string DecimalBinario(double numero)
        {
            string retorno="Valor Inválido";
            double check;
            int checkAux;
            if (numero != double.MinValue)
            { 
                retorno = Convert.ToString(numero); //convierto el double en string
                check = ValidarNumero(retorno);//chequeo que sea un numero valido
                if(check!=0 && check>0)
                {
                    checkAux = Convert.ToInt32(check);//convierto el numero validado en INT
                    retorno = DecimalABinario(checkAux);//retorno el binario del INT anterior
                }
            }

            return retorno;
        }
        /// <summary>
        /// transforma un numero de binario a decimal 
        /// </summary>
        /// <param name="numero">numero de tipo string</param>
        /// <returns>el numero decimal en tipo string</returns>
        public string DecimalBinario(string numero)
        {
            string retorno="Valor inválido";
            double check;
            int checkAux;

            check = ValidarNumero(numero);//chequeo que sea un numero valido
            if (check != 0 && check>0)
            {
                checkAux = Convert.ToInt32(check);//lo convierto a INT
                retorno = DecimalABinario(checkAux);//retorno el binario del INT anterior
            }

            return retorno;
        }
        #endregion

        #region sobrecargas
        public static double operator +(Numero n1, Numero n2)
        {
            double retorno;

            retorno = n1.numero + n2.numero;

            return retorno;
        }
        
        public static double operator -(Numero n1, Numero n2)
        {
            double retorno;

            retorno = n1.numero - n2.numero;
            return retorno;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double retorno;

            retorno = n1.numero * n2.numero;
            return retorno;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double retorno;
            if (n2.numero == 0)
                retorno = double.MinValue;
            else
                retorno = n1.numero / n2.numero;
            return retorno;
        }
        #endregion
    }
}
