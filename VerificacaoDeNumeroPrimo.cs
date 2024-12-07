using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class VerificacaoDeNumeroPrimo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numeroDigitado = Convert.ToInt16(Console.ReadLine());

            if(numeroDigitado <= 1)
            {
                Console.WriteLine(numeroDigitado + " não é um número primo.");
                return;
            }
            int divisorAtual = 2;
            bool isPrimo = true;
            do
            {
                if (numeroDigitado % divisorAtual == 0)
                {
                    isPrimo = false;
                    break;
                }
                divisorAtual++;
            } while (divisorAtual < numeroDigitado);

            if (isPrimo)
            {
                Console.WriteLine(numeroDigitado + " é um número primo.");
            }
            else
            {
                Console.WriteLine(numeroDigitado + " não é um número primo.");
            }
        }
    }
}
