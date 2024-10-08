using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenador_de_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data(1, 1, 2100);
            Console.WriteLine(d.RetornaData());
            Console.ReadKey();
        }
    }
}
