using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class ContarTentativas
    {
        public static void Main(string[] args)
        {
            int valor;

            do
            {
                Console.WriteLine("Digite um número entre 1 e 100: ");
                valor = Convert.ToInt16(Console.ReadLine());

                if (valor < 1 || valor > 100)
                {
                    Console.WriteLine("Número inválido! Tente novamente.");
                }

            } while (valor < 1 || valor > 100);

            Console.WriteLine("Número válido digitado: " + valor);
        }
    }
}
