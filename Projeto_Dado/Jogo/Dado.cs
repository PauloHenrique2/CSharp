using System.Threading.Channels;

namespace Projeto_Dado.Jogo.Jogo
{
    public class Dado
    {
        private readonly Random _random;
        private const int numero_de_lados = 6;

        public Dado(Random random)
        {
            _random = random;
        }

        public int Rolar() => _random.Next(1, numero_de_lados + 1);

        public void Descrever() => Console.WriteLine($"Este é um dado com {numero_de_lados} lados");
    }
}