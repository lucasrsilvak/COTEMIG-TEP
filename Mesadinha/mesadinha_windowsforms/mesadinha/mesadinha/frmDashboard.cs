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
    public partial class frm_Dashboard : Form
    {

        ConexaoBD bd = new ConexaoBD();
        string mySession = Session.Id;
        string sql = "";
        int[] categorias,
              contas;

        public void Limpar()
        {
            txt_AlterarNova1.Clear();
            txt_AlterarAtual.Clear();
            txt_AlterarNova2.Clear();
            txt_CategoriaID.Clear();
            txt_CategoriaNome.Clear();
            txt_ContasID.Clear();
            txt_ContasNome.Clear();
            txt_MovId.Clear();
            txt_MovValor.Clear();

            cbx_ContasCategoria.Text = "";
            cbx_ContasTipo.Text = "";
            cbx_MovContas.Text = "";

            dtp_movData.Value = DateTime.Now;
        }

        public void ListarCategoria()
        {
            sql = string.Format("select distinct categoria.id as Id, categoria.nome as Nome, count(*) as Contas from categoria join conta on categoria.id = conta.categoria_id where categoria.usuario_id = '{0}' group by categoria.id union select categoria.id as id, nome, null as contagem from categoria where categoria.usuario_id = '{1}' and id != ALL(select categoria_id from conta where conta.categoria_id = categoria.id) order by id", mySession, mySession);
            dgv_Categoria.DataSource = bd.ConsultarTabela(sql);
        }
        public void ListarContas()
        {
            sql = string.Format("select conta.id as Id, conta.nome as Nome, conta.tipo as Tipo, categoria.nome as Categoria from conta join categoria on categoria.id = conta.categoria_id where categoria.usuario_id = '{0}' order by conta.id", mySession);
            dgv_Contas.DataSource = bd.ConsultarTabela(sql);

            sql = string.Format("select id, nome from categoria where usuario_id = '{0}' order by id", mySession);
            DataTable resultado = bd.ConsultarTabela(sql);

            cbx_ContasCategoria.Items.Clear();
            categorias = new int[int.Parse(resultado.Rows.Count.ToString())];

            for(int i = 0; i < int.Parse(resultado.Rows.Count.ToString()); i++)
            {
                categorias[i] = int.Parse(resultado.Rows[i]["id"].ToString());
                cbx_ContasCategoria.Items.Add(resultado.Rows[i]["nome"].ToString());
            }
            
        }

        public void ListarMovimentacao()
        {
            sql = string.Format("select movimentacao.id as Id, conta.nome as Nome, movimentacao.valor as Valor, movimentacao.data as Data from movimentacao join conta on movimentacao.conta_id = conta.id where movimentacao.usuario_id = '{0}' order by data, id", mySession);
            dgv_Mov.DataSource = bd.ConsultarTabela(sql);

            sql = string.Format("select conta.id as id, conta.nome as nome from conta join categoria on categoria.id = conta.categoria_id where categoria.usuario_id = '{0}' order by id", mySession);
            DataTable resultado = bd.ConsultarTabela(sql);
            
            cbx_MovContas.Items.Clear();
            contas = new int[int.Parse(resultado.Rows.Count.ToString())];

            for (int i = 0; i < int.Parse(resultado.Rows.Count.ToString()); i++)
            {
                contas[i] = int.Parse(resultado.Rows[i]["id"].ToString());
                cbx_MovContas.Items.Add(resultado.Rows[i]["nome"].ToString());
            }
        }

        public frm_Dashboard()
        {
            InitializeComponent();            
        }

        public void tbc_Dashboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbc_Dashboard.SelectedIndex) 
            {
                case 0:
                    {

                        double receita = 0,
                               despesa = 0,
                               saldo = 0;

                        sql = string.Format("select sum(valor) as receita from movimentacao join conta on conta.id = movimentacao.conta_id where conta.tipo = 'R' and movimentacao.usuario_id = '{0}'", mySession);
                        DataTable resultado = bd.ConsultarTabela(sql);

                        if (resultado.Rows.Count > 0)
                        {
                            try
                            {
                                receita = double.Parse(resultado.Rows[0]["receita"].ToString());

                            }
                            catch (Exception)
                            {
                                receita = 0.00;
                            }
                            lbl_ReceitasValor.Text = "R$ " + receita.ToString("0.00");
                        }

                        sql = string.Format("select sum(valor) as despesa from movimentacao join conta on conta.id = movimentacao.conta_id where conta.tipo = 'D' and movimentacao.usuario_id = '{0}'", mySession);
                        resultado = bd.ConsultarTabela(sql);

                        if (resultado.Rows.Count > 0)
                        {
                            try
                            {
                                despesa = double.Parse(resultado.Rows[0]["despesa"].ToString());
                            }
                            catch (Exception)
                            {
                                despesa = 0.00;
                            }
                            lbl_DespesasValor.Text = "- R$ " + despesa.ToString("0.00");
                        }

                        saldo = receita - despesa;
                        lbl_SaldoValor.Text = "R$ " + saldo.ToString("0.00");

                        if (saldo >= 0)
                        {
                            lbl_SaldoValor.ForeColor = lbl_ReceitasValor.ForeColor;
                        }
                        else
                        {
                            lbl_SaldoValor.ForeColor = lbl_DespesasValor.ForeColor;
                        }
                    }
                    break;
                case 1:
                    {
                        sql = string.Format("select * from usuario where id = '{0}'", mySession);
                        DataTable resultado = bd.ConsultarTabela(sql);

                        if (resultado.Rows.Count > 0)
                        {
                            lbl_perfilNomeValor.Text     = resultado.Rows[0]["nome"].ToString();
                            lbl_perfilEmailValor.Text    = resultado.Rows[0]["email"].ToString();
                            lbl_perfilEnderecoValor.Text = resultado.Rows[0]["endereco"].ToString();
                            lbl_perfilTelefoneValor.Text = resultado.Rows[0]["telefone"].ToString();
                        }
                    }
                    break;
                case 2:
                        txt_AlterarAtual.PasswordChar = '*';
                        txt_AlterarNova1.PasswordChar = '*';
                        txt_AlterarNova2.PasswordChar = '*';
                    break;
                case 3:
                    ListarCategoria();
                    break;
                case 4:
                    ListarContas();
                    break;
                case 5:
                    ListarMovimentacao();
                    break;
                case 6:
                    this.Hide();

                    frm_login Login = new frm_login();
                    Login.ShowDialog();
                    break;
                default:
                    break;
            }
                
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            tbc_Dashboard.SelectedIndexChanged += tbc_Dashboard_SelectedIndexChanged;

            double receita = 0,
                   despesa = 0,
                   saldo = 0;

            sql = string.Format("select sum(valor) as receita from movimentacao join conta on conta.id = movimentacao.conta_id where conta.tipo = 'R' and movimentacao.usuario_id = '{0}'", mySession);
            DataTable resultado = bd.ConsultarTabela(sql);

            if (resultado.Rows.Count > 0)
            {
                try
                {
                    receita = double.Parse(resultado.Rows[0]["receita"].ToString());
                } catch (Exception)
                {
                    receita = 0.00;
                }
                lbl_ReceitasValor.Text = "R$ " + receita.ToString("0.00");

            }

            sql = string.Format("select sum(valor) as despesa from movimentacao join conta on conta.id = movimentacao.conta_id where conta.tipo = 'D' and movimentacao.usuario_id = '{0}'", mySession);
            resultado = bd.ConsultarTabela(sql);

            if (resultado.Rows.Count > 0)
            {
                try
                {
                    despesa = double.Parse(resultado.Rows[0]["despesa"].ToString());
                }
                catch (Exception)
                {
                    despesa = 0.00;
                }
                lbl_DespesasValor.Text = "- R$ " + despesa.ToString("0.00");
            }

            saldo = receita - despesa;
            lbl_SaldoValor.Text = "R$ " + saldo.ToString("0.00");

            if (saldo >= 0)
            {
                lbl_SaldoValor.ForeColor = lbl_ReceitasValor.ForeColor;
            } 
            else
            {
                lbl_SaldoValor.ForeColor = lbl_DespesasValor.ForeColor;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_subtitle_Click(object sender, EventArgs e)
        {

        }

        private void btn_return_Click(object sender, EventArgs e)
        {

        }


        private void tbp_home_Click(object sender, EventArgs e)
        {

        }

        private void tbp_perfil_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tbp_perfil_Click_1(object sender, EventArgs e)
        {
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btn_AlterarEnviar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select senha from usuario where id = '{0}'", mySession);
            DataTable resultado = bd.ConsultarTabela(sql);

            if (txt_AlterarAtual.Text == resultado.Rows[0]["senha"].ToString())
            {
                if (txt_AlterarNova1.Text == txt_AlterarNova2.Text)
                {
                    sql = string.Format("update usuario set senha = '{0}' where id = '{1}'", txt_AlterarNova1.Text, mySession);
                    bd.AlterarDados(sql);
                    lbl_AlterarAlertar.Text = "Senha alterada com sucesso";
                    lbl_AlterarAlertar.ForeColor = Color.Lime;
                    Limpar();
                }
                else
                {
                    lbl_AlterarAlertar.Text = "Senhas não conferem";
                    lbl_AlterarAlertar.ForeColor = Color.Red;
                }
            } 
            else
            {
                lbl_AlterarAlertar.Text = "Senha incorreta";
                lbl_AlterarAlertar.ForeColor = Color.Red;
            }
        }

        private void btn_CategoriaNovo_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into categoria(id, nome, usuario_id) values(null, '{0}', '{1}')", txt_CategoriaNome.Text, mySession);
            bd.AlterarDados(sql);
            ListarCategoria();
            Limpar();
        }

        private void btn_CategoriaBuscar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select distinct categoria.id as Id, categoria.nome as Nome, count(*) as Contas from categoria join conta on categoria.id = conta.categoria_id where categoria.id = '{0}' and categoria.usuario_id = '{1}' and categoria.id != ALL(select categoria_id from conta where conta.categoria_id = categoria.id and categoria.id != '{2}') order by id", txt_CategoriaID.Text, mySession, txt_CategoriaID.Text);
            dgv_Categoria.DataSource = bd.ConsultarTabela(sql);
            Limpar();
        }

        private void btn_CategoriaAlterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update categoria set nome = '{0}' where id = '{1}' and usuario_id = '{2}'", txt_CategoriaNome.Text, txt_CategoriaID.Text, mySession);
            bd.AlterarDados(sql);
            ListarCategoria();
            Limpar();
        }

        private void btn_CategoriaExcluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from categoria where id = '{0}' and usuario_id = '{1}'", txt_CategoriaID.Text, mySession);
            bd.AlterarTabela(sql);
            ListarCategoria();
            Limpar();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_contas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            char tipo;

            switch (cbx_ContasTipo.Text)
            {
                case "Despesa":
                    tipo = 'D';
                    break;
                default:
                    tipo = 'R';
                    break;
            }
            if (int.Parse(cbx_ContasCategoria.SelectedIndex.ToString()) != -1)
            {
                int categoria_id = categorias[int.Parse(cbx_ContasCategoria.SelectedIndex.ToString())];

                sql = string.Format("insert into conta(id, nome, tipo, categoria_id) values(null, '{0}','{1}','{2}')", txt_ContasNome.Text, tipo, categoria_id);
                bd.AlterarDados(sql);
                ListarContas();
                Limpar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from conta where conta.id = '{0}' and '{1}' = (select usuario_id from conta join categoria on conta.categoria_id = categoria.id where conta.id = '{2}' and categoria.usuario_id = '{3}')", txt_ContasID.Text, mySession, txt_ContasID.Text, mySession);
            bd.AlterarTabela(sql);
            ListarContas();
            Limpar();
        }

        private void btn_ContasBuscar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select conta.id as Id, conta.nome as Nome, tipo as Tipo, categoria.nome as Categoria from conta join categoria on categoria.id = conta.categoria_id where conta.id = '{0}' and categoria.usuario_id = '{1}';", txt_ContasID.Text, mySession);
            dgv_Contas.DataSource = bd.ConsultarTabela(sql);
            Limpar();
        }

        private void btn_ContasAlterar_Click(object sender, EventArgs e)
        {
            char tipo;

            switch (cbx_ContasTipo.Text)
            {
                case "Despesa":
                    tipo = 'D';
                    break;
                default:
                    tipo = 'R';
                    break;
            }
            if (int.Parse(cbx_ContasCategoria.SelectedIndex.ToString()) != -1)
            {
                if (int.Parse(cbx_ContasCategoria.SelectedIndex.ToString()) != -1)
                {
                    int categoria_id = categorias[int.Parse(cbx_ContasCategoria.SelectedIndex.ToString())];
                    sql = string.Format("update conta set nome = '{0}', tipo = '{1}', categoria_id = '{2}' where conta.id = '{3}' and '{4}' = (select usuario_id from conta join categoria on conta.categoria_id = categoria.id where conta.id = '{5}' and categoria.usuario_id = '{6}')", txt_ContasNome.Text, tipo, categoria_id, txt_ContasID.Text, mySession, txt_ContasID.Text, mySession);
                    bd.AlterarDados(sql);
                    ListarContas();
                    Limpar();
                }
            }
        }

        private void btn_MovNovo_Click(object sender, EventArgs e)
        {
            if (int.Parse(cbx_MovContas.SelectedIndex.ToString()) != -1)
            {
                int contas_id = contas[int.Parse(cbx_MovContas.SelectedIndex.ToString())];
                sql = string.Format("insert into movimentacao(id, valor, data, conta_id, usuario_id) values(null, '{1}', '{2}', '{3}', '{4}')", txt_MovValor.Text, txt_MovValor.Text, dtp_movData.Value.ToString("yyyy-MM-dd"), contas_id, mySession);
                bd.AlterarDados(sql);
                ListarMovimentacao();
                Limpar();
            }
        }

        private void btn_MovBuscar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select * from movimentacao where id = '{0}' and usuario_id = '{1}'", txt_MovId.Text, mySession);
            dgv_Mov.DataSource = bd.ConsultarTabela(sql);
            Limpar();
        }

        private void btn_MovAlterar_Click(object sender, EventArgs e)
        {
            if (int.Parse(cbx_MovContas.SelectedIndex.ToString()) != -1)
            {
                int contas_id = contas[int.Parse(cbx_MovContas.SelectedIndex.ToString())];
                sql = string.Format("update movimentacao set valor = '{0}', data = '{1}', conta_id = '{2}' where id = '{3}' and usuario_id = '{4}'", txt_MovValor.Text, dtp_movData.Value.ToString("yyyy-MM-dd"), contas_id, txt_MovId.Text, mySession);
                bd.AlterarDados(sql);
                ListarMovimentacao();
                Limpar();
            }
        }

        private void btn_MovExcluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from movimentacao where id = '{0}' and usuario_id = '{1}'", txt_MovId.Text, mySession);
            bd.AlterarTabela(sql);
            ListarMovimentacao();
            Limpar();
        }

        private void dgv_Mov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
