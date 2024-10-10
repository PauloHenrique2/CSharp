using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Consulta_Medica
{
    internal class Impressora_Consulta_Medica
    {
        public void Imprimir(Consulta_Medica consulta)
        {
            Console.WriteLine($"A consulta do paciente {consulta.getNome_paciente()} está marcada para o dia: {consulta.getData_consulta()}");
        }
    }
}
