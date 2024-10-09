using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aeroporto
{
    public class empresa
    {
        private int codigoemp { set; get; }

        private string nomeemp { set; get; }

        public string exibirdados(int Codigo, string Nome)
        {
            this.codigoemp = Codigo;
            this.nomeemp = Nome;

            return "Empresa: " + " Código: " + Codigo + " Nome: " + Nome;
        }

    }
}
