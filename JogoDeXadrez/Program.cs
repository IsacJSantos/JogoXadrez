using System;
using tabuleiro;

namespace JogoDeXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(3, 4);

            Console.WriteLine("Posicao: " + p);

            Console.ReadLine();
        }
    }
}
