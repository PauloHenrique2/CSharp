namespace CookiesCookbook.Acesso_de_dados;

public class StringsTextualRepository : StringsRepository
{
    private static readonly string separator = Environment.NewLine;

    protected override string StringsToTexto(List<string> strings)
    {
        return string.Join(separator, strings);
    }

    protected override List<string> TextoToStrings(string fileContents)
    {
        return fileContents.Split(separator).ToList();
    }
}
