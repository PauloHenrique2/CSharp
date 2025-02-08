namespace CookiesCookbook.Acesso_de_arquivos;

public static class ExtensoesFileFormat
{
    public static string AsExtensaoDeArquivo(this FileFormat formatoDoArquivo) =>
        formatoDoArquivo == FileFormat.Json ? "json" : "txt";
}
