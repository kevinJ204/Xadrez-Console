using System.Security.Cryptography.X509Certificates;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.xadrez;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez posicao = new PosicaoXadrez('c', 7);
            Console.WriteLine(posicao);
            Console.WriteLine(posicao.ToPosicao());
        }
    }
}