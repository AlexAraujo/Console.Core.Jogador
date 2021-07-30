using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        public string Passe()
        {
            return $"Ronaldinho esta passando \n";
        }
        public string Corre()
        {
            return $"Ronaldinho esta correndo \n";
        }
        public string Chuta()
        {
            return $"Ronaldinho esta chutando \n";
        }
    }
}