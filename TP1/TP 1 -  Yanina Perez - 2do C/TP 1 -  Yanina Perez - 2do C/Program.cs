using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero cinco = new Numero(5);
            Numero cuatro = new Numero("4");
            Numero cero = new Numero();

            Console.WriteLine("4 + 5: {0}", Calculadora.Operar(cinco, cuatro, "+"));
            Console.WriteLine("5 - 4: {0}", Calculadora.Operar(cinco, cuatro, "-"));
            Console.WriteLine("5 / 4: {0}", Calculadora.Operar(cinco, cuatro, "/"));
            Console.WriteLine("5 * 4: {0}", Calculadora.Operar(cinco, cuatro, "*"));
            Console.WriteLine("4 / 0: {0}", Calculadora.Operar(cuatro, cero, "/"));

            Console.WriteLine("01010101 a decimal: {0}", cinco.BinarioDecimal("01010101"));
            Console.WriteLine("01013501 a decimal: {0}", cinco.BinarioDecimal("01013501"));
            Console.WriteLine("-6 a binario: {0}", cinco.DecimalBinario(-6));
            Console.WriteLine("8 a binario: {0}", cinco.DecimalBinario(8));
            Console.WriteLine("5.54641 a binario: {0}", cinco.DecimalBinario(5.5464));
            Console.WriteLine("9 a binario: {0}", cinco.DecimalBinario("9"));
            Console.WriteLine("6,54 a binario: {0}", cinco.DecimalBinario("6,54"));


            Console.ReadKey();
        }
    }
}
