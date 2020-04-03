using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            if (operador == "*" || operador == "-" || operador == "+" || operador == "/")
            {
                return operador;
            }
            else
            {
                return "+";
            }
        }

        public static double Operador(Numero num1, Numero num2, string operador)
        {
            if (operador == "+")
            {

                return 0;
            }
            else if (operador == "-")
            {
                return 0;

            }
            else if (operador == "*")
            {
                return 0;
            }
            else if (operador == "/")
            {
                return 0;
            }
                        return 0;
        }


    }
}
