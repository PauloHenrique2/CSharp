using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Classe Pilha - Implementa o tipo abstrato de dados pilha estática
 * Operações: 
 * Vazia() -> retorna true se a pilha está vazia.
 * Cheia() -> returna true se a pilha está cheia.
 * Empilhar(x) -> coloca o elemento x no topo da pilha.
 * Desempilhar() -> retorna o elemento situado no topo da pilha.
 */

namespace Calculadora
{
    class Pilha
    {
        private int[] vet; // Vetor para armazenar os elementos da pilha
        private int topo; // Indica a posição do topo

        public Pilha(int tam) // Construtor
        { 
            vet = new int[tam];
            topo = 0;
        }

        public void Empilhar(int x)
        {
            vet[topo] = x;
            topo++;
        }

        public int Desempilhar()
        {
            topo--;
            return (vet[topo]);
        }

        public bool Vazia()
        {
            return (topo == 0);
        }

        public bool Cheia()
        {
            return (topo == vet.Length);
        }
    }
}
