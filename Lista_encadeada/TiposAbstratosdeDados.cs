using Pratica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_encadeada
{
    class NoLista
    {
        public int chave;
        public NoLista prox;
        public NoLista(int c)
        {
            chave = c;
            prox = null;
        }
    }

    class Lista
    {
        private NoLista prim, ult;

        public Lista()
        {
            prim = ult = null;
        }

        public void Inserir(NoLista item)
        {
            if (prim == null)
                prim = item;
            else
                ult.prox = item;
            ult = item;
        }

        public void Imprimir()
        {
            NoLista aux = prim;
            while (aux != null)
            {
                Console.WriteLine(aux.chave);
                aux = aux.prox;
            }
        }

        public NoLista Pesquisar(int c)
        {
            NoLista aux = prim;
            while (aux != null && aux.chave != c)
            {
                aux = aux.prox;
            }
            return aux;
        }

        public bool Remover(int c)
        {
            NoLista aux = prim, ant = null;
            while (aux != null && aux.chave != c)
            {
                ant = aux;
                aux = aux.prox;
            }
            if (aux != null)
            {
                if (ant != null) // não é o primeiro 
                    ant.prox = aux.prox;
                else // é o primeiro
                    prim = aux.prox;
                if (aux == ult) // é o último
                    ult = ant;
                aux.prox = null; // desconecta o nó da lista
                return true;
            }
            return false;
        }

        public double GetMediaChaves()
        {
            if (prim != ult)
            {
                NoLista aux = prim;
                int cont = 0;
                int soma = 0;

                while (aux != null)
                {
                    soma += aux.chave;
                    aux = aux.prox;
                    cont++;
                }
                return soma / cont;
            }
            return 0;
        }

        public int GetLenght()
        {
            if (prim != ult)
            {
                NoLista aux = prim;
                int cont = 0;

                while (aux != null)
                {
                    aux = aux.prox;
                    cont++;
                }
                return cont;
            }
            return 1;
        }

        public NoLista GetNo(int i)
        {
            NoLista aux = prim;

            while (aux != null)
            {
                if (i == aux.chave)
                { return aux; }
                aux = aux.prox;
            }
            return null;
        }

        public NoLista GetMaiorNo()
        {
            NoLista aux = prim;
            NoLista ant = null;

            while (aux != null)
            {
                ant = aux;
                aux = aux.prox;
                if (aux.chave > ant.chave)
                    return aux;
            }
            return null;
        }

        public void AddItens(Fila f )
        {
            while (f.Vazia() != true)
            {
                NoLista item = new NoLista(f.Desenfileirar());
                Inserir(item);
            }
        }
    }
}