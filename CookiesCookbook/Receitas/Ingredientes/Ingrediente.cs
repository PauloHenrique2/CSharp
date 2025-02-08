namespace CookiesCookbook.Receitas.Ingredientes;

public abstract class Ingrediente
{
    public abstract int Id { get; }
    public abstract string Nome { get; }
    public virtual string InstrucoesDePreparo =>
        "Adicione aos outros ingredientes.";


    public override string ToString() =>
        $"{Id}. {Nome}";
    
}