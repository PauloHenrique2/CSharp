using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Classe_Professor
{
    internal class Professor
    {
        private string nome;
        private double salHora;
        private int horasTrab, anosTrab;

        public Professor(string n, double sh, int ht, int at)
        {
            this.nome = n;
            this.salHora = sh;
            this.horasTrab = ht;
            this.anosTrab = at;
        }

        public string Getnome()
        {
            return this.nome;
        }

        public double GetSalBruto()
        {
            return (this.salHora * this.horasTrab * 4.5) + ((this.salHora * this.horasTrab * 4.5 ) * (this.anosTrab/5) * 0.05);
        }

        public string GetDados()
        {
            return $"Nome: {this.nome}\n Salário bruto: {GetSalBruto():C}";
        }
    }
}
