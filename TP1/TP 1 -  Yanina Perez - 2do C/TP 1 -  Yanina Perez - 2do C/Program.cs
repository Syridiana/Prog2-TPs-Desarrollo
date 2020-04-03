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

            Console.WriteLine("{0}", cinco.DecimalBinario(20));

            Console.ReadKey();
        }
    }
}
