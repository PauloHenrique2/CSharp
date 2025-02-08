namespace CookiesCookbook.Acesso_de_dados;

public abstract class StringsRepository : IStringsRepository
{
    public List<string> Read(string filePath)
    {
        if (File.Exists(filePath))
        {
            var fileContents = File.ReadAllText(filePath);
            return TextoToStrings(fileContents);
        }
        return new List<string>();
    }

    protected abstract List<string> TextoToStrings(string fileContents);

    public void Write(string filePath, List<string> strings)
    {
        File.WriteAllText(filePath, StringsToTexto(strings));
    }

    protected abstract string StringsToTexto(List<string> strings);
}
