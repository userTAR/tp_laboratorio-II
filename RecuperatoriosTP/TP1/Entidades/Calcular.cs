using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calcular
    {
        /// <summary>
        /// Opera suma/resta/division/multiplicacion dependiendo del operando recibido
        /// </summary>
        /// <param name="num1">objeto de tipo Numero, 1</param>
        /// <param name="num2">objeto de tipo Numero, 2</param>
        /// <param name="operador">signo de operacion</param>
        /// <returns>el valor de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno=0;
            char opAux;
            try
            {
                opAux = Convert.ToChar(operador);
            }
            catch (FormatException e)
            {
                opAux = '+';
            }

            string opCheck = ValidarOperador(opAux);
            switch(opCheck)
            {
                case "+":
                    retorno = num1 + num2;
                    break;
                case "-":
                    retorno = num1 - num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
                case "/":
                    retorno = num1 / num2;
                    break;
            }

            return retorno;
        }
        /// <summary>
        /// valida que el operador sea el correspondiente a +,-,/,*
        /// </summary>
        /// <param name="operador">signo de operacion</param>
        /// <returns>string con el signo *caso invalido devuelve:+*</returns>
        private static string ValidarOperador(char operador)
        {
            string retorno;
            
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
                retorno = Convert.ToString(operador);
            else
                retorno = "+";
            return retorno;
        }
    }
}
