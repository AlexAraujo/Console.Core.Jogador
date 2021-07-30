using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador4 : IJogador
    {
        public string Chuta()
        {
            return $"Kaka esta Chutando";
        }

        public string Corre()
        {
            return $"Kaka esta correndo";
        }

        public string Passe()
        {
            return $"Kaka esta passando";
        }
    }
}