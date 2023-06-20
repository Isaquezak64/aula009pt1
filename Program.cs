using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao jogo do 21");
            Console.WriteLine("Faça 21 pontos para vencer");
            
            while (true)
            {
                int pontos = 0;
                Console.WriteLine($"Você tem {pontos} pontos");
                Console.WriteLine("Digite 1 para continuar ou 2 para parar");
                int resposta = int.Parse( Console.ReadLine() );

                if (resposta == 2)
                {

                }
                else
                {
                    Console.WriteLine("Fim de Jogo");
                    break;
                }
                Random sorteador= new Random();
                int numero = sorteador.Next();
                Console.WriteLine("Você tirou o número "+numero);

                pontos += numero;

                if (pontos >= 21) {
                  Console.WriteLine("fim de jogo!");
                    break;
                }


            }
            Console.ReadKey();



        }
    }
}
