using CookiesCookbook;
using CookiesCookbook.Acesso_de_arquivos;
using CookiesCookbook.Acesso_de_dados;
using CookiesCookbook.App;
using CookiesCookbook.Receitas;
using CookiesCookbook.Receitas.Ingredientes;

FileFormat formato = InteracaoUsuarioApp.DefineFormato();

IStringsRepository stringsRepository = formato == FileFormat.Json ? 
    new StringsJsonRepository() : new StringsTextualRepository();

const string nomeDoArquivo = "receitas";
var MetaDadosArquivo = new MetaDadosArquivo(nomeDoArquivo, formato);

var registroDeIngredientes = new RegistroDeIngredientes();

var appReceitasDeCookie = new AppReceitasDeCookies(
    new RepositorioDeReceitas(new StringsJsonRepository(),
    registroDeIngredientes),
    new InteracoesConsoleUsuarioReceita(
        registroDeIngredientes));

appReceitasDeCookie.Executar(MetaDadosArquivo.ToCaminho());
