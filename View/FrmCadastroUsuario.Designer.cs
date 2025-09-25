namespace SistemaAtendimento.View
{
    partial class FrmCadastroUsuario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            grbDadosUsuario = new GroupBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            cbxPerfil = new ComboBox();
            lblPerfil = new Label();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnNovo = new Button();
            imlIcones = new ImageList(components);
            btnPesquisar = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            grbListaUsuario = new GroupBox();
            dgvListaUsuario = new DataGridView();
            grbDadosUsuario.SuspendLayout();
            grbListaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuario).BeginInit();
            SuspendLayout();
            // 
            // grbDadosUsuario
            // 
            grbDadosUsuario.Controls.Add(lblEmail);
            grbDadosUsuario.Controls.Add(txtEmail);
            grbDadosUsuario.Controls.Add(cbxPerfil);
            grbDadosUsuario.Controls.Add(lblPerfil);
            grbDadosUsuario.Controls.Add(lblSenha);
            grbDadosUsuario.Controls.Add(txtSenha);
            grbDadosUsuario.Controls.Add(lblNome);
            grbDadosUsuario.Controls.Add(txtNome);
            grbDadosUsuario.Controls.Add(txtCodigo);
            grbDadosUsuario.Controls.Add(lblCodigo);
            grbDadosUsuario.Location = new Point(8, 8);
            grbDadosUsuario.Name = "grbDadosUsuario";
            grbDadosUsuario.Size = new Size(784, 160);
            grbDadosUsuario.TabIndex = 0;
            grbDadosUsuario.TabStop = false;
            grbDadosUsuario.Text = "Dados do Usuário";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(480, 79);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(472, 94);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(240, 23);
            txtEmail.TabIndex = 9;
            // 
            // cbxPerfil
            // 
            cbxPerfil.Enabled = false;
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Location = new Point(248, 95);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(200, 23);
            cbxPerfil.TabIndex = 8;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(256, 80);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(34, 15);
            lblPerfil.TabIndex = 7;
            lblPerfil.Text = "Perfil";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(16, 80);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(8, 96);
            txtSenha.Name = "txtSenha";
            txtSenha.ReadOnly = true;
            txtSenha.Size = new Size(216, 23);
            txtSenha.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(200, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(192, 40);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(584, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(8, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(152, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(18, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            lblCodigo.Click += lblCodigo_Click;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(16, 200);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(72, 31);
            btnNovo.TabIndex = 5;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "icone-cancelar.png");
            imlIcones.Images.SetKeyName(1, "icone-edit.png");
            imlIcones.Images.SetKeyName(2, "icone-excluir.png");
            imlIcones.Images.SetKeyName(3, "icone-novo.png");
            imlIcones.Images.SetKeyName(4, "icone-pesquisa.png");
            imlIcones.Images.SetKeyName(5, "icone-save.png");
            imlIcones.Images.SetKeyName(6, "icone-cancelar.png");
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(696, 200);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(67, 31);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 6;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(368, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 31);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(280, 200);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 31);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(192, 200);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 31);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(104, 200);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 31);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(493, 205);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(184, 23);
            txtPesquisar.TabIndex = 10;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(501, 189);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 8;
            lblPesquisar.Text = "Pesquisar";
            // 
            // grbListaUsuario
            // 
            grbListaUsuario.Controls.Add(dgvListaUsuario);
            grbListaUsuario.Location = new Point(8, 248);
            grbListaUsuario.Name = "grbListaUsuario";
            grbListaUsuario.Size = new Size(784, 184);
            grbListaUsuario.TabIndex = 9;
            grbListaUsuario.TabStop = false;
            grbListaUsuario.Text = "Lista de Usuários";
            // 
            // dgvListaUsuario
            // 
            dgvListaUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaUsuario.Location = new Point(8, 16);
            dgvListaUsuario.Name = "dgvListaUsuario";
            dgvListaUsuario.Size = new Size(768, 158);
            dgvListaUsuario.TabIndex = 12;
            dgvListaUsuario.CellDoubleClick += dgvListaUsuario_CellDoubleClick;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbListaUsuario);
            Controls.Add(lblPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosUsuario);
            Name = "FrmCadastroUsuario";
            Text = "FrmCadastroUsuario";
            Load += FrmCadastroUsuario_Load;
            grbDadosUsuario.ResumeLayout(false);
            grbDadosUsuario.PerformLayout();
            grbListaUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosUsuario;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblPerfil;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btnNovo;
        private Button btnPesquisar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private GroupBox grbListaUsuario;
        private ImageList imlIcones;
        private DataGridView dgvListaUsuario;
        private ComboBox cbxPerfil;
        private Label lblEmail;
        private TextBox txtEmail;
    }
}