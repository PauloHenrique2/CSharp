using Projeto_Dado.ComunicacaoDoUsuario;
using Projeto_Dado.Jogo.Jogo;

namespace Projeto_Dado.Jogo
{
    public class Jogo_Dado
    {
        private readonly Dado _dado;
        private const int numero_tentativas = 3;

        public Jogo_Dado(Dado dado)
        {
            _dado = dado;
        }

        public enum ResultadoDoJogo
        {
            Vitoria,
            Derrota
        }

        public ResultadoDoJogo Jogar()
        {
            var resultado = _dado.Rolar();
            Console.WriteLine($"Dado jogado. Advinhe o número em {numero_tentativas} tentativas.");

            var tentativas_restantes = numero_tentativas;
            while (tentativas_restantes > 0)
            {
                var palpite = LeitorDeConsole.LerInteger("Enter a number");
                if (palpite == resultado)
                {
                    return ResultadoDoJogo.Vitoria;
                }

                Console.WriteLine("Número incorreto.");
                --tentativas_restantes;
            }
            return ResultadoDoJogo.Derrota;
        }

        public static void PrintResultado(ResultadoDoJogo resultado)
        {
            string mensagem = resultado == ResultadoDoJogo.Vitoria
                ? "Você venceu!"
                : "Você perdeu :(";

            Console.WriteLine(mensagem);
        }
    }
}
