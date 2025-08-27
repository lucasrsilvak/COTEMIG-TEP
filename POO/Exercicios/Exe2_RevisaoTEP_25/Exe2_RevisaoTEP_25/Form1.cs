using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe2_RevisaoTEP_25
{
    public partial class frmQuestao2 : Form
    {
        public frmQuestao2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declaração de váriaveis
            double  valor = 0,
                    total = 0;
            int     qtd = 0;

            // Execução

            qtd     = int.Parse(txtQtd.Text);
            valor   = double.Parse(txtValor.Text);

            total = qtd * valor;

            if (qtd < 5)
            {
                total *= 0.98;
            }
            else if (qtd < 10)
            {
                total *= 0.97;
            }
            else if (qtd >= 10)
            {
                total *= 0.95;
            }

            lblResultado.Text = ("Valor a pagar: R$" + total.ToString("0.00"));
        }
    }
}
