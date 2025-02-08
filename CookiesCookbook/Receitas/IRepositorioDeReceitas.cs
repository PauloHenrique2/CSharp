namespace CookiesCookbook.Receitas;

public interface IRepositorioDeReceitas
{
    void Escrever(string caminho, List<Receita> todasAsReceitas);
    List<Receita> Read(string caminho);
}
