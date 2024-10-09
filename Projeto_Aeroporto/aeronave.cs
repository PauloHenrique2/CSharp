using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aeroporto
{
    public class aeronave : empresa /* Herança */
    {
      private int codigo { set; get; }

      private string nome { set; get; }

      private int capacidade { set; get; }

      private int pesomaximo { set; get; }

      empresa emp = new empresa();

        public string exibirdados(int Codigo, string Nome, int Capacidade, int Pesomaximo)
        {
            this.codigo = Codigo;
            this.nome = Nome;
            this.capacidade = Capacidade;
            this.pesomaximo = Pesomaximo;

            return "Aeronave: " + " Código: " + Codigo + " Nome: " + Nome + " Capacidade: " + Capacidade + " Peso Máximo: " + Pesomaximo;
        }

      
    }
}
