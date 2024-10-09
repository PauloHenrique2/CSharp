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
    public partial class Frm3 : Form
    {
        public Frm3()
        {
            InitializeComponent();
        }

        aeroporto aero = new aeroporto();
        empresa emp = new empresa();
        aeronave an = new aeronave();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try  /* Try | Catch */
            {
                if (txtCodigoaero.Text != " " && txtNomeaero.Text != " " && txtCidade.Text != " " && txtEstado.Text != " " && txtPais.Text != " "
                    && txtCodigoemp.Text != " " && txtNomeemp.Text != " "
                    && txtCodigoan.Text != " " && txtNomean.Text != " " && txtCapacidade.Text != " " && txtPesomax.Text != " ")
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

        private void btnExibir_Click(object sender, EventArgs e)
        {
            int codigoaero = int.Parse(txtCodigoaero.Text);
            string nomeaero = txtNomeaero.Text;
            string cidade = txtCidade.Text;
            string estado = txtEstado.Text;
            string pais = txtPais.Text;

            lblRaero.Text = aero.exibirdados(codigoaero, nomeaero, cidade, estado, pais);

            int codigoemp = int.Parse(txtCodigoemp.Text);
            string nomeemp = txtNomeemp.Text;

            lblRemp.Text = emp.exibirdados(codigoemp, nomeemp);

            int codigoan = int.Parse(txtCodigoan.Text);
            string nomean = txtNomean.Text;
            int capacidade = int.Parse(txtCapacidade.Text);
            int pesoMaximo = int.Parse(txtPesomax.Text);

            lblRan.Text = an.exibirdados(codigoan, nomean, capacidade, pesoMaximo);
        }
    }
}
