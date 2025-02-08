using CookiesCookbook.Receitas.Ingredientes;
using CookiesCookbook.Receitas;

namespace CookiesCookbook.App;

public class InteracoesConsoleUsuarioReceita : IInteracoesUsuarioReceitas
{
    private readonly IRegistroDeIngredientes _registroDeIngrediente;

    public InteracoesConsoleUsuarioReceita(IRegistroDeIngredientes registroDeIngredientes)
    {
        _registroDeIngrediente = registroDeIngredientes;
    }

    public void ImprimirTodasAsReceitas(IEnumerable<Receita> todasAsReceitas)
    {
        if (todasAsReceitas.Count() > 0)
        {
            Console.WriteLine("As receitas existentes são: " + Environment.NewLine);

            int aux = 1;
            foreach (var receita in todasAsReceitas)
            {
                Console.WriteLine($"*****{aux}*****");
                Console.WriteLine(receita);
                Console.WriteLine();
                ++aux;
            }
        }
    }

    public IEnumerable<Ingrediente> LerIngredientesDoUsuario()
    {
        bool terminou = false;
        var ingredientes = new List<Ingrediente>();

        do
        {
            MostrarMensagem("Adicione um ingrediente pelo seu ID ou digite qualquer coisa se tiver finalizado");
            var ing = Console.ReadLine();

            if (int.TryParse(ing, out int id))
            {
                var ingredienteSelecionado = _registroDeIngrediente.GetById(id);

                if (ingredienteSelecionado is not null)
                    ingredientes.Add(ingredienteSelecionado);
            }

            else
                terminou = true;
        }
        while (!terminou);

        return ingredientes;
    }

    public void MostrarMensagem(string msg)
    { Console.WriteLine(msg); }

    public void PromptParaCriarReceita()
    {
        Console.WriteLine("Crie uma nova receita de cookies!" +
            " Ingredientes disponíveis: ");

        foreach (var ingrediente in _registroDeIngrediente.TodosIngredientes)
            Console.WriteLine(ingrediente);
    }

    public void Sair()
    {
        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}
