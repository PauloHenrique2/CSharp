namespace CookiesCookbook.Receitas.Ingredientes;

public class RegistroDeIngredientes : IRegistroDeIngredientes
{
    public IEnumerable<Ingrediente> TodosIngredientes { get; } = new List<Ingrediente>
{
 new FarinhaDeTrigo(),
 new FarinhaDeEspelta(),
 new Manteiga(),
 new Chocolate(),
 new Acucar(),
 new Cardamomo(),
 new Canela(),
 new CacauEmPo()
};

    public Ingrediente GetById(int id)
    {
        foreach (var ingrediente in TodosIngredientes)
        {
            if (ingrediente.Id == id)
                return ingrediente;
        }
        return null;
    }
}