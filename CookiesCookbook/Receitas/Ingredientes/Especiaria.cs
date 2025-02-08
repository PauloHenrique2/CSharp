namespace CookiesCookbook.Receitas.Ingredientes;

public abstract class Especiaria : Ingrediente
{
    public override string InstrucoesDePreparo =>
           $"Pegar meia colher de chá. {base.InstrucoesDePreparo}";
}
