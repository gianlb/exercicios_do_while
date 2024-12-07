using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class OperacoesBasicas
    {
        public static void Main(string[] args)
        {
            int continuar;
            string operador;
            double valor1;
            double valor2;
            double resultadoFinal;

            Console.WriteLine("=== Calculadora Básica ===");
            Console.WriteLine("Operações disponíveis: +, -, *, /");
            Console.WriteLine("Digite 'sair' para encerrar o programa.");

            do
            {
                continuar = 1;

                Console.Write("Digite o primeiro valor: ");
                valor1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo valor: ");
                valor2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escolha uma operação (+, -, *, /) ou 'sair': ");
                operador = Console.ReadLine();

                switch (operador) 
                {
                    case "+":
                        resultadoFinal = valor1 + valor2;
                        Console.WriteLine("O resultado é: " + resultadoFinal);
                        break;

                    case "-":
                        resultadoFinal = valor1 - valor2;
                        Console.WriteLine("O resultado é: " + resultadoFinal);
                        break;

                    case "*":
                        resultadoFinal = valor1 * valor2;
                        Console.WriteLine("O resultado é: " + resultadoFinal);
                        break;

                    case "/":
                        resultadoFinal = valor1 / valor2;
                        Console.WriteLine("O resultado é: " + resultadoFinal);
                        break;

                    case "sair":
                        continuar = 0;
                        break;
                }

            } while (continuar != 0);
        }
    }
}
