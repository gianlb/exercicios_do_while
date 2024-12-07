using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class SomaDeValores
    {
        public static void Main(string[] args)
        {
            int valorDigitado = 0;
            int totalSoma = 0;
            Console.WriteLine("Digite números inteiros para somar. Para encerrar, digite 0.");

            do
            {
                Console.WriteLine("Digite um número: ");
                valorDigitado = Convert.ToInt32(Console.ReadLine());
                totalSoma += valorDigitado;
                Console.WriteLine("A soma dos números digitados é: " + totalSoma);
            } while (valorDigitado != 0);
        }
    }
}
