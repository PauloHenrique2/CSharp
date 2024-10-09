using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_3
{
    internal class Program{

        static void Main(string[] args){

            Lista l = new Lista();
            string nome;
            string variavel;
            int c = 0;

            while (true){
                Console.WriteLine
                ("Escolha uma opção:" +
                "\n 1 - Inserir" +
                "\n 2 - Pesquisar" +
                "\n 3 - Imprimir Lista" +
                "\n 4 - Sair");

                variavel = Console.ReadLine();

                if (int.Parse(variavel) == 1){

                    while (true){
                        Console.Write("Digite um nº (-1 para sair): ");
                        c = Convert.ToInt32(Console.ReadLine());

                        if (c == -1)
                            break;

                        Console.Write("Agora digite um nome para essa chave (-1 para sair): ");
                        nome = Console.ReadLine();

                    
                        if (l.Pesquisar(c) == null && nome != null){
                            NoLista no = new NoLista(c, nome);
                            l.Inserir(no);
                        }

                        else 
                            Console.WriteLine("Erro! Chave inserida já resistrada!");
                    }
                }

                else if (int.Parse(variavel) == 2){
                    Console.Write("Digite um nº a ser pesquisado: ");
                    c = Convert.ToInt32(Console.ReadLine());

                    NoLista n = l.Pesquisar(c);
                    if (n == null)
                        Console.WriteLine("Valor não encontrado!");

                    else
                        Console.WriteLine("Achou: " + n.nome);

                    Console.WriteLine("Deseja remover o nó pesquisado ? (digite 's' para remover)");
                    string resp = Console.ReadLine();

                    if (resp == "s")
                        l.Remover(n.chave);
                }

                else if (int.Parse(variavel) == 3)
                    l.Imprimir();


                else if (int.Parse(variavel) == 4)
                    Environment.Exit(0);

                Console.ReadKey();
            }
        }
    }
}
