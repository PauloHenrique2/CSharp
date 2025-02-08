namespace CookiesCookbook.Acesso_de_dados;

public interface IStringsRepository
{
    List<string> Read(string filePath);
    void Write(string filePath, List<string> strings);
}
