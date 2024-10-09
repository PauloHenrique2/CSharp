using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aeroporto
{
    public class voo : aeroporto /* Herança */
    {
        private int codigovoo { set; get; }
        private string dataHora { set; get; }

        aeroporto ap = new aeroporto();

        aeroporto ap2 = new aeroporto();

        piloto pi = new piloto();

        aeronave aero = new aeronave();

        public void constroivoo(int cod, string dataH) /* Método contrutor */
        {
            this.codigovoo = cod;
            this.dataHora = dataH;
        }

        public string exibirdados(int cod, string dataH)
        {
            this.codigovoo = cod;
            this.dataHora = dataH;

            return "Código: " + cod + " Data e hora: " + dataH;
        }
    }  
}
