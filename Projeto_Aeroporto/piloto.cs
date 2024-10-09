using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Projeto_Aeroporto
{
    internal class piloto
    {
        private int codigopi { set; get; }

        private string nomepi { set; get; }

        private string dataad { set; get; }

        public void constroipiloto(int Codigopi , string Nomepi, string Dataad) /* Método contrutor */
        {
            this.codigopi = Codigopi;
            this.nomepi = Nomepi;
            this.dataad = Dataad;
        }

        public void constroipiloto(string Nomepi) /* Método contrutor */
        {
            this.nomepi = Nomepi;
        }

        public string exibirdados(int Codigopi, string Nomepi, string Dataad)
        {
            this.codigopi = Codigopi;
            this.nomepi = Nomepi;
            this.dataad = Dataad;

            return "Código: " + Codigopi + " Nome: " + Nomepi + " Data de admissão: " + Dataad;
        }
    }
}
