using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class VerificacaoDeParidade
    {
        public static void Main(string[] args)
        {
            int valorDigitado = 0;
            Console.WriteLine("Digite números inteiros. O programa termina quando um número par for digitado.");

            do
            {
                Console.Write("Digite um número: ");

                valorDigitado = Convert.ToInt32(Console.ReadLine());

                if (valorDigitado % 2 != 0)
                {
                    Console.WriteLine("O número é ímpar. Continue.");
                }
            } while (valorDigitado % 2 != 0);
            Console.WriteLine("Parabéns! Você digitou um número par. Programa encerrado.");
        }
    }
}
