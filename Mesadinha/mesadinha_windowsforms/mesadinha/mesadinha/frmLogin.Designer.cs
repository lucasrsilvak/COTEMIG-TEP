namespace mesadinha
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.MaximumSize = new System.Drawing.Size(220, 220);
            this.panel1.MinimumSize = new System.Drawing.Size(220, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 220);
            this.panel1.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Montserrat", 18F);
            this.lbl_title.Location = new System.Drawing.Point(239, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(364, 37);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Bem-Vindo ao Sistema";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.lbl_email.Location = new System.Drawing.Point(253, 66);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(58, 18);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-mail:";
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.lbl_password.Location = new System.Drawing.Point(253, 138);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 18);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Senha:";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(246, 87);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(357, 22);
            this.txt_email.TabIndex = 4;
            this.txt_email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(246, 159);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(357, 22);
            this.txt_password.TabIndex = 5;
            this.txt_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.btn_login.Location = new System.Drawing.Point(256, 200);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(134, 32);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.btn_Register.Location = new System.Drawing.Point(451, 200);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(134, 32);
            this.btn_Register.TabIndex = 7;
            this.btn_Register.Text = "Cadastre-se";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 246);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel1);
            this.Name = "frm_login";
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_Register;
    }
}

