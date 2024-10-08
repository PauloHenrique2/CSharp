using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenador_de_data
{
    internal class Data
    {
        private int dia, mes, ano;

        public Data(int d, int m, int a)
        { dia = d; mes = m; ano = a; }

        public int GetDia()
        { return dia; }

        public int GetMes()
        { return mes; }

        public int GetAno()
        { return ano; }

        public string GetData()
        { return dia + "/" + mes + "/" + ano; }

        public bool validaData()
        {
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0)) // Validação do ano bissexto
                dias[1]++;
            if (ano < 1900 || ano > 2099)
                return false;
            if (mes < 1 || mes > 12)
                return false;
            if (dia < 1 || dia > dias[mes - 1])
                return false;
            return true;
        }

        public string RetornaData()
        {
            if (validaData() == true)
            {
                return GetData();
            }
            return "Data inválida! Insira uma data entre 31/12/1899 e 01/01/2100";
        }
    }
}
