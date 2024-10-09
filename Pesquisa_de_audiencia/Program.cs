using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa_de_audiencia
{
    internal class Pessoa
    {
        private int idade;
        private string sexo, estado_civil, radio_preferida;

        public Pessoa(int i, int s, int ec, int rp)
        {
            this.idade = i;

            if (s == 1) sexo = "Masculino";
            else if (s == 2) sexo = "Feminino";
            else sexo = "Outros";

            if (ec == 1) estado_civil = "Casado";
            else if (ec == 2) estado_civil = "Solteiro";
            else if (ec == 3) estado_civil = "Viúvo";
            else if (ec == 4) estado_civil = "Divorciado";
            else estado_civil = "Outros";

            if (rp == 1) radio_preferida = "BHfm";
            else if (rp == 2) radio_preferida = "98fm";
            else if (rp == 3) radio_preferida = "JovemPan";
            else if (rp == 4) radio_preferida = "Itatiaia";
            else if (rp == 5) radio_preferida = "CDL";
            else radio_preferida = "Outros";
        }

        public Pessoa()
        { }

        public string GetIdade() { return idade.ToString(); }

        public string GetSexo() { return sexo; }

        public string GetEstadoCivil() { return estado_civil; }

        public string GetRadioPreferida() { return radio_preferida; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração dos contadores

            int idade = 1;
            int sexo, estado_civil, radio_preferida, n;
            int soma = 0;
            double m = 0;
            double h = 0;
            double h21jp = 0;
            double mcBH = 0;
            double BHfm = 0;
            double noventaeoitofm = 0;
            double jovemPan = 0;
            double itatiaia = 0;
            double cdl = 0;
            double outraRadio = 0;

            //

            // Coleta dos dados

            Console.WriteLine("Quantas pessoas serão pesquisadas ?");
            n = Convert.ToInt32(Console.ReadLine());
            Pessoa[] pessoas = new Pessoa[n];


            for (int i = 0; (idade != 0) && (i < pessoas.Length); i++)
            {
                Console.WriteLine("Qual a idade da " + (i + 1) + "ª pessoa ?");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Sexo: (1 - Masculino, 2 - Feminino)");
                sexo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Estado civil: (1 - Casado, 2 - Solteiro, 3 - Viúvo, 4 - Divorciado)");
                estado_civil = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Rádio preferida: (1 - BHfm, 2 - 98fm, 3 - JovemPan, 4 - Itatiaia, 5 - CDL)");
                radio_preferida = Convert.ToInt32(Console.ReadLine());


                pessoas[i] = new Pessoa(idade, sexo, estado_civil, radio_preferida);

                if (sexo == 1) { h++; }
                else if (sexo == 2) { m++; }

                if (idade >= 21 && sexo == 1 && radio_preferida == 3)
                    h21jp++;

                if (sexo == 2 && estado_civil == 1 && radio_preferida == 1)
                    mcBH++;

                if (radio_preferida == 1)
                    BHfm++;
                else if (radio_preferida == 2)
                    noventaeoitofm++;
                else if (radio_preferida == 3)
                    jovemPan++;
                else if (radio_preferida == 4)
                    itatiaia++;
                else if (radio_preferida == 5)
                    cdl++;
                else
                    outraRadio++;
                soma += idade;
            }

            //

            Console.Clear();

            // Impressão dos dados

            Console.Write("Porcentagem de audiência de cada rádio: \n");
            Console.WriteLine("BHfm: " + ((BHfm / pessoas.Length) * 100) + "%" + "\n");
            Console.WriteLine("98fm: " + ((noventaeoitofm / pessoas.Length) * 100) +  "%" +  "\n");
            Console.WriteLine("JovemPan: " + ((jovemPan / pessoas.Length) * 100) + "%" + "\n");
            Console.WriteLine("Itatiaia: " + ((itatiaia / pessoas.Length) * 100) + "%" + "\n");
            Console.WriteLine("CDL: " + ((cdl / pessoas.Length) * 100) + "%" + "\n");
            Console.WriteLine("Outras: " + ((outraRadio / pessoas.Length) * 100) + "%");

            
            Console.Write("Nº de mulheres casadas que preferem BHfm: \n");
            Console.WriteLine(mcBH);

            
            Console.Write("Nº de homens maiores de 21 anos que preferem JovemPan: \n");
            Console.WriteLine(h21jp);

            
            Console.Write("Média das idades: \n");
            Console.WriteLine(soma / pessoas.Length);
            Console.WriteLine();

            
            Console.Write("Porcentagem de homens e mulheres (respectivamente): \n");
            Console.WriteLine(((h / pessoas.Length) * 100) + "%");
            Console.WriteLine(((m / pessoas.Length) * 100) + "%");

            //
            Console.ReadKey();
        }
    }
}