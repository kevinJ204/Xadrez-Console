﻿using System.Security.Cryptography.X509Certificates;
using Xadrez_Console.tabuleiro;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(???, new Posicao(0, 0));

            Tela.ImprimirTabuleiro(tab);
        }
    }
}