using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_4
{
    class MaxMin
    {
        // Operação relevante: Testes (if)

        // Complexidade: T(n) = 2n - 2
        public int MaxMin1(int[] vet)
        {
            int ma = 0;
            int me = 0;
            int cont = 0;
            ma = me = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                cont += 2;
                if (vet[i] < me)
                    me = vet[i];

                if (vet[i] > ma)
                    ma = vet[i];
            }
            return cont;
            
        }

        // Complexidade:
        // Melhor caso: T(n) = n - 1
        // Pior caso: T(n) = 2n - 2
        // Caso médio: T(n) = 3n/2 - 3/2
        public int MaxMin2(int[] vet)
        {
            int ma = 0;
            int me = 0;
            int cont = 0;
            ma = me = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                cont++;
                if (vet[i] < me)
                    me = vet[i];
                else
                {
                    cont++;
                    if (vet[i] > ma)
                        ma = vet[i];
                }
                    
                
            }
            return cont;
        }


        // Complexidade: T(n) = 3n/2 - 2
        public int MaxMin3(int[] vet)
        {
            int ma = 0;
            int me = 0;
            int cont = 0;
            cont++;
            if (vet[0] < vet[1])
            {
                me = vet[0];
                ma = vet[1];
            }
            else
            {
                me = vet[1];
                ma = vet[0];
            }
            for (int i = 2; i < vet.Length; i += 2)
            {
                cont ++;
                if (vet[i] < vet[i + 1])
                {
                    cont++;
                    if (vet[i] < me)
                        me = vet[i];
                    cont++;
                    if (vet[i + 1] > ma)
                        ma = vet[i + 1];
                }
                else
                {
                    cont++;
                    if (vet[i + 1] < me)
                        me = vet[i + 1];
                    cont++;
                    if (vet[i] > ma)
                        ma = vet[i];
                }
            }
            return cont;
        }
    }
}
