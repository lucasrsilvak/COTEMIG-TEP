using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe4_RevisaoTEP_25
{
    public partial class frmQuestao4 : Form
    {
        public frmQuestao4()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int n1 = 0,
                n2 = 0,
                n3 = 0;

            bool b1, b2, b3;

            string ordenados = "";

            n1 = int.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            n3 = int.Parse(txtNum3.Text);

            int[] numeros = { n1, n2, n3 };
            Array.Sort(numeros);

            ordenados = (numeros[0].ToString() + ", " + numeros[1].ToString() + ", " + numeros[2].ToString());
            lblOrdenados.Text = ordenados;
        }
    }
}
