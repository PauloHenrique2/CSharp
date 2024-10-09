using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aeroporto
{
    internal class passagem : voo /* Herança */
    {
        private int codigo { set; get; }

        private int numAssento { set; get; }

        private string cpfpassageiro { set; get; }

        private string nomepassageiro { set; get; }

        private double preco { set; get; }

        voo voo = new voo();

        public void constroipassagem(int numassento, double Preco)  /* Método contrutor */
        { 
         this.numAssento = numassento;
         this.preco = Preco;
        }

        public string exibirdados(int Codigo, int NumAssento, string Cpfpassageiro, string Nomepassageiro, double Preco)
        {
            this.codigo = Codigo;
            this.numAssento = NumAssento;
            this.cpfpassageiro = Cpfpassageiro;
            this.nomepassageiro = Nomepassageiro;
            this.preco = Preco;

            return "Código: " + Codigo + " Assento de nº: " + NumAssento + " Cpf do passageiro: " + Cpfpassageiro + " Nome do passageiro: " + Nomepassageiro + " Preço: " + Preco;
        }
    }
}
