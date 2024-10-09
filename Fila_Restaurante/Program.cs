using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila ped = new Fila(100);
            Fila pag = new Fila(100);
            Fila enc = new Fila(100);
            string variavel = "";
            int cont = 0;
            int resultado;

            while (true)
            {
                Console.WriteLine("Escolha uma opção:" +
                "\n1 - Inserção de clientes na fila de pedidos" +
                "\n2 - Remoção de clientes da fila de pedidos" +
                "\n3 - Remoção de clientes da fila de pagamentos" +
                "\n4 - Remoção de clientes da fila de encomendas" + 
                "\n5 - Sair");
                variavel = Console.ReadLine();

                if (variavel == "1")
                {
                    cont++;
                    ped.Enfileirar(cont);
                }

                else if (variavel == "2" && ped.Vazia() != true)
                {
                    resultado = ped.Desenfileirar();
                    pag.Enfileirar(resultado);
                    Console.WriteLine("Cliente " + resultado + " foi removido da fila de pedidos e entrou na de pagamentos");
                    resultado = 0;
                }

                else if (variavel == "3" && pag.Vazia() != true)
                {
                    resultado = pag.Desenfileirar();
                    enc.Enfileirar(resultado);
                    Console.WriteLine("Cliente " + resultado + " foi removido da fila de pagamentos e entrou na de encomendas");
                    resultado = 0;
                }

                else if (variavel == "4" && enc.Vazia() != true)
                {
                    resultado = enc.Desenfileirar();
                    Console.WriteLine("Cliente " + resultado + " foi removido da fila de encomendas e saiu da loja");
                    resultado = 0;
                }

                else if (variavel == "5")
                {
                   Environment.Exit(0);
                }
            }
        }
    }
}