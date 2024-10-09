using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Aeroporto
{
    internal class compra
    {
        private int codigocompra { set; get; }

        passagem pas = new passagem();

        cliente cli = new cliente();

        private string pagamento { set; get; }

        private double valortotal { set; get; }
    }
}
