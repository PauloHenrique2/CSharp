using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Matriz.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[6, 6];
            Random r = new Random();
            int soma = 0;
            double media = 0;

            /* Soma e média dos elementos acima da diagonal secundária */

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (j < mat.GetLength(1) - i)
                    {
                        mat[i, j] = r.Next(0, 10);
                        Console.Write(mat[i, j] + " ");
                        soma += mat[i, j];
                    }
                    media = soma / 21;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("A soma dos elementos acima da diagonal secundária é: " + soma + "\n");
            Console.Write("A média dos elementos acima da diagonal secundária é: " + media);

            Console.ReadKey();
        }
    }
}
