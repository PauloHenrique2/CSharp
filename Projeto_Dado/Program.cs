using Projeto_Dado.Jogo;
using Projeto_Dado.Jogo.Jogo;

Random r = new Random();
Dado dado = new Dado(r);
Jogo_Dado jogo = new Jogo_Dado(dado);

Jogo_Dado.ResultadoDoJogo resultadoDoJogo = jogo.Jogar();
Jogo_Dado.PrintResultado(resultadoDoJogo);

Console.ReadKey();