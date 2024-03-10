using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linhas, l, i;

            Console.Write("Digite o nº de linhas: ");
            linhas = Int32.Parse(Console.ReadLine());

            for (l = 0; l < linhas; l++)  // Contagem das Linhas
            {
                for (i = 0; i < linhas - l - 1; i++)  // Geração dos Espaços
                {
                    Console.Write(" ");
                }

                for (i = 0; i < 2 * l + 1; i++)  // Geração dos Asteriscos
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}