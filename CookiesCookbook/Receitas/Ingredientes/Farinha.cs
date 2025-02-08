namespace CookiesCookbook.Receitas.Ingredientes;

public abstract class Farinha : Ingrediente
{
    public override string InstrucoesDePreparo =>
        $"Peneirar. {base.InstrucoesDePreparo}";
}
