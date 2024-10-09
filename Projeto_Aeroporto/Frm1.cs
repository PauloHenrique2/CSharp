using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Aeroporto
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }


        cliente cli = new cliente();
        voo voo = new voo();
        piloto pi = new piloto();
        passagem pas = new passagem();

        private void btnFrm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm2 abrirfrm2 = new Frm2();
            abrirfrm2.ShowDialog();
        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            try  /* Try | Catch */
            {
                if (txtCodigo.Text != " " && txtNome.Text != " " && txtCpf.Text != " " && txtEnd.Text != " ")
                {
                    MessageBox.Show("Dados enviados com sucesso!");
                }
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Formato dos dados incorreto: " + ex);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void btnExibir2_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nome = txtNome.Text;
            cli.constroicliente(nome);
            string cpf = txtCpf.Text;
            string endereco = txtEnd.Text;

            MessageBox.Show(cli.exibirDados(codigo, nome, cpf, endereco));
        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            try  /* Try | Catch */
            {
                if (txtCodvoo.Text != " " && txtDatahora.Text != " ")
                {
                    MessageBox.Show("Dados enviados com sucesso!");
                }
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Formato dos dados incorreto: " + ex);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void btnExibir2_Click_1(object sender, EventArgs e)
        {
            int codigovoo = int.Parse(txtCodvoo.Text);
            string dataHora = txtDatahora.Text;
            voo.constroivoo(codigovoo, dataHora);

            MessageBox.Show(voo.exibirdados(codigovoo, dataHora));
        }

        private void btnEnviar3_Click(object sender, EventArgs e)
        {
            try  /* Try | Catch */
            {
                if (txtCodigopi.Text != " " && txtNomepi.Text != " " && txtDataad.Text != " ")
                {
                    MessageBox.Show("Dados enviados com sucesso!");
                }
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Formato dos dados incorreto: " + ex);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void btnExibir3_Click(object sender, EventArgs e)
        {
            int codigopi = int.Parse(txtCodigopi.Text);
            string nomepi = txtNomepi.Text;
            string dataad = txtDataad.Text;
            pi.constroipiloto(codigopi, nomepi, dataad);

            MessageBox.Show(pi.exibirdados(codigopi, nomepi, dataad));
        }

        private void btnEnviar4_Click(object sender, EventArgs e)
        {
            try  /* Try | Catch */
            {
                if (txtCodigop.Text != " " && txtAssento.Text != " " && txtCpfp.Text != " " && txtNomep.Text != " " && txtPreco.Text != " ")
                {
                    MessageBox.Show("Dados enviados com sucesso!");
                }
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Formato dos dados incorreto: " + ex);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void btnExibir4_Click(object sender, EventArgs e)
        {
            int codigop = int.Parse(txtCodigop.Text);
            int numassento  = int.Parse(txtAssento.Text);
            string cpfp = txtCpfp.Text;
            string nomep = txtNomep.Text;
            double preco = double.Parse(txtPreco.Text);
            
            MessageBox.Show(pas.exibirdados(codigop, numassento, cpfp, nomep, preco));
        }
    }
}
