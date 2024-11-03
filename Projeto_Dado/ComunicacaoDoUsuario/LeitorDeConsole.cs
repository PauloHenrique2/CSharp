using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Dado.ComunicacaoDoUsuario
{
    public static class LeitorDeConsole
    {
        public static int LerInteger(string mensagem)
        {
            int resultado;
            do
            {
                Console.WriteLine(mensagem);
            }
            while (!int.TryParse(Console.ReadLine(), out resultado));
            return resultado;
        }
    }
}