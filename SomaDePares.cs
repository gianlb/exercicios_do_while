using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class SomaDePares
    {
        public static void Main(string[] args) 
        {
            int valor = 0;
            int somaDosPares = 0;
            Console.WriteLine("Digite números inteiros (digite 0 para encerrar):");
            do
            {
                Console.WriteLine("Digite um número: ");
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor % 2 == 0 && valor != 0)
                    somaDosPares += valor;

            } while (valor != 0);
            Console.WriteLine("A soma dos números pares digitados é: " + somaDosPares);
        }
    }
}
