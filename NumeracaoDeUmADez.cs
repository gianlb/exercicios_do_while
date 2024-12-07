using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class NumeracaoDeUmADez
    {
        public static void Main(string[] args)
        {
            int contador = 0;
            do
            {
                Console.WriteLine(contador);
                contador++;
            } while (contador <= 10);  
        }
    }
}
