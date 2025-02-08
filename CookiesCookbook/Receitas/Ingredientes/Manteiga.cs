namespace CookiesCookbook.Receitas.Ingredientes;

public class Manteiga : Ingrediente
{
    public override int Id => 3;
    public override string Nome => "Manteiga";
    public override string InstrucoesDePreparo =>
         $"Derreter em fogo baixo. {base.InstrucoesDePreparo}";
}
