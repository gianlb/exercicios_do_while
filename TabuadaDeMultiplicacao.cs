using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class TabuadaDeMultiplicacao
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            Console.WriteLine("Digite um número:");
            int numeroEscolhido = Convert.ToInt32(Console.ReadLine());
            do
            {
                int resultadoMultiplicacao = 0;
                resultadoMultiplicacao = contador * numeroEscolhido;
                Console.WriteLine("A tabuada do número: " + numeroEscolhido);
                Console.WriteLine(numeroEscolhido + " X " + contador + " = " + resultadoMultiplicacao);
                contador++;
            } while (contador != 11);
        }
    }
}
