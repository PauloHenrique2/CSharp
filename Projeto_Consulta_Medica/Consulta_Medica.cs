using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Consulta_Medica
{
    internal class Consulta_Medica
    {
        private string nome_paciente;
        private DateTime data_consulta;

        public Consulta_Medica(string nome_paciente, DateTime data_consulta)
        {
            this.nome_paciente = nome_paciente;
            this.data_consulta = data_consulta;
        }

        public Consulta_Medica(string nome)
        {
            this.nome_paciente = nome;
        }

        public Consulta_Medica(string nome, int dias = 7)
        {
            this.nome_paciente = nome;
            this.data_consulta = DateTime.Now.AddDays(dias);
        }

        public string getNome_paciente() => this.nome_paciente;
        

        public void setNome_paciente(String nome) => this.nome_paciente = nome;
                

        public string getData_consulta() => this.data_consulta.ToString();
        

        public void setData_consulta(DateTime data) => this.data_consulta = data;
        

        public void Reagendar(DateTime data)
        {
            this.data_consulta = data;
            var impressora = new Impressora_Consulta_Medica();
            impressora.Imprimir(this);
        }

        public void SobrescreverMeseDia(int mes, int dia) => this.data_consulta = new DateTime(data_consulta.Year, mes, dia);
        

        public void AdicionarMeseseDias(int meses, int dias)
         => this.data_consulta = new DateTime(data_consulta.Year, data_consulta.Month + meses, data_consulta.Day + dias);
    }
}
