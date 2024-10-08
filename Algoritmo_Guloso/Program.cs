using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Guloso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var estados_abranger = new HashSet<string> { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
            var estacoes = new Dictionary<string, HashSet<string>>();

            estacoes.Add("kum", new HashSet<string> { "id", "nv", "ut" });
            estacoes.Add("kdois", new HashSet<string> { "wa", "id", "mt" });
            estacoes.Add("ktres", new HashSet<string> { "or", "nv", "ca" });
            estacoes.Add("kquatro", new HashSet<string> { "nv", "ut" });
            estacoes.Add("kcinco", new HashSet<string> { "ca", "az" });

            var estacoes_finais = new HashSet<string>();
            while (estados_abranger.Any())
            {
                string melhor_estacao = null;
                var estados_cobertos = new HashSet<string>();

                foreach (var estacao in estacoes)
                {
                    var cobertos = new HashSet<string>(estados_abranger.Intersect(estacao.Value));
                    if (cobertos.Count() > estados_cobertos.Count())
                    {
                        melhor_estacao = estacao.Key;
                        estados_cobertos = cobertos;
                    }
                }
                estados_abranger.RemoveWhere(s => estados_cobertos.Contains(s));
                estacoes_finais.Add(melhor_estacao);
            }
            Console.Write("Melhores estações: \n");
            Console.WriteLine(string.Join(", ", estacoes_finais));
            Console.ReadKey();
        }
    }
}
