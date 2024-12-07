using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class JogoDeAdivinhacao
    { 
        public static void Main(string[] args)
        {
            int valorOculto = 3;
            int tentativaUsuario = 0;
            Console.WriteLine("Tente adivinhar o número oculto!");
            do
            {
                Console.WriteLine("Insira seu chute: ");
                tentativaUsuario = Convert.ToInt32(Console.ReadLine());
                if (tentativaUsuario < valorOculto)
                {
                    Console.WriteLine("Muito baixo! Tente novamente.");
                }
                else if (tentativaUsuario > valorOculto)
                {
                    Console.WriteLine("Muito alto! Tente novamente.");
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número oculto.");
                }
                
            } while (tentativaUsuario != valorOculto);    
        }
    }
}
