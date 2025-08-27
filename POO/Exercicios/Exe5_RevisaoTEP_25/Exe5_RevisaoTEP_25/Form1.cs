using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe5_RevisaoTEP_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            int a1, a2, a3;

            a1 = int.Parse(txtAngulo1.Text);
            a2 = int.Parse(txtAngulo2.Text);
            a3 = int.Parse(txtAngulo3.Text);

            if (a1 > 90 || a2 > 90 || a3 > 90)
            {
                lblResultado.Text = "Obtusângulo";
            } else if (a1 == 90 || a2 == 90 || a3 == 90)
            {
                lblResultado.Text = "Retângulo";
            } else
            {
                lblResultado.Text = "Acutângulo";
            }
        }
    }
}
