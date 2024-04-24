using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vetor
{
    internal class Program
    {
        // Método para verificação dos elementos repetidos
        public static string TemRepetido(int[] vet)
        {
            for (int i = 0; i < vet.Length - 1; i++)
            {
                for (int j = i + 1; j < vet.Length; j++)
                { 
                    if (vet[i] == vet[j])
                     return "Elemento repetido encontrado!";
                }
            }
            return "Nenhum elemento repetido encontrado";
        }

        static void Main(string[] args)
        {
            int[] vet = new int[10];
            Random r = new Random();

            Console.WriteLine("Impressão do vetor: ");
            // Impressão e preenchimento do vetor com números aleatórios
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = r.Next(0,10);
                Console.Write(vet[i]);
            }
            Console.WriteLine();

            Console.Write("Verificação de elementos repetidos: ");
            // Verificação de elementos repetidos
            Console.WriteLine(TemRepetido(vet));

            Console.ReadKey();
        }
    }
}
