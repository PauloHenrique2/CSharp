using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Classe_Professor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor p = new Professor("Pedro",38.23,20,17);
            Console.WriteLine(p.GetDados());
            Console.ReadKey();
        }
    }
}
