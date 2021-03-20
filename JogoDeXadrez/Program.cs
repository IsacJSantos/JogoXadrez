using System;
using tabuleiro;
using xadrez;

namespace JogoDeXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez p = new PosicaoXadrez('c', 7);
            Console.WriteLine(p);
            Console.WriteLine(p.toPosicao());         
        }
    }
}
