using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aeroporto
{
    public class aeroporto
    {
        private int codigo { set; get; }
        private string nome { set; get; }
        private string cidade { set; get; }
        private string estado { set; get; }
        private string pais { set; get; }

        public string exibirdados(int Codigo, string Nome, string Cidade, string Estado, string Pais)
        {
            this.codigo = Codigo;
            this.nome = Nome;
            this.cidade = Cidade;
            this.estado = Estado;
            this.pais = Pais;

            return "Aeroporto: " + " Código: " + Codigo + " Nome: " + Nome + " Cidade: " + Cidade + " Estado: " + Estado + " País: " + Pais;
        }
    }
}
