using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe1_RevisaoTEP_25
{
    public partial class frmQuestao1 : Form
    {
        public frmQuestao1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string  senha = "",
                    saida = "";

            // Execução
            senha = txtSenha.Text;

            if (senha == "1234")
            {
                saida = "Acesso aprovado!";
            }
            else
            {
                saida = "Acesso negado!";
            }

            // Saída
            lblResultado.Text = saida;
        }
    }
}
