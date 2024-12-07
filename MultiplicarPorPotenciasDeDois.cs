using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class MultiplicarPorPotenciasDeDois
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int valor = Convert.ToInt32(Console.ReadLine());
            int resultadoAtual = valor;
            int expoente = 0;

            Console.WriteLine("Multiplicação de " + valor + " por potências de 2:");

            while (resultadoAtual <= 1000)
            {
                Console.WriteLine(valor + " x 2^" + expoente + " = " + resultadoAtual);
                expoente++;
                resultadoAtual = valor * (int)Math.Pow(2, expoente);
            }

            Console.WriteLine("Fim da sequência (o valor ultrapassou 1000).");
        }
    }
}
