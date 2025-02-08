using System.Text.Json;

namespace CookiesCookbook.Acesso_de_dados;

public class StringsJsonRepository : StringsRepository
{
    protected override string StringsToTexto(List<string> strings)
    {
        return JsonSerializer.Serialize(strings);
    }

    protected override List<string> TextoToStrings(string fileContents)
    {
        return JsonSerializer.Deserialize<List<string>>(fileContents);
    }
}
