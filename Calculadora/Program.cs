using ExemploPilha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha(100);
            string variavel = "";
            
            while (true)
            {
                Console.WriteLine("Insira um número ou operador: (digite 's' para sair)");
                variavel = Console.ReadLine();

                if (variavel == "+")
                {
                    if (p.Vazia() == true) { Console.WriteLine("Pilha vazia!");}

                    int num1 = p.Desempilhar();

                    if (p.Vazia() == true) { Console.WriteLine("Pilha vazia!"); }

                    int num2 = p.Desempilhar();
                    int soma = num1 + num2;
                    p.Empilhar(soma);
                    Console.WriteLine(soma);
                }

                else if (variavel == "-")
                {
                    if (p.Vazia() == true) { Console.WriteLine("Pilha vazia!"); }

                    int num1 = p.Desempilhar();

                    if (p.Vazia() == true) { Console.WriteLine("Pilha vazia!"); }

                    int num2 = p.Desempilhar();
                    int subtracao = num2 - num1;
                    p.Empilhar(subtracao);
                    Console.WriteLine(subtracao);
                }

                else if (variavel == "/")
                {
                    if (p.Vazia() == true) { Console.WriteLine("Pilha vazia!"); }

                    int num1 = p.Desempilhar();

                    if (p.Vazia() == true) { Console.WriteLine("Pilha vazia!"); }

                    int num2 = p.Desempilhar();
                    int divisao = num2 / num1;
                    p.Empilhar(divisao);
                    Console.WriteLine(divisao);
                }

                else if (variavel == "*")
                {
                    if (p.Vazia() == true) { Console.WriteLine("Pilha vazia!"); }

                    int num1 = p.Desempilhar();

                    if (p.Vazia() == true) { Console.WriteLine("Pilha vazia!"); }
                    
                    int num2 = p.Desempilhar();
                    int multiplicao = num1 * num2;
                    p.Empilhar(multiplicao);
                    Console.WriteLine(multiplicao);
                }

                else if (variavel == "s" || variavel == "S")
                {
                    Environment.Exit(0);
                }

                else
                {
                    p.Empilhar(int.Parse(variavel));
                }
            }
        }
    }
}
