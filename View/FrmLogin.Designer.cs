namespace SistemaAtendimento.View
{
    partial class FrmLogin
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
            btnEntrar = new Button();
            lblEmail = new Label();
            lblSenha = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            lblAcessar = new Label();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(104, 176);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(96, 32);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(8, 72);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(8, 123);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(55, 69);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(55, 120);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(233, 23);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblAcessar
            // 
            lblAcessar.AutoSize = true;
            lblAcessar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcessar.Location = new Point(104, 24);
            lblAcessar.Name = "lblAcessar";
            lblAcessar.Size = new Size(84, 20);
            lblAcessar.TabIndex = 5;
            lblAcessar.Text = "Bem vindo";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 257);
            Controls.Add(lblAcessar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(btnEntrar);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Label lblEmail;
        private Label lblSenha;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lblAcessar;
    }
}