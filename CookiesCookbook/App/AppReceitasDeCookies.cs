using CookiesCookbook.Receitas;

namespace CookiesCookbook.App;

public class AppReceitasDeCookies
{
    private readonly IRepositorioDeReceitas _repositorioDeReceitas; 
    private readonly IInteracoesUsuarioReceitas _interacoesUsuarioReceitas; // Inversão de dependência

    public AppReceitasDeCookies(
        IRepositorioDeReceitas repositorioDeReceitas, 
        IInteracoesUsuarioReceitas interacoesUsuarioReceitas) // Injeção de dependência
    {
        _repositorioDeReceitas = repositorioDeReceitas;
        _interacoesUsuarioReceitas = interacoesUsuarioReceitas;
    }

    public void Executar(string caminho)
    {
        var TodasAsReceitas = _repositorioDeReceitas.Read(caminho);
        _interacoesUsuarioReceitas.ImprimirTodasAsReceitas(TodasAsReceitas);

        _interacoesUsuarioReceitas.PromptParaCriarReceita();

        var ingredientes = _interacoesUsuarioReceitas.LerIngredientesDoUsuario();

        if (ingredientes.Count() > 0)
        {
            var receita = new Receita(ingredientes);
            TodasAsReceitas.Add(receita);
            _repositorioDeReceitas.Escrever(caminho, TodasAsReceitas);

            _interacoesUsuarioReceitas.MostrarMensagem("Receita adicionada: ");
            _interacoesUsuarioReceitas.MostrarMensagem(receita.ToString());
        }

        else
        {
            _interacoesUsuarioReceitas.MostrarMensagem("Nenhum ingrediente foi selecionado." +
                "A receita não será salva.");
        }

        _interacoesUsuarioReceitas.Sair();
    }
}
