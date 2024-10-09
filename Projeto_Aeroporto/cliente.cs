using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aeroporto
{
    internal class cliente
    {
        private int codigocli { set; get; }

        private string nomecli { set; get; }

        private string cpf { set; get; }

        private string endereco { set; get; }

        public void constroicliente(string nome)
        {
           this.nomecli = nome;
        }

        public string exibirDados(int Codigocli, string Nomecli, string Cpf, string Endereco)
        {
            this.codigocli = Codigocli;
            this.nomecli = Nomecli;
            this.cpf = Cpf;
            this.endereco = Endereco;

            return "Código: " + Codigocli + " Nome: " + Nomecli + " Cpf: " + Cpf + "\n Endereço: " + Endereco; 
        }
    }
}
