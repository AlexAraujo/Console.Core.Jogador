using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class Jogo
    {
        private readonly IJogador _jogador1;
        private readonly IJogador _jogador2;
        private readonly IJogador _jogador3;
        private readonly IJogador _jogador4;
        public Jogo(IJogador jogador1, IJogador jogador2, IJogador jogador3, IJogador jogador4)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
            _jogador3 = jogador3;
            _jogador4 = jogador4;
        }
        public void IniciarJogo()
        {
           Console.Write(_jogador1.Passe());
           Console.Write(_jogador1.Corre());
           Console.Write(_jogador1.Chuta());

           Console.Write($"\n Proximo jogador \n");

           Console.Write(_jogador2.Passe());
           Console.Write(_jogador2.Corre());
           Console.Write(_jogador2.Chuta());

           Console.Write($"\n Proximo jogador \n");
           
           Console.Write(_jogador3.Passe());
           Console.Write(_jogador3.Corre());
           Console.Write(_jogador3.Chuta());

           Console.Write($"\n Proximo jogador \n");
           
           Console.Write(_jogador4.Passe());
           Console.Write(_jogador4.Corre());
           Console.Write(_jogador4.Chuta());
        }
    }
}