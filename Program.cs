using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoDaAtividade21
{
    class Program
    {
        static void Main(string[] args)
        {


            // essa variavel guarda pontos 
            int pontos = 0;
            Random sorteador = new Random(); // sempre bom deixar fora do while, para travar a maquina 
            Console.WriteLine("Bem-vindo ao jogo do 21!");
            Console.WriteLine("Seu objetivo é chegar o mais próximo de 21 pontos");


            while(true)
            {
               

                Console.WriteLine($"Você tem {pontos} pontos!");
                Console.WriteLine("Deseja continuar?: 1 para sim ou 2 para não");
                int opcao = int.Parse(Console.ReadLine());


                if (opcao == 2 )
                {
                    Console.WriteLine("--FIM DE JOGO--");
                    break; //quebra do codigo dentro do while
                }

                
                int numero = sorteador.Next(1, 11);
                Console.WriteLine($"Você tirou o número {numero}");

                pontos += numero; // para somar os pontos



                if ( pontos > 21)
                {
                    Console.WriteLine("Ah que pena, você estourou a pontuação...");
                    break;
                }



            }

            Console.WriteLine($"Fim de jogo sua pontuação final foi de {pontos} pontos ");
            Console.ReadKey();


        }
    }
}
