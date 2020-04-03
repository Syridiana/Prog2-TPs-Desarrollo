using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;


        public Numero() : this(0)
        {

        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        static double ValidarNumero(string strNumero)
        {
            double numero = 0;
            double.TryParse(strNumero, out numero);

            return numero;
        }

        public string BinarioDecimal(string binario)
        {

            return "";
        }

        public string DecimalBinario(double numero)
        {
            int num = (int)Math.Abs(numero);
            StringBuilder binario = new StringBuilder();

            while (num > 0)
            {
                binario.Append(num % 2);
                num -= num % 2;
                num /= 2;
            }

            return binario.ToString(); //queda revertido el numero solucionar
        }

        public string DecimalBinario(string numero)
        {

            return "";
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
    }

}
