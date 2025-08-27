using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe3_RevisaoTEP_25
{
    public partial class frmQuestao3 : Form
    {
        double saldo = 0;
        public frmQuestao3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            saldo += double.Parse(txtValor.Text);
            lblSaldo.Text = ("Saldo: R$" + saldo.ToString("0.00"));
        }

        private void btnRetirada_Click(object sender, EventArgs e)
        {
            saldo -= double.Parse(txtValor.Text);
            lblSaldo.Text = ("Saldo: R$" + saldo.ToString("0.00"));
        }
    }
}
