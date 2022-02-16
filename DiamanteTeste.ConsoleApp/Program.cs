using System;

namespace DiamanteTeste.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de colunas");

            int numero = int.Parse(Console.ReadLine());

            int quantidadeEspacos = (numero - 1) / 2;

            int quantidadeX = 1;

            int quantidadeLinhas = (numero - 1) / 2;

            //parte de cima
            for(int i = 0; i < quantidadeLinhas; i++)
            {
                for(int j = 0; j < quantidadeEspacos; j++)
                {
                    //printar espaços
                    Console.Write(" ");
                }

                for(int k = 0; k < quantidadeX; k++)
                {
                    //printar X
                    Console.Write("x");
                }
                Console.WriteLine();
                // diminuem os espaços e aumentam os X
                quantidadeEspacos--;
                quantidadeX += 2;

            }

            for (int i = 0; i <= quantidadeLinhas; i++)
            {
                for (int j = 0; j < quantidadeEspacos; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < quantidadeX; k++)
                {
                    Console.Write("x");
                }
                //aumenta os espaços e diminuem os X
                quantidadeEspacos++;
                quantidadeX -= 2;
                Console.WriteLine();
            }
            //espera a interação com o usuario :)
            Console.ReadLine();
        }
    }
}
