namespace CookiesCookbook.Receitas.Ingredientes;

public interface IRegistroDeIngredientes
{
    IEnumerable<Ingrediente> TodosIngredientes { get; }

    Ingrediente GetById(int id);
}