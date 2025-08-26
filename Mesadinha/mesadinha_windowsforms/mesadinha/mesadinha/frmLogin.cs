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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login Logou = new Login();
            if (Logou.Validate(txt_email.Text, txt_password.Text))
            {
                this.Hide();

                frm_Dashboard Dashboard = new frm_Dashboard();
                Dashboard.ShowDialog();

                txt_email.Clear();
                txt_password.Clear();
            }
            else
            {
                MessageBox.Show("E-mail ou senha inválidos", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_register Register = new frm_register();
            Register.ShowDialog();
            
        }
    }
}
