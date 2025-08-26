namespace mesadinha
{
    partial class frm_register
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_telephone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.txt_telephone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(12, 133);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(289, 22);
            this.txt_email.TabIndex = 10;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 85);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(289, 22);
            this.txt_name.TabIndex = 9;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.lbl_password.Location = new System.Drawing.Point(12, 159);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 18);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Senha:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.lbl_name.Location = new System.Drawing.Point(12, 63);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(56, 18);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Nome:";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Montserrat", 18F);
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(289, 37);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "Faça seu cadastro";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(12, 181);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(289, 22);
            this.txt_password.TabIndex = 13;
            // 
            // lbl_telephone
            // 
            this.lbl_telephone.AutoSize = true;
            this.lbl_telephone.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.lbl_telephone.Location = new System.Drawing.Point(12, 255);
            this.lbl_telephone.Name = "lbl_telephone";
            this.lbl_telephone.Size = new System.Drawing.Size(70, 18);
            this.lbl_telephone.TabIndex = 12;
            this.lbl_telephone.Text = "Telefone";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.lbl_email.Location = new System.Drawing.Point(12, 111);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(58, 18);
            this.lbl_email.TabIndex = 11;
            this.lbl_email.Text = "E-mail:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(12, 229);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(289, 22);
            this.txt_address.TabIndex = 16;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.lbl_address.Location = new System.Drawing.Point(12, 207);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(80, 18);
            this.lbl_address.TabIndex = 15;
            this.lbl_address.Text = "Endereço:";
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.btn_register.Location = new System.Drawing.Point(188, 305);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(113, 33);
            this.btn_register.TabIndex = 18;
            this.btn_register.Text = "Enviar";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("Montserrat", 7.8F);
            this.btn_return.Location = new System.Drawing.Point(12, 305);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(113, 33);
            this.btn_return.TabIndex = 17;
            this.btn_return.Text = "Voltar";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // txt_telephone
            // 
            this.txt_telephone.Location = new System.Drawing.Point(12, 277);
            this.txt_telephone.Mask = "(99) 00000-0000";
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(289, 22);
            this.txt_telephone.TabIndex = 19;
            this.txt_telephone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // frm_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 348);
            this.Controls.Add(this.txt_telephone);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_telephone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_title);
            this.Name = "frm_register";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frm_register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_telephone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.MaskedTextBox txt_telephone;
    }
}