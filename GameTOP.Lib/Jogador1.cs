using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome;
        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }
        public string Passe()
        {
            return $"{_Nome} esta passando \n";
        }
        public string Corre()
        {
            return $"{_Nome} esta correndo \n";
        }
        public string Chuta()
        {
            return $"{_Nome} esta chutando \n";
        }
    }
}