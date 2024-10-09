using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto2
{
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }
         
        cliente cli = new cliente();
        passagem pas = new passagem();
        piloto pi = new piloto();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try /* Try | Catch */
            {
                if (txtNome.Text != " " && txtNomepi.Text != " " && txtAssento.Text != " " && txtValor.Text != " ")
                {
                    MessageBox.Show("Dados enviados com sucesso!");
                }
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            cli.constroicliente(nome);
            int numAssento = int.Parse(txtAssento.Text);
            float valorpas = float.Parse(txtValor.Text);
            pas.constroipassagem(numAssento, valorpas);
            string nomepi = txtNomepi.Text;
            pi.constroipiloto(nomepi);

            MessageBox.Show("O cliente " + nome + " com o Número do assento: " + numAssento + " viajou com o piloto: " + nomepi + " pagando: " + valorpas + " reais");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm3 abrirfrm3 = new Frm3();
            abrirfrm3.ShowDialog();
        }
    }
}
