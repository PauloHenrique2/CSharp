namespace CookiesCookbook.Receitas.Ingredientes;

public class Chocolate : Ingrediente
{
    public override int Id => 4;
    public override string Nome => "Chocolate";
    public override string InstrucoesDePreparo =>
         $"Derreter em banho maria. {base.InstrucoesDePreparo}";
}
