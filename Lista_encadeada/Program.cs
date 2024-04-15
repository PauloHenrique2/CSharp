using Pratica2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_encadeada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int c;

            Console.Write("Digite um nº (-1 para sair): ");
            c = Convert.ToInt32(Console.ReadLine());

            while (c != -1)
            {
                l.Inserir(new NoLista(c));
                Console.Write("Digite outro nº (-1 para sair): ");
                c = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Digite um nº a ser pesquisado: ");
            c = Convert.ToInt32(Console.ReadLine());

            NoLista n = l.Pesquisar(c);
            if (n == null)
                Console.WriteLine("Valor não encontrado!");
            else
                Console.WriteLine("Achou: " + n.chave);

            l.Imprimir();
            Console.WriteLine();
            Console.WriteLine(l.GetLenght());
            Console.WriteLine();
            Console.WriteLine(l.GetMediaChaves());
            Console.WriteLine();
            Console.WriteLine(l.GetNo(2));
            Console.WriteLine();
            Console.WriteLine(l.GetMaiorNo());
            Console.WriteLine();

            Fila f = new Fila(5);
            f.Enfileirar(10);
            f.Enfileirar(20);
            f.Enfileirar(30);
            f.Enfileirar(40);
            f.Enfileirar(50);

            l.AddItens(f);
            l.Imprimir();
            Console.ReadKey();
        }
    }
}
