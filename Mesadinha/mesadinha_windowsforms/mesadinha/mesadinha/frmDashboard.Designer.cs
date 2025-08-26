namespace mesadinha
{
    partial class frm_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabPage tbp_categorias;
            this.dgv_Categoria = new System.Windows.Forms.DataGridView();
            this.btn_CategoriaExcluir = new System.Windows.Forms.Button();
            this.btn_CategoriaAlterar = new System.Windows.Forms.Button();
            this.btn_CategoriaBuscar = new System.Windows.Forms.Button();
            this.txt_CategoriaID = new System.Windows.Forms.TextBox();
            this.lbl_CategoriaID = new System.Windows.Forms.Label();
            this.lbl_CategoriaTitulo = new System.Windows.Forms.Label();
            this.btn_CategoriaNovo = new System.Windows.Forms.Button();
            this.txt_CategoriaNome = new System.Windows.Forms.TextBox();
            this.lbl_CategoriaNome = new System.Windows.Forms.Label();
            this.tbc_Dashboard = new System.Windows.Forms.TabControl();
            this.tbp_home = new System.Windows.Forms.TabPage();
            this.lbl_HomeTitulo = new System.Windows.Forms.Label();
            this.lbl_SaldoValor = new System.Windows.Forms.Label();
            this.lbl_DespesasValor = new System.Windows.Forms.Label();
            this.lbl_ReceitasValor = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_despesas = new System.Windows.Forms.Label();
            this.lbl_receitas = new System.Windows.Forms.Label();
            this.tbp_perfil = new System.Windows.Forms.TabPage();
            this.lbl_PerfilTitulo = new System.Windows.Forms.Label();
            this.lbl_perfilNomeValor = new System.Windows.Forms.Label();
            this.lbl_perfilTelefoneValor = new System.Windows.Forms.Label();
            this.lbl_perfilTelefone = new System.Windows.Forms.Label();
            this.lbl_perfilEmailValor = new System.Windows.Forms.Label();
            this.lbl_perfilEnderecoValor = new System.Windows.Forms.Label();
            this.lbl_perfilEndereco = new System.Windows.Forms.Label();
            this.lbl_perfilEmail = new System.Windows.Forms.Label();
            this.lbl_perfilNome = new System.Windows.Forms.Label();
            this.tbp_alterarsenha = new System.Windows.Forms.TabPage();
            this.lbl_AlterarTitulo = new System.Windows.Forms.Label();
            this.lbl_AlterarAlertar = new System.Windows.Forms.Label();
            this.btn_AlterarEnviar = new System.Windows.Forms.Button();
            this.txt_AlterarNova1 = new System.Windows.Forms.TextBox();
            this.txt_AlterarAtual = new System.Windows.Forms.TextBox();
            this.txt_AlterarNova2 = new System.Windows.Forms.TextBox();
            this.lbl_AlterarNova2 = new System.Windows.Forms.Label();
            this.lbl_AlterarNova1 = new System.Windows.Forms.Label();
            this.lbl_AlterarAtual = new System.Windows.Forms.Label();
            this.tbp_contas = new System.Windows.Forms.TabPage();
            this.cbx_ContasCategoria = new System.Windows.Forms.ComboBox();
            this.cbx_ContasTipo = new System.Windows.Forms.ComboBox();
            this.lbl_ContaTipo = new System.Windows.Forms.Label();
            this.lbl_ContasCategoria = new System.Windows.Forms.Label();
            this.dgv_Contas = new System.Windows.Forms.DataGridView();
            this.btn_ContasExcluir = new System.Windows.Forms.Button();
            this.btn_ContasAlterar = new System.Windows.Forms.Button();
            this.btn_ContasBuscar = new System.Windows.Forms.Button();
            this.txt_ContasID = new System.Windows.Forms.TextBox();
            this.lbl_ContasID = new System.Windows.Forms.Label();
            this.lbl_ContaTitulo = new System.Windows.Forms.Label();
            this.btn_ContasNovo = new System.Windows.Forms.Button();
            this.txt_ContasNome = new System.Windows.Forms.TextBox();
            this.lbl_ContasNome = new System.Windows.Forms.Label();
            this.tbp_movimentacoes = new System.Windows.Forms.TabPage();
            this.tbp_sair = new System.Windows.Forms.TabPage();
            this.lbl_MovData = new System.Windows.Forms.Label();
            this.dgv_Mov = new System.Windows.Forms.DataGridView();
            this.btn_MovExcluir = new System.Windows.Forms.Button();
            this.btn_MovAlterar = new System.Windows.Forms.Button();
            this.btn_MovBuscar = new System.Windows.Forms.Button();
            this.txt_MovId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_MovTitulo = new System.Windows.Forms.Label();
            this.btn_MovNovo = new System.Windows.Forms.Button();
            this.txt_MovValor = new System.Windows.Forms.TextBox();
            this.lbl_MovValor = new System.Windows.Forms.Label();
            this.dtp_movData = new System.Windows.Forms.DateTimePicker();
            this.lbl_MovConta = new System.Windows.Forms.Label();
            this.cbx_MovContas = new System.Windows.Forms.ComboBox();
            tbp_categorias = new System.Windows.Forms.TabPage();
            tbp_categorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categoria)).BeginInit();
            this.tbc_Dashboard.SuspendLayout();
            this.tbp_home.SuspendLayout();
            this.tbp_perfil.SuspendLayout();
            this.tbp_alterarsenha.SuspendLayout();
            this.tbp_contas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Contas)).BeginInit();
            this.tbp_movimentacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mov)).BeginInit();
            this.SuspendLayout();
            // 
            // tbp_categorias
            // 
            tbp_categorias.Controls.Add(this.dgv_Categoria);
            tbp_categorias.Controls.Add(this.btn_CategoriaExcluir);
            tbp_categorias.Controls.Add(this.btn_CategoriaAlterar);
            tbp_categorias.Controls.Add(this.btn_CategoriaBuscar);
            tbp_categorias.Controls.Add(this.txt_CategoriaID);
            tbp_categorias.Controls.Add(this.lbl_CategoriaID);
            tbp_categorias.Controls.Add(this.lbl_CategoriaTitulo);
            tbp_categorias.Controls.Add(this.btn_CategoriaNovo);
            tbp_categorias.Controls.Add(this.txt_CategoriaNome);
            tbp_categorias.Controls.Add(this.lbl_CategoriaNome);
            tbp_categorias.Location = new System.Drawing.Point(4, 25);
            tbp_categorias.Name = "tbp_categorias";
            tbp_categorias.Size = new System.Drawing.Size(538, 334);
            tbp_categorias.TabIndex = 3;
            tbp_categorias.Text = "Categorias";
            tbp_categorias.UseVisualStyleBackColor = true;
            // 
            // dgv_Categoria
            // 
            this.dgv_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Categoria.Location = new System.Drawing.Point(26, 155);
            this.dgv_Categoria.Name = "dgv_Categoria";
            this.dgv_Categoria.RowHeadersWidth = 51;
            this.dgv_Categoria.RowTemplate.Height = 24;
            this.dgv_Categoria.Size = new System.Drawing.Size(478, 159);
            this.dgv_Categoria.TabIndex = 24;
            // 
            // btn_CategoriaExcluir
            // 
            this.btn_CategoriaExcluir.Location = new System.Drawing.Point(386, 111);
            this.btn_CategoriaExcluir.Name = "btn_CategoriaExcluir";
            this.btn_CategoriaExcluir.Size = new System.Drawing.Size(116, 29);
            this.btn_CategoriaExcluir.TabIndex = 23;
            this.btn_CategoriaExcluir.Text = "Excluir";
            this.btn_CategoriaExcluir.UseVisualStyleBackColor = true;
            this.btn_CategoriaExcluir.Click += new System.EventHandler(this.btn_CategoriaExcluir_Click);
            // 
            // btn_CategoriaAlterar
            // 
            this.btn_CategoriaAlterar.Location = new System.Drawing.Point(266, 111);
            this.btn_CategoriaAlterar.Name = "btn_CategoriaAlterar";
            this.btn_CategoriaAlterar.Size = new System.Drawing.Size(116, 29);
            this.btn_CategoriaAlterar.TabIndex = 22;
            this.btn_CategoriaAlterar.Text = "Alterar";
            this.btn_CategoriaAlterar.UseVisualStyleBackColor = true;
            this.btn_CategoriaAlterar.Click += new System.EventHandler(this.btn_CategoriaAlterar_Click);
            // 
            // btn_CategoriaBuscar
            // 
            this.btn_CategoriaBuscar.Location = new System.Drawing.Point(146, 111);
            this.btn_CategoriaBuscar.Name = "btn_CategoriaBuscar";
            this.btn_CategoriaBuscar.Size = new System.Drawing.Size(116, 29);
            this.btn_CategoriaBuscar.TabIndex = 21;
            this.btn_CategoriaBuscar.Text = "Buscar";
            this.btn_CategoriaBuscar.UseVisualStyleBackColor = true;
            this.btn_CategoriaBuscar.Click += new System.EventHandler(this.btn_CategoriaBuscar_Click);
            // 
            // txt_CategoriaID
            // 
            this.txt_CategoriaID.Location = new System.Drawing.Point(56, 66);
            this.txt_CategoriaID.Name = "txt_CategoriaID";
            this.txt_CategoriaID.Size = new System.Drawing.Size(79, 24);
            this.txt_CategoriaID.TabIndex = 20;
            // 
            // lbl_CategoriaID
            // 
            this.lbl_CategoriaID.AutoSize = true;
            this.lbl_CategoriaID.Location = new System.Drawing.Point(23, 69);
            this.lbl_CategoriaID.Name = "lbl_CategoriaID";
            this.lbl_CategoriaID.Size = new System.Drawing.Size(27, 18);
            this.lbl_CategoriaID.TabIndex = 19;
            this.lbl_CategoriaID.Text = "ID:";
            // 
            // lbl_CategoriaTitulo
            // 
            this.lbl_CategoriaTitulo.AutoSize = true;
            this.lbl_CategoriaTitulo.BackColor = System.Drawing.Color.Silver;
            this.lbl_CategoriaTitulo.Font = new System.Drawing.Font("Montserrat", 20F);
            this.lbl_CategoriaTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_CategoriaTitulo.MinimumSize = new System.Drawing.Size(538, 0);
            this.lbl_CategoriaTitulo.Name = "lbl_CategoriaTitulo";
            this.lbl_CategoriaTitulo.Size = new System.Drawing.Size(538, 42);
            this.lbl_CategoriaTitulo.TabIndex = 18;
            this.lbl_CategoriaTitulo.Text = "Categorias";
            this.lbl_CategoriaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CategoriaNovo
            // 
            this.btn_CategoriaNovo.Location = new System.Drawing.Point(26, 111);
            this.btn_CategoriaNovo.Name = "btn_CategoriaNovo";
            this.btn_CategoriaNovo.Size = new System.Drawing.Size(116, 29);
            this.btn_CategoriaNovo.TabIndex = 12;
            this.btn_CategoriaNovo.Text = "Novo";
            this.btn_CategoriaNovo.UseVisualStyleBackColor = true;
            this.btn_CategoriaNovo.Click += new System.EventHandler(this.btn_CategoriaNovo_Click);
            // 
            // txt_CategoriaNome
            // 
            this.txt_CategoriaNome.Location = new System.Drawing.Point(218, 66);
            this.txt_CategoriaNome.Name = "txt_CategoriaNome";
            this.txt_CategoriaNome.Size = new System.Drawing.Size(284, 24);
            this.txt_CategoriaNome.TabIndex = 10;
            // 
            // lbl_CategoriaNome
            // 
            this.lbl_CategoriaNome.AutoSize = true;
            this.lbl_CategoriaNome.Location = new System.Drawing.Point(158, 69);
            this.lbl_CategoriaNome.Name = "lbl_CategoriaNome";
            this.lbl_CategoriaNome.Size = new System.Drawing.Size(56, 18);
            this.lbl_CategoriaNome.TabIndex = 6;
            this.lbl_CategoriaNome.Text = "Nome:";
            // 
            // tbc_Dashboard
            // 
            this.tbc_Dashboard.Controls.Add(this.tbp_home);
            this.tbc_Dashboard.Controls.Add(this.tbp_perfil);
            this.tbc_Dashboard.Controls.Add(this.tbp_alterarsenha);
            this.tbc_Dashboard.Controls.Add(tbp_categorias);
            this.tbc_Dashboard.Controls.Add(this.tbp_contas);
            this.tbc_Dashboard.Controls.Add(this.tbp_movimentacoes);
            this.tbc_Dashboard.Controls.Add(this.tbp_sair);
            this.tbc_Dashboard.Location = new System.Drawing.Point(8, 6);
            this.tbc_Dashboard.Name = "tbc_Dashboard";
            this.tbc_Dashboard.SelectedIndex = 0;
            this.tbc_Dashboard.Size = new System.Drawing.Size(546, 363);
            this.tbc_Dashboard.TabIndex = 3;
            // 
            // tbp_home
            // 
            this.tbp_home.Controls.Add(this.lbl_HomeTitulo);
            this.tbp_home.Controls.Add(this.lbl_SaldoValor);
            this.tbp_home.Controls.Add(this.lbl_DespesasValor);
            this.tbp_home.Controls.Add(this.lbl_ReceitasValor);
            this.tbp_home.Controls.Add(this.lbl_saldo);
            this.tbp_home.Controls.Add(this.lbl_despesas);
            this.tbp_home.Controls.Add(this.lbl_receitas);
            this.tbp_home.Location = new System.Drawing.Point(4, 25);
            this.tbp_home.Name = "tbp_home";
            this.tbp_home.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_home.Size = new System.Drawing.Size(538, 334);
            this.tbp_home.TabIndex = 0;
            this.tbp_home.Text = "Home";
            this.tbp_home.UseVisualStyleBackColor = true;
            this.tbp_home.Click += new System.EventHandler(this.tbp_home_Click);
            // 
            // lbl_HomeTitulo
            // 
            this.lbl_HomeTitulo.AutoSize = true;
            this.lbl_HomeTitulo.BackColor = System.Drawing.Color.Silver;
            this.lbl_HomeTitulo.Font = new System.Drawing.Font("Montserrat", 20F);
            this.lbl_HomeTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_HomeTitulo.MinimumSize = new System.Drawing.Size(538, 0);
            this.lbl_HomeTitulo.Name = "lbl_HomeTitulo";
            this.lbl_HomeTitulo.Size = new System.Drawing.Size(538, 42);
            this.lbl_HomeTitulo.TabIndex = 6;
            this.lbl_HomeTitulo.Text = "Home";
            this.lbl_HomeTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SaldoValor
            // 
            this.lbl_SaldoValor.AutoSize = true;
            this.lbl_SaldoValor.Font = new System.Drawing.Font("Montserrat", 20F);
            this.lbl_SaldoValor.Location = new System.Drawing.Point(293, 218);
            this.lbl_SaldoValor.Name = "lbl_SaldoValor";
            this.lbl_SaldoValor.Size = new System.Drawing.Size(152, 42);
            this.lbl_SaldoValor.TabIndex = 5;
            this.lbl_SaldoValor.Text = "R$ 0,00";
            // 
            // lbl_DespesasValor
            // 
            this.lbl_DespesasValor.AutoSize = true;
            this.lbl_DespesasValor.Font = new System.Drawing.Font("Montserrat", 20F);
            this.lbl_DespesasValor.ForeColor = System.Drawing.Color.Red;
            this.lbl_DespesasValor.Location = new System.Drawing.Point(268, 143);
            this.lbl_DespesasValor.Name = "lbl_DespesasValor";
            this.lbl_DespesasValor.Size = new System.Drawing.Size(177, 42);
            this.lbl_DespesasValor.TabIndex = 4;
            this.lbl_DespesasValor.Text = "- R$ 0,00";
            // 
            // lbl_ReceitasValor
            // 
            this.lbl_ReceitasValor.AutoSize = true;
            this.lbl_ReceitasValor.Font = new System.Drawing.Font("Montserrat", 20F);
            this.lbl_ReceitasValor.ForeColor = System.Drawing.Color.Lime;
            this.lbl_ReceitasValor.Location = new System.Drawing.Point(293, 68);
            this.lbl_ReceitasValor.Name = "lbl_ReceitasValor";
            this.lbl_ReceitasValor.Size = new System.Drawing.Size(152, 42);
            this.lbl_ReceitasValor.TabIndex = 3;
            this.lbl_ReceitasValor.Text = "R$ 0,00";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("Montserrat", 20F);
            this.lbl_saldo.Location = new System.Drawing.Point(63, 218);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(123, 42);
            this.lbl_saldo.TabIndex = 2;
            this.lbl_saldo.Text = "Saldo:";
            // 
            // lbl_despesas
            // 
            this.lbl_despesas.AutoSize = true;
            this.lbl_despesas.Font = new System.Drawing.Font("Montserrat", 20F);
            this.lbl_despesas.Location = new System.Drawing.Point(63, 143);
            this.lbl_despesas.Name = "lbl_despesas";
            this.lbl_despesas.Size = new System.Drawing.Size(191, 42);
            this.lbl_despesas.TabIndex = 1;
            this.lbl_despesas.Text = "Despesas:";
            // 
            // lbl_receitas
            // 
            this.lbl_receitas.AutoSize = true;
            this.lbl_receitas.Font = new System.Drawing.Font("Montserrat", 20F);
            this.lbl_receitas.Location = new System.Drawing.Point(63, 68);
            this.lbl_receitas.Name = "lbl_receitas";
            this.lbl_receitas.Size = new System.Drawing.Size(175, 42);
            this.lbl_receitas.TabIndex = 0;
            this.lbl_receitas.Text = "Receitas:";
            // 
            // tbp_perfil
            // 
            this.tbp_perfil.Controls.Add(this.lbl_PerfilTitulo);
            this.tbp_perfil.Controls.Add(this.lbl_perfilNomeValor);
            this.tbp_perfil.Controls.Add(this.lbl_perfilTelefoneValor);
            this.tbp_perfil.Controls.Add(this.lbl_perfilTelefone);
            this.tbp_perfil.Controls.Add(this.lbl_perfilEmailValor);
            this.tbp_perfil.Controls.Add(this.lbl_perfilEnderecoValor);
            this.tbp_perfil.Controls.Add(this.lbl_perfilEndereco);
            this.tbp_perfil.Controls.Add(this.lbl_perfilEmail);
            this.tbp_perfil.Controls.Add(this.lbl_perfilNome);
            this.tbp_perfil.Location = new System.Drawing.Point(4, 25);
            this.tbp_perfil.Name = "tbp_perfil";
            this.tbp_perfil.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_perfil.Size = new System.Drawing.Size(538, 334);
            this.tbp_perfil.TabIndex = 1;
            this.tbp_perfil.Text = "Perfil";
            this.tbp_perfil.UseVisualStyleBackColor = true;
            this.tbp_perfil.Click += new System.EventHandler(this.tbp_perfil_Click_1);
            // 
            // lbl_PerfilTitulo
            // 
            this.lbl_PerfilTitulo.AutoSize = true;
            this.lbl_PerfilTitulo.BackColor = System.Drawing.Color.Silver;
            this.lbl_PerfilTitulo.Font = new System.Drawing.Font("Montserrat", 20F);
            this.lbl_PerfilTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_PerfilTitulo.MinimumSize = new System.Drawing.Size(538, 0);
            this.lbl_PerfilTitulo.Name = "lbl_PerfilTitulo";
            this.lbl_PerfilTitulo.Size = new System.Drawing.Size(538, 42);
            this.lbl_PerfilTitulo.TabIndex = 16;
            this.lbl_PerfilTitulo.Text = "Perfil";
            this.lbl_PerfilTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_perfilNomeValor
            // 
            this.lbl_perfilNomeValor.AutoSize = true;
            this.lbl_perfilNomeValor.Font = new System.Drawing.Font("Montserrat", 14F);
            this.lbl_perfilNomeValor.Location = new System.Drawing.Point(181, 65);
            this.lbl_perfilNomeValor.Name = "lbl_perfilNomeValor";
            this.lbl_perfilNomeValor.Size = new System.Drawing.Size(64, 29);
            this.lbl_perfilNomeValor.TabIndex = 15;
            this.lbl_perfilNomeValor.Text = "___";
            this.lbl_perfilNomeValor.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_perfilTelefoneValor
            // 
            this.lbl_perfilTelefoneValor.AutoSize = true;
            this.lbl_perfilTelefoneValor.Font = new System.Drawing.Font("Montserrat", 14F);
            this.lbl_perfilTelefoneValor.Location = new System.Drawing.Point(181, 269);
            this.lbl_perfilTelefoneValor.Name = "lbl_perfilTelefoneValor";
            this.lbl_perfilTelefoneValor.Size = new System.Drawing.Size(64, 29);
            this.lbl_perfilTelefoneValor.TabIndex = 14;
            this.lbl_perfilTelefoneValor.Text = "___";
            this.lbl_perfilTelefoneValor.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_perfilTelefone
            // 
            this.lbl_perfilTelefone.AutoSize = true;
            this.lbl_perfilTelefone.Font = new System.Drawing.Font("Montserrat", 14F);
            this.lbl_perfilTelefone.Location = new System.Drawing.Point(28, 269);
            this.lbl_perfilTelefone.Name = "lbl_perfilTelefone";
            this.lbl_perfilTelefone.Size = new System.Drawing.Size(127, 29);
            this.lbl_perfilTelefone.TabIndex = 13;
            this.lbl_perfilTelefone.Text = "Telefone:";
            // 
            // lbl_perfilEmailValor
            // 
            this.lbl_perfilEmailValor.AutoSize = true;
            this.lbl_perfilEmailValor.Font = new System.Drawing.Font("Montserrat", 14F);
            this.lbl_perfilEmailValor.Location = new System.Drawing.Point(181, 133);
            this.lbl_perfilEmailValor.Name = "lbl_perfilEmailValor";
            this.lbl_perfilEmailValor.Size = new System.Drawing.Size(64, 29);
            this.lbl_perfilEmailValor.TabIndex = 12;
            this.lbl_perfilEmailValor.Text = "___";
            this.lbl_perfilEmailValor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_perfilEnderecoValor
            // 
            this.lbl_perfilEnderecoValor.AutoSize = true;
            this.lbl_perfilEnderecoValor.Font = new System.Drawing.Font("Montserrat", 14F);
            this.lbl_perfilEnderecoValor.Location = new System.Drawing.Point(181, 201);
            this.lbl_perfilEnderecoValor.Name = "lbl_perfilEnderecoValor";
            this.lbl_perfilEnderecoValor.Size = new System.Drawing.Size(64, 29);
            this.lbl_perfilEnderecoValor.TabIndex = 11;
            this.lbl_perfilEnderecoValor.Text = "___";
            this.lbl_perfilEnderecoValor.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_perfilEndereco
            // 
            this.lbl_perfilEndereco.AutoSize = true;
            this.lbl_perfilEndereco.Font = new System.Drawing.Font("Montserrat", 14F);
            this.lbl_perfilEndereco.Location = new System.Drawing.Point(28, 201);
            this.lbl_perfilEndereco.Name = "lbl_perfilEndereco";
            this.lbl_perfilEndereco.Size = new System.Drawing.Size(138, 29);
            this.lbl_perfilEndereco.TabIndex = 8;
            this.lbl_perfilEndereco.Text = "Endereço:";
            // 
            // lbl_perfilEmail
            // 
            this.lbl_perfilEmail.AutoSize = true;
            this.lbl_perfilEmail.Font = new System.Drawing.Font("Montserrat", 14F);
            this.lbl_perfilEmail.Location = new System.Drawing.Point(28, 133);
            this.lbl_perfilEmail.Name = "lbl_perfilEmail";
            this.lbl_perfilEmail.Size = new System.Drawing.Size(99, 29);
            this.lbl_perfilEmail.TabIndex = 7;
            this.lbl_perfilEmail.Text = "E-mail:";
            // 
            // lbl_perfilNome
            // 
            this.lbl_perfilNome.AutoSize = true;
            this.lbl_perfilNome.Font = new System.Drawing.Font("Montserrat", 14F);
            this.lbl_perfilNome.Location = new System.Drawing.Point(28, 65);
            this.lbl_perfilNome.Name = "lbl_perfilNome";
            this.lbl_perfilNome.Size = new System.Drawing.Size(95, 29);
            this.lbl_perfilNome.TabIndex = 6;
            this.lbl_perfilNome.Text = "Nome:";
            this.lbl_perfilNome.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbp_alterarsenha
            // 
            this.tbp_alterarsenha.Controls.Add(this.lbl_AlterarTitulo);
            this.tbp_alterarsenha.Controls.Add(this.lbl_AlterarAlertar);
            this.tbp_alterarsenha.Controls.Add(this.btn_AlterarEnviar);
            this.tbp_alterarsenha.Controls.Add(this.txt_AlterarNova1);
            this.tbp_alterarsenha.Controls.Add(this.txt_AlterarAtual);
            this.tbp_alterarsenha.Controls.Add(this.txt_AlterarNova2);
            this.tbp_alterarsenha.Controls.Add(this.lbl_AlterarNova2);
            this.tbp_alterarsenha.Controls.Add(this.lbl_AlterarNova1);
            this.tbp_alterarsenha.Controls.Add(this.lbl_AlterarAtual);
            this.tbp_alterarsenha.Location = new System.Drawing.Point(4, 25);
            this.tbp_alterarsenha.Name = "tbp_alterarsenha";
            this.tbp_alterarsenha.Size = new System.Drawing.Size(538, 334);
            this.tbp_alterarsenha.TabIndex = 2;
            this.tbp_alterarsenha.Text = "Alterar Senha";
            this.tbp_alterarsenha.UseVisualStyleBackColor = true;
            // 
            // lbl_AlterarTitulo
            // 
            this.lbl_AlterarTitulo.AutoSize = true;
            this.lbl_AlterarTitulo.BackColor = System.Drawing.Color.Silver;
            this.lbl_AlterarTitulo.Font = new System.Drawing.Font("Montserrat", 20F);
            this.lbl_AlterarTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_AlterarTitulo.MinimumSize = new System.Drawing.Size(538, 0);
            this.lbl_AlterarTitulo.Name = "lbl_AlterarTitulo";
            this.lbl_AlterarTitulo.Size = new System.Drawing.Size(538, 42);
            this.lbl_AlterarTitulo.TabIndex = 17;
            this.lbl_AlterarTitulo.Text = "Alterar Senha";
            this.lbl_AlterarTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_AlterarAlertar
            // 
            this.lbl_AlterarAlertar.AutoSize = true;
            this.lbl_AlterarAlertar.ForeColor = System.Drawing.Color.Red;
            this.lbl_AlterarAlertar.Location = new System.Drawing.Point(102, 267);
            this.lbl_AlterarAlertar.MinimumSize = new System.Drawing.Size(300, 0);
            this.lbl_AlterarAlertar.Name = "lbl_AlterarAlertar";
            this.lbl_AlterarAlertar.Size = new System.Drawing.Size(300, 18);
            this.lbl_AlterarAlertar.TabIndex = 7;
            this.lbl_AlterarAlertar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AlterarEnviar
            // 
            this.btn_AlterarEnviar.Location = new System.Drawing.Point(147, 241);
            this.btn_AlterarEnviar.Name = "btn_AlterarEnviar";
            this.btn_AlterarEnviar.Size = new System.Drawing.Size(210, 23);
            this.btn_AlterarEnviar.TabIndex = 6;
            this.btn_AlterarEnviar.Text = "Enviar";
            this.btn_AlterarEnviar.UseVisualStyleBackColor = true;
            this.btn_AlterarEnviar.Click += new System.EventHandler(this.btn_AlterarEnviar_Click);
            // 
            // txt_AlterarNova1
            // 
            this.txt_AlterarNova1.Location = new System.Drawing.Point(274, 120);
            this.txt_AlterarNova1.Name = "txt_AlterarNova1";
            this.txt_AlterarNova1.Size = new System.Drawing.Size(174, 24);
            this.txt_AlterarNova1.TabIndex = 5;
            // 
            // txt_AlterarAtual
            // 
            this.txt_AlterarAtual.Location = new System.Drawing.Point(274, 76);
            this.txt_AlterarAtual.Name = "txt_AlterarAtual";
            this.txt_AlterarAtual.Size = new System.Drawing.Size(174, 24);
            this.txt_AlterarAtual.TabIndex = 4;
            // 
            // txt_AlterarNova2
            // 
            this.txt_AlterarNova2.Location = new System.Drawing.Point(274, 164);
            this.txt_AlterarNova2.Name = "txt_AlterarNova2";
            this.txt_AlterarNova2.Size = new System.Drawing.Size(174, 24);
            this.txt_AlterarNova2.TabIndex = 3;
            // 
            // lbl_AlterarNova2
            // 
            this.lbl_AlterarNova2.AutoSize = true;
            this.lbl_AlterarNova2.Location = new System.Drawing.Point(81, 165);
            this.lbl_AlterarNova2.Name = "lbl_AlterarNova2";
            this.lbl_AlterarNova2.Size = new System.Drawing.Size(174, 18);
            this.lbl_AlterarNova2.TabIndex = 2;
            this.lbl_AlterarNova2.Text = "Confirme a nova senha:";
            // 
            // lbl_AlterarNova1
            // 
            this.lbl_AlterarNova1.AutoSize = true;
            this.lbl_AlterarNova1.Location = new System.Drawing.Point(81, 122);
            this.lbl_AlterarNova1.Name = "lbl_AlterarNova1";
            this.lbl_AlterarNova1.Size = new System.Drawing.Size(151, 18);
            this.lbl_AlterarNova1.TabIndex = 1;
            this.lbl_AlterarNova1.Text = "Digite a nova senha:";
            // 
            // lbl_AlterarAtual
            // 
            this.lbl_AlterarAtual.AutoSize = true;
            this.lbl_AlterarAtual.Location = new System.Drawing.Point(81, 79);
            this.lbl_AlterarAtual.Name = "lbl_AlterarAtual";
            this.lbl_AlterarAtual.Size = new System.Drawing.Size(168, 18);
            this.lbl_AlterarAtual.TabIndex = 0;
            this.lbl_AlterarAtual.Text = "Digite sua senha atual:";
            this.lbl_AlterarAtual.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // tbp_contas
            // 
            this.tbp_contas.Controls.Add(this.cbx_ContasCategoria);
            this.tbp_contas.Controls.Add(this.cbx_ContasTipo);
            this.tbp_contas.Controls.Add(this.lbl_ContaTipo);
            this.tbp_contas.Controls.Add(this.lbl_ContasCategoria);
            this.tbp_contas.Controls.Add(this.dgv_Contas);
            this.tbp_contas.Controls.Add(this.btn_ContasExcluir);
            this.tbp_contas.Controls.Add(this.btn_ContasAlterar);
            this.tbp_contas.Controls.Add(this.btn_ContasBuscar);
            this.tbp_contas.Controls.Add(this.txt_ContasID);
            this.tbp_contas.Controls.Add(this.lbl_ContasID);
            this.tbp_contas.Controls.Add(this.lbl_ContaTitulo);
            this.tbp_contas.Controls.Add(this.btn_ContasNovo);
            this.tbp_contas.Controls.Add(this.txt_ContasNome);
            this.tbp_contas.Controls.Add(this.lbl_ContasNome);
            this.tbp_contas.Location = new System.Drawing.Point(4, 25);
            this.tbp_contas.Name = "tbp_contas";
            this.tbp_contas.Size = new System.Drawing.Size(538, 334);
            this.tbp_contas.TabIndex = 4;
            this.tbp_contas.Text = "Contas";
            this.tbp_contas.UseVisualStyleBackColor = true;
            // 
            // cbx_ContasCategoria
            // 
            this.cbx_ContasCategoria.FormattingEnabled = true;
            this.cbx_ContasCategoria.Location = new System.Drawing.Point(286, 92);
            this.cbx_ContasCategoria.Name = "cbx_ContasCategoria";
            this.cbx_ContasCategoria.Size = new System.Drawing.Size(216, 24);
            this.cbx_ContasCategoria.TabIndex = 39;
            this.cbx_ContasCategoria.Text = "Selecione";
            // 
            // cbx_ContasTipo
            // 
            this.cbx_ContasTipo.FormattingEnabled = true;
            this.cbx_ContasTipo.Items.AddRange(new object[] {
            "Despesa",
            "Receita"});
            this.cbx_ContasTipo.Location = new System.Drawing.Point(71, 92);
            this.cbx_ContasTipo.Name = "cbx_ContasTipo";
            this.cbx_ContasTipo.Size = new System.Drawing.Size(121, 24);
            this.cbx_ContasTipo.TabIndex = 38;
            this.cbx_ContasTipo.Text = "Selecione";
            // 
            // lbl_ContaTipo
            // 
            this.lbl_ContaTipo.AutoSize = true;
            this.lbl_ContaTipo.Location = new System.Drawing.Point(23, 95);
            this.lbl_ContaTipo.Name = "lbl_ContaTipo";
            this.lbl_ContaTipo.Size = new System.Drawing.Size(42, 18);
            this.lbl_ContaTipo.TabIndex = 37;
            this.lbl_ContaTipo.Text = "Tipo:";
            this.lbl_ContaTipo.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbl_ContasCategoria
            // 
            this.lbl_ContasCategoria.AutoSize = true;
            this.lbl_ContasCategoria.Location = new System.Drawing.Point(198, 95);
            this.lbl_ContasCategoria.Name = "lbl_ContasCategoria";
            this.lbl_ContasCategoria.Size = new System.Drawing.Size(81, 18);
            this.lbl_ContasCategoria.TabIndex = 35;
            this.lbl_ContasCategoria.Text = "Categoria:";
            this.lbl_ContasCategoria.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgv_Contas
            // 
            this.dgv_Contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Contas.Location = new System.Drawing.Point(26, 165);
            this.dgv_Contas.Name = "dgv_Contas";
            this.dgv_Contas.RowHeadersWidth = 51;
            this.dgv_Contas.RowTemplate.Height = 24;
            this.dgv_Contas.Size = new System.Drawing.Size(478, 159);
            this.dgv_Contas.TabIndex = 34;
            this.dgv_Contas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_contas_CellContentClick);
            // 
            // btn_ContasExcluir
            // 
            this.btn_ContasExcluir.Location = new System.Drawing.Point(386, 121);
            this.btn_ContasExcluir.Name = "btn_ContasExcluir";
            this.btn_ContasExcluir.Size = new System.Drawing.Size(116, 29);
            this.btn_ContasExcluir.TabIndex = 33;
            this.btn_ContasExcluir.Text = "Excluir";
            this.btn_ContasExcluir.UseVisualStyleBackColor = true;
            this.btn_ContasExcluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ContasAlterar
            // 
            this.btn_ContasAlterar.Location = new System.Drawing.Point(266, 121);
            this.btn_ContasAlterar.Name = "btn_ContasAlterar";
            this.btn_ContasAlterar.Size = new System.Drawing.Size(116, 29);
            this.btn_ContasAlterar.TabIndex = 32;
            this.btn_ContasAlterar.Text = "Alterar";
            this.btn_ContasAlterar.UseVisualStyleBackColor = true;
            this.btn_ContasAlterar.Click += new System.EventHandler(this.btn_ContasAlterar_Click);
            // 
            // btn_ContasBuscar
            // 
            this.btn_ContasBuscar.Location = new System.Drawing.Point(146, 121);
            this.btn_ContasBuscar.Name = "btn_ContasBuscar";
            this.btn_ContasBuscar.Size = new System.Drawing.Size(116, 29);
            this.btn_ContasBuscar.TabIndex = 31;
            this.btn_ContasBuscar.Text = "Buscar";
            this.btn_ContasBuscar.UseVisualStyleBackColor = true;
            this.btn_ContasBuscar.Click += new System.EventHandler(this.btn_ContasBuscar_Click);
            // 
            // txt_ContasID
            // 
            this.txt_ContasID.Location = new System.Drawing.Point(56, 62);
            this.txt_ContasID.Name = "txt_ContasID";
            this.txt_ContasID.Size = new System.Drawing.Size(79, 24);
            this.txt_ContasID.TabIndex = 30;
            // 
            // lbl_ContasID
            // 
            this.lbl_ContasID.AutoSize = true;
            this.lbl_ContasID.Location = new System.Drawing.Point(23, 65);
            this.lbl_ContasID.Name = "lbl_ContasID";
            this.lbl_ContasID.Size = new System.Drawing.Size(27, 18);
            this.lbl_ContasID.TabIndex = 29;
            this.lbl_ContasID.Text = "ID:";
            // 
            // lbl_ContaTitulo
            // 
            this.lbl_ContaTitulo.AutoSize = true;
            this.lbl_ContaTitulo.BackColor = System.Drawing.Color.Silver;
            this.lbl_ContaTitulo.Font = new System.Drawing.Font("Montserrat", 20F);
            this.lbl_ContaTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_ContaTitulo.MinimumSize = new System.Drawing.Size(538, 0);
            this.lbl_ContaTitulo.Name = "lbl_ContaTitulo";
            this.lbl_ContaTitulo.Size = new System.Drawing.Size(538, 42);
            this.lbl_ContaTitulo.TabIndex = 28;
            this.lbl_ContaTitulo.Text = "Contas";
            this.lbl_ContaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ContasNovo
            // 
            this.btn_ContasNovo.Location = new System.Drawing.Point(26, 121);
            this.btn_ContasNovo.Name = "btn_ContasNovo";
            this.btn_ContasNovo.Size = new System.Drawing.Size(116, 29);
            this.btn_ContasNovo.TabIndex = 27;
            this.btn_ContasNovo.Text = "Novo";
            this.btn_ContasNovo.UseVisualStyleBackColor = true;
            this.btn_ContasNovo.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_ContasNome
            // 
            this.txt_ContasNome.Location = new System.Drawing.Point(218, 62);
            this.txt_ContasNome.Name = "txt_ContasNome";
            this.txt_ContasNome.Size = new System.Drawing.Size(284, 24);
            this.txt_ContasNome.TabIndex = 26;
            // 
            // lbl_ContasNome
            // 
            this.lbl_ContasNome.AutoSize = true;
            this.lbl_ContasNome.Location = new System.Drawing.Point(156, 65);
            this.lbl_ContasNome.Name = "lbl_ContasNome";
            this.lbl_ContasNome.Size = new System.Drawing.Size(56, 18);
            this.lbl_ContasNome.TabIndex = 25;
            this.lbl_ContasNome.Text = "Nome:";
            // 
            // tbp_movimentacoes
            // 
            this.tbp_movimentacoes.Controls.Add(this.cbx_MovContas);
            this.tbp_movimentacoes.Controls.Add(this.lbl_MovConta);
            this.tbp_movimentacoes.Controls.Add(this.dtp_movData);
            this.tbp_movimentacoes.Controls.Add(this.lbl_MovData);
            this.tbp_movimentacoes.Controls.Add(this.dgv_Mov);
            this.tbp_movimentacoes.Controls.Add(this.btn_MovExcluir);
            this.tbp_movimentacoes.Controls.Add(this.btn_MovAlterar);
            this.tbp_movimentacoes.Controls.Add(this.btn_MovBuscar);
            this.tbp_movimentacoes.Controls.Add(this.txt_MovId);
            this.tbp_movimentacoes.Controls.Add(this.label3);
            this.tbp_movimentacoes.Controls.Add(this.lbl_MovTitulo);
            this.tbp_movimentacoes.Controls.Add(this.btn_MovNovo);
            this.tbp_movimentacoes.Controls.Add(this.txt_MovValor);
            this.tbp_movimentacoes.Controls.Add(this.lbl_MovValor);
            this.tbp_movimentacoes.Location = new System.Drawing.Point(4, 25);
            this.tbp_movimentacoes.Name = "tbp_movimentacoes";
            this.tbp_movimentacoes.Size = new System.Drawing.Size(538, 334);
            this.tbp_movimentacoes.TabIndex = 5;
            this.tbp_movimentacoes.Text = "Movimentações";
            this.tbp_movimentacoes.UseVisualStyleBackColor = true;
            // 
            // tbp_sair
            // 
            this.tbp_sair.Location = new System.Drawing.Point(4, 25);
            this.tbp_sair.Name = "tbp_sair";
            this.tbp_sair.Size = new System.Drawing.Size(538, 334);
            this.tbp_sair.TabIndex = 6;
            this.tbp_sair.Text = "Sair";
            this.tbp_sair.UseVisualStyleBackColor = true;
            // 
            // lbl_MovData
            // 
            this.lbl_MovData.AutoSize = true;
            this.lbl_MovData.Location = new System.Drawing.Point(143, 70);
            this.lbl_MovData.Name = "lbl_MovData";
            this.lbl_MovData.Size = new System.Drawing.Size(45, 18);
            this.lbl_MovData.TabIndex = 50;
            this.lbl_MovData.Text = "Data:";
            // 
            // dgv_Mov
            // 
            this.dgv_Mov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mov.Location = new System.Drawing.Point(26, 170);
            this.dgv_Mov.Name = "dgv_Mov";
            this.dgv_Mov.RowHeadersWidth = 51;
            this.dgv_Mov.RowTemplate.Height = 24;
            this.dgv_Mov.Size = new System.Drawing.Size(478, 159);
            this.dgv_Mov.TabIndex = 49;
            this.dgv_Mov.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Mov_CellContentClick);
            // 
            // btn_MovExcluir
            // 
            this.btn_MovExcluir.Location = new System.Drawing.Point(386, 126);
            this.btn_MovExcluir.Name = "btn_MovExcluir";
            this.btn_MovExcluir.Size = new System.Drawing.Size(116, 29);
            this.btn_MovExcluir.TabIndex = 48;
            this.btn_MovExcluir.Text = "Excluir";
            this.btn_MovExcluir.UseVisualStyleBackColor = true;
            this.btn_MovExcluir.Click += new System.EventHandler(this.btn_MovExcluir_Click);
            // 
            // btn_MovAlterar
            // 
            this.btn_MovAlterar.Location = new System.Drawing.Point(266, 126);
            this.btn_MovAlterar.Name = "btn_MovAlterar";
            this.btn_MovAlterar.Size = new System.Drawing.Size(116, 29);
            this.btn_MovAlterar.TabIndex = 47;
            this.btn_MovAlterar.Text = "Alterar";
            this.btn_MovAlterar.UseVisualStyleBackColor = true;
            this.btn_MovAlterar.Click += new System.EventHandler(this.btn_MovAlterar_Click);
            // 
            // btn_MovBuscar
            // 
            this.btn_MovBuscar.Location = new System.Drawing.Point(146, 126);
            this.btn_MovBuscar.Name = "btn_MovBuscar";
            this.btn_MovBuscar.Size = new System.Drawing.Size(116, 29);
            this.btn_MovBuscar.TabIndex = 46;
            this.btn_MovBuscar.Text = "Buscar";
            this.btn_MovBuscar.UseVisualStyleBackColor = true;
            this.btn_MovBuscar.Click += new System.EventHandler(this.btn_MovBuscar_Click);
            // 
            // txt_MovId
            // 
            this.txt_MovId.Location = new System.Drawing.Point(56, 67);
            this.txt_MovId.Name = "txt_MovId";
            this.txt_MovId.Size = new System.Drawing.Size(79, 24);
            this.txt_MovId.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "ID:";
            // 
            // lbl_MovTitulo
            // 
            this.lbl_MovTitulo.AutoSize = true;
            this.lbl_MovTitulo.BackColor = System.Drawing.Color.Silver;
            this.lbl_MovTitulo.Font = new System.Drawing.Font("Montserrat", 20F);
            this.lbl_MovTitulo.Location = new System.Drawing.Point(0, 5);
            this.lbl_MovTitulo.MinimumSize = new System.Drawing.Size(538, 0);
            this.lbl_MovTitulo.Name = "lbl_MovTitulo";
            this.lbl_MovTitulo.Size = new System.Drawing.Size(538, 42);
            this.lbl_MovTitulo.TabIndex = 43;
            this.lbl_MovTitulo.Text = "Movimentação";
            this.lbl_MovTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_MovNovo
            // 
            this.btn_MovNovo.Location = new System.Drawing.Point(26, 126);
            this.btn_MovNovo.Name = "btn_MovNovo";
            this.btn_MovNovo.Size = new System.Drawing.Size(116, 29);
            this.btn_MovNovo.TabIndex = 42;
            this.btn_MovNovo.Text = "Novo";
            this.btn_MovNovo.UseVisualStyleBackColor = true;
            this.btn_MovNovo.Click += new System.EventHandler(this.btn_MovNovo_Click);
            // 
            // txt_MovValor
            // 
            this.txt_MovValor.Location = new System.Drawing.Point(74, 97);
            this.txt_MovValor.Name = "txt_MovValor";
            this.txt_MovValor.Size = new System.Drawing.Size(185, 24);
            this.txt_MovValor.TabIndex = 41;
            // 
            // lbl_MovValor
            // 
            this.lbl_MovValor.AutoSize = true;
            this.lbl_MovValor.Location = new System.Drawing.Point(23, 99);
            this.lbl_MovValor.Name = "lbl_MovValor";
            this.lbl_MovValor.Size = new System.Drawing.Size(48, 18);
            this.lbl_MovValor.TabIndex = 40;
            this.lbl_MovValor.Text = "Valor:";
            // 
            // dtp_movData
            // 
            this.dtp_movData.Location = new System.Drawing.Point(192, 67);
            this.dtp_movData.Name = "dtp_movData";
            this.dtp_movData.Size = new System.Drawing.Size(312, 24);
            this.dtp_movData.TabIndex = 51;
            // 
            // lbl_MovConta
            // 
            this.lbl_MovConta.AutoSize = true;
            this.lbl_MovConta.Location = new System.Drawing.Point(265, 101);
            this.lbl_MovConta.Name = "lbl_MovConta";
            this.lbl_MovConta.Size = new System.Drawing.Size(54, 18);
            this.lbl_MovConta.TabIndex = 52;
            this.lbl_MovConta.Text = "Conta:";
            // 
            // cbx_MovContas
            // 
            this.cbx_MovContas.FormattingEnabled = true;
            this.cbx_MovContas.Location = new System.Drawing.Point(325, 97);
            this.cbx_MovContas.Name = "cbx_MovContas";
            this.cbx_MovContas.Size = new System.Drawing.Size(177, 24);
            this.cbx_MovContas.TabIndex = 53;
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 379);
            this.Controls.Add(this.tbc_Dashboard);
            this.Font = new System.Drawing.Font("Montserrat", 8F);
            this.Name = "frm_Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            tbp_categorias.ResumeLayout(false);
            tbp_categorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categoria)).EndInit();
            this.tbc_Dashboard.ResumeLayout(false);
            this.tbp_home.ResumeLayout(false);
            this.tbp_home.PerformLayout();
            this.tbp_perfil.ResumeLayout(false);
            this.tbp_perfil.PerformLayout();
            this.tbp_alterarsenha.ResumeLayout(false);
            this.tbp_alterarsenha.PerformLayout();
            this.tbp_contas.ResumeLayout(false);
            this.tbp_contas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Contas)).EndInit();
            this.tbp_movimentacoes.ResumeLayout(false);
            this.tbp_movimentacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbc_Dashboard;
        private System.Windows.Forms.TabPage tbp_home;
        private System.Windows.Forms.TabPage tbp_perfil;
        private System.Windows.Forms.TabPage tbp_alterarsenha;
        private System.Windows.Forms.TabPage tbp_contas;
        private System.Windows.Forms.TabPage tbp_movimentacoes;
        private System.Windows.Forms.Label lbl_SaldoValor;
        private System.Windows.Forms.Label lbl_DespesasValor;
        private System.Windows.Forms.Label lbl_ReceitasValor;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label lbl_despesas;
        private System.Windows.Forms.Label lbl_receitas;
        private System.Windows.Forms.TabPage tbp_sair;
        private System.Windows.Forms.Label lbl_perfilNomeValor;
        private System.Windows.Forms.Label lbl_perfilTelefoneValor;
        private System.Windows.Forms.Label lbl_perfilTelefone;
        private System.Windows.Forms.Label lbl_perfilEmailValor;
        private System.Windows.Forms.Label lbl_perfilEnderecoValor;
        private System.Windows.Forms.Label lbl_perfilEndereco;
        private System.Windows.Forms.Label lbl_perfilEmail;
        private System.Windows.Forms.Label lbl_perfilNome;
        private System.Windows.Forms.Button btn_AlterarEnviar;
        private System.Windows.Forms.TextBox txt_AlterarNova1;
        private System.Windows.Forms.TextBox txt_AlterarAtual;
        private System.Windows.Forms.TextBox txt_AlterarNova2;
        private System.Windows.Forms.Label lbl_AlterarNova2;
        private System.Windows.Forms.Label lbl_AlterarNova1;
        private System.Windows.Forms.Label lbl_AlterarAtual;
        private System.Windows.Forms.Label lbl_AlterarAlertar;
        private System.Windows.Forms.DataGridView dgv_Categoria;
        private System.Windows.Forms.Button btn_CategoriaExcluir;
        private System.Windows.Forms.Button btn_CategoriaAlterar;
        private System.Windows.Forms.Button btn_CategoriaBuscar;
        private System.Windows.Forms.TextBox txt_CategoriaID;
        private System.Windows.Forms.Label lbl_CategoriaID;
        private System.Windows.Forms.Label lbl_CategoriaTitulo;
        private System.Windows.Forms.Button btn_CategoriaNovo;
        private System.Windows.Forms.TextBox txt_CategoriaNome;
        private System.Windows.Forms.Label lbl_CategoriaNome;
        private System.Windows.Forms.Label lbl_HomeTitulo;
        private System.Windows.Forms.Label lbl_PerfilTitulo;
        private System.Windows.Forms.Label lbl_AlterarTitulo;
        private System.Windows.Forms.Label lbl_ContaTipo;
        private System.Windows.Forms.Label lbl_ContasCategoria;
        private System.Windows.Forms.DataGridView dgv_Contas;
        private System.Windows.Forms.Button btn_ContasExcluir;
        private System.Windows.Forms.Button btn_ContasAlterar;
        private System.Windows.Forms.Button btn_ContasBuscar;
        private System.Windows.Forms.TextBox txt_ContasID;
        private System.Windows.Forms.Label lbl_ContasID;
        private System.Windows.Forms.Label lbl_ContaTitulo;
        private System.Windows.Forms.Button btn_ContasNovo;
        private System.Windows.Forms.TextBox txt_ContasNome;
        private System.Windows.Forms.Label lbl_ContasNome;
        private System.Windows.Forms.ComboBox cbx_ContasCategoria;
        private System.Windows.Forms.ComboBox cbx_ContasTipo;
        private System.Windows.Forms.Label lbl_MovData;
        private System.Windows.Forms.DataGridView dgv_Mov;
        private System.Windows.Forms.Button btn_MovExcluir;
        private System.Windows.Forms.Button btn_MovAlterar;
        private System.Windows.Forms.Button btn_MovBuscar;
        private System.Windows.Forms.TextBox txt_MovId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_MovTitulo;
        private System.Windows.Forms.Button btn_MovNovo;
        private System.Windows.Forms.TextBox txt_MovValor;
        private System.Windows.Forms.Label lbl_MovValor;
        private System.Windows.Forms.DateTimePicker dtp_movData;
        private System.Windows.Forms.ComboBox cbx_MovContas;
        private System.Windows.Forms.Label lbl_MovConta;
    }
}