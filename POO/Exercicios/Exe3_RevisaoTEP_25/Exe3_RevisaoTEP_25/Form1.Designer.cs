namespace Exe3_RevisaoTEP_25
{
    partial class frmQuestao3
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnRetirada = new System.Windows.Forms.Button();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(310, 9);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(125, 23);
            this.btnDeposito.TabIndex = 0;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnRetirada
            // 
            this.btnRetirada.Location = new System.Drawing.Point(310, 38);
            this.btnRetirada.Name = "btnRetirada";
            this.btnRetirada.Size = new System.Drawing.Size(125, 23);
            this.btnRetirada.TabIndex = 1;
            this.btnRetirada.Text = "Retirada";
            this.btnRetirada.UseVisualStyleBackColor = true;
            this.btnRetirada.Click += new System.EventHandler(this.btnRetirada_Click);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(23, 12);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(119, 17);
            this.lblConta.TabIndex = 2;
            this.lblConta.Text = "Número da Conta";
            this.lblConta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(23, 41);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(109, 17);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular da Conta";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(23, 70);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(156, 17);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor da Movimentação";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(310, 70);
            this.lblSaldo.MinimumSize = new System.Drawing.Size(125, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(125, 17);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Saldo: R$0,00";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(185, 38);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 22);
            this.txtTitular.TabIndex = 6;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(185, 67);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 7;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(185, 9);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 22);
            this.txtConta.TabIndex = 8;
            // 
            // frmQuestao3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 115);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.btnRetirada);
            this.Controls.Add(this.btnDeposito);
            this.Name = "frmQuestao3";
            this.Text = "Questão 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnRetirada;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtConta;
    }
}

