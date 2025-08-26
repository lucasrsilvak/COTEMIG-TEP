using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mesadinha
{
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
        }

        string sql;
        ConexaoBD conexao = new ConexaoBD();

        private void frm_register_Load(object sender, EventArgs e)
        {

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login Login = new frm_login();
            Login.ShowDialog();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            sql = string.Format("select * from usuario where email = '{0}'", txt_email.Text);
            DataTable resultado = conexao.ConsultarTabela(sql);

           if (resultado.Rows.Count == 0)
            {
                sql = string.Format("insert into usuario values (null, '{0}', '{1}', '{2}', '{3}', '{4}', null, null, null)", txt_name.Text, txt_email.Text, txt_address.Text, txt_telephone.Text, txt_password.Text);

                conexao.AlterarTabela(sql);

                this.Hide();

                MessageBox.Show("Cadastro realizado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_login Login = new frm_login();
                Login.ShowDialog();

                txt_address.Clear();
                txt_email.Clear();
                txt_name.Clear();
                txt_password.Clear();
                txt_telephone.Clear();
            } 
            else
            {
                MessageBox.Show("E-mail já cadastrado", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Clear();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
