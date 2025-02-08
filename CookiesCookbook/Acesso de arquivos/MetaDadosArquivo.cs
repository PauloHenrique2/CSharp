namespace CookiesCookbook.Acesso_de_arquivos;

public class MetaDadosArquivo
{
    public string Nome { get; }

    public FileFormat Formato { get; }

    public MetaDadosArquivo(string nome, FileFormat formato)
    {
        this.Nome = nome;
        Formato = formato;
    }

    public string ToCaminho() => $"{this.Nome}.{Formato.AsExtensaoDeArquivo()}";
}
