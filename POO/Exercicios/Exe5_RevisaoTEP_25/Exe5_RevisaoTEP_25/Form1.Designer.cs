namespace Exe5_RevisaoTEP_25
{
    partial class Form1
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
            this.lblDigite = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.txtAngulo1 = new System.Windows.Forms.TextBox();
            this.txtAngulo2 = new System.Windows.Forms.TextBox();
            this.txtAngulo3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDigite
            // 
            this.lblDigite.AutoSize = true;
            this.lblDigite.Location = new System.Drawing.Point(59, 12);
            this.lblDigite.Name = "lblDigite";
            this.lblDigite.Size = new System.Drawing.Size(117, 17);
            this.lblDigite.TabIndex = 0;
            this.lblDigite.Text = "Digite os ângulos";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(17, 86);
            this.lblResultado.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(200, 17);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Triângulos?";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(80, 60);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(75, 23);
            this.btnAnalisar.TabIndex = 2;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // txtAngulo1
            // 
            this.txtAngulo1.Location = new System.Drawing.Point(12, 32);
            this.txtAngulo1.Name = "txtAngulo1";
            this.txtAngulo1.Size = new System.Drawing.Size(66, 22);
            this.txtAngulo1.TabIndex = 3;
            // 
            // txtAngulo2
            // 
            this.txtAngulo2.Location = new System.Drawing.Point(84, 32);
            this.txtAngulo2.Name = "txtAngulo2";
            this.txtAngulo2.Size = new System.Drawing.Size(66, 22);
            this.txtAngulo2.TabIndex = 4;
            // 
            // txtAngulo3
            // 
            this.txtAngulo3.Location = new System.Drawing.Point(156, 32);
            this.txtAngulo3.Name = "txtAngulo3";
            this.txtAngulo3.Size = new System.Drawing.Size(66, 22);
            this.txtAngulo3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 114);
            this.Controls.Add(this.txtAngulo3);
            this.Controls.Add(this.txtAngulo2);
            this.Controls.Add(this.txtAngulo1);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDigite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDigite;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.TextBox txtAngulo1;
        private System.Windows.Forms.TextBox txtAngulo2;
        private System.Windows.Forms.TextBox txtAngulo3;
    }
}

