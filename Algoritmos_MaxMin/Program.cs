using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] vetCres = new int[1000];
            int[] vetDecres = new int[1000];
            int[] vetAleat = new int[1000];
            Random r = new Random();
            MaxMin m = new MaxMin();

            for (int i = 0; i < vetCres.Length; i++)
            {
                vetCres[i] = i;
            }

            for (int i = 0; i < vetDecres.Length; i++)
            {
                vetDecres[i] = vetDecres.Length - i;
            }

            for (int i = 0; i < vetAleat.Length; i++)
            {
                vetAleat[i] = r.Next(0, 1000); 
            }
            Console.WriteLine("Contagem do vetor crescente: ");
            Console.WriteLine(m.MaxMin1(vetCres));
            Console.WriteLine(m.MaxMin2(vetCres));
            Console.WriteLine(m.MaxMin3(vetCres) + "\n");


            Console.WriteLine("Contagem do vetor decrescente: ");
            Console.WriteLine(m.MaxMin1(vetDecres));
            Console.WriteLine(m.MaxMin2(vetDecres));
            Console.WriteLine(m.MaxMin3(vetDecres) + "\n");


            Console.WriteLine("Contagem do vetor aleatório: ");
            Console.WriteLine(m.MaxMin1(vetAleat));
            Console.WriteLine(m.MaxMin2(vetAleat));
            Console.WriteLine(m.MaxMin3(vetAleat));

            Console.ReadKey();
        }
    }
}
