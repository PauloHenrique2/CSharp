using CookiesCookbook.Receitas.Ingredientes;
using CookiesCookbook.Receitas;

namespace CookiesCookbook.App;

public interface IInteracoesUsuarioReceitas
{
    void ImprimirTodasAsReceitas(IEnumerable<Receita> todasAsReceitas);
    IEnumerable<Ingrediente> LerIngredientesDoUsuario();
    void MostrarMensagem(string msg);
    void PromptParaCriarReceita();
    void Sair();
}
