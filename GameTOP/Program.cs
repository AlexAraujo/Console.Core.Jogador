using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo(
                new Jogador1(),
                new Jogador2(),
                new Jogador3(),
                new Jogador4()
            );

            jogo.IniciarJogo();
        }
    }
}
