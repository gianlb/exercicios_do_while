using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class ContarNumerosParImpar
    {
        public static void Main(string[] args)
        {
            int valor, quantidadePares = 0, quantidadeImpares = 0;

            Console.WriteLine("Digite números inteiros (digite 0 para encerrar):");

            do
            {
                Console.WriteLine("Digite um número: ");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor == 0)
                    break;

                if (valor % 2 == 0)
                    quantidadePares++;
                else
                    quantidadeImpares++;

            } while (valor != 0);

            Console.WriteLine("Total de números pares: " + quantidadePares);
            Console.WriteLine("Total de números ímpares: " + quantidadeImpares);
        }
    }
}
