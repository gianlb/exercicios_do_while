using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class ContarVogais
    {
        public static void Main(string[] args)
        {
            string texto;
            int totalVogais;

            Console.WriteLine("Digite 'sair' para encerrar o programa.");
            do
            {
                Console.Write("Digite uma palavra ou frase: ");
                texto = Console.ReadLine();

                if (texto == "sair")
                    break;

                totalVogais = 0;
                foreach (char caractere in texto)
                {
                    if ("aeiouAEIOU".Contains(caractere)) 
                        totalVogais++;
                }

                Console.WriteLine($"Número de vogais: {totalVogais}");

            } while (true);
        }
    }
}
