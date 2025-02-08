using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookiesCookbook.Acesso_de_arquivos;

namespace CookiesCookbook.App
{
    public static class InteracaoUsuarioApp
    {
        public static FileFormat DefineFormato()
        {
            Console.WriteLine("Selecione o formato de arquivo desejado para a gravação de receitas: \n" +
                "0 - Json \n" +
                "1 - Txt");

            var deuCerto = int.TryParse(Console.ReadLine(), out var valor);

            if (valor == 0)
            {
                return FileFormat.Json;
            }

            else if (valor == 1)
            { 
                return FileFormat.Txt;
            }

            else
            {
                Console.WriteLine("Insira um valor válido!");
            }

            return default;
        }
    }
}
