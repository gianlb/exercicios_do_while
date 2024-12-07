using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class QuantidadeDeDigitos
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int valor = Convert.ToInt16(Console.ReadLine());
            int totalDigitos = 0;

            if (valor == 0)
            {
                totalDigitos = 1;
            }
            else
            {
                while (valor > 0)
                {
                    valor /= 10; 
                    totalDigitos++;
                }
            }

            Console.WriteLine("O número digitado possui " + totalDigitos + " dígito(s).");
        }
    }
}
