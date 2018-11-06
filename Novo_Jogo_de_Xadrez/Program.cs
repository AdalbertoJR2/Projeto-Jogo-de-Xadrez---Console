using System;
using tabuleiro;
using xadrez;

namespace Novo_Jogo_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(0, 0));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();

        }
    }
}
