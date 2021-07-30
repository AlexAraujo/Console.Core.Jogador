using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : IJogador
    {
        public string Passe()
        {
            return $"Messi esta passando \n";
        }
        public string Corre()
        {
            return $"Messi esta correndo \n";
        }
        public string Chuta()
        {
            return $"Messi esta chutando \n";
        }
    }
}