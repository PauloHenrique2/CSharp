using CookiesCookbook.Acesso_de_dados;
using CookiesCookbook.Receitas.Ingredientes;

namespace CookiesCookbook.Receitas;

public class RepositorioDeReceitas : IRepositorioDeReceitas
{
    private readonly IStringsRepository _stringsRepository;

    private readonly IRegistroDeIngredientes _registroDeIngredientes;

    private const string separador = ",";

    public RepositorioDeReceitas(IStringsRepository stringsRepository, IRegistroDeIngredientes registroDeIngredientes)
    {
        this._stringsRepository = stringsRepository;
        _registroDeIngredientes = registroDeIngredientes;
    }

    public void Escrever(string caminho, List<Receita> todasAsReceitas)
    {
        var receitasComoStrings = new List<string>();
        foreach (var receita in todasAsReceitas)
        {
            var todosIds = new List<int>();
            foreach (var ingrediente in receita.Ingredientes)
            {
                todosIds.Add(ingrediente.Id);
            }
            receitasComoStrings.Add(string.Join(separador, todosIds));
        }

        _stringsRepository.Write(caminho, receitasComoStrings);
    }

    public List<Receita> Read(string caminho)
    {
        List<string> receitasDoArquivo = _stringsRepository.Read(caminho);
        var receitas = new List<Receita>();

        foreach (var receitaDoArquivo in receitasDoArquivo)
        {
            var receita = ReceitaDaString(receitaDoArquivo);
            receitas.Add(receita);
        }

        return receitas;

    }

    private Receita ReceitaDaString(string receitaDoArquivo)
    {
        var idsTextuais = receitaDoArquivo.Split(separador);
        var ingredientes = new List<Ingrediente>();

        foreach (var idTextual in idsTextuais)
        {
            var id = int.Parse(idTextual);
            var ingrediente = _registroDeIngredientes.GetById(id);
            ingredientes.Add(ingrediente);
        }

        return new Receita(ingredientes);
    }
}
