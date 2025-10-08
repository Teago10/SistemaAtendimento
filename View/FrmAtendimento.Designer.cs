namespace SistemaAtendimento.View
{
    partial class FrmAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtendimento));
            lblAtendimento = new Label();
            lblDadosCliente = new Label();
            txtCodigoAtendimento = new TextBox();
            grbDadosCliente = new GroupBox();
            cbxSituacaoAtendimento = new ComboBox();
            lblSituacaoAtendimento = new Label();
            dtpAberturaAtendimento = new DateTimePicker();
            lblDataAbertura = new Label();
            cbxNomeCliente = new TextBox();
            txtCodigoCliente = new TextBox();
            lblNome = new Label();
            lblCodigoCliente = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtObservaccaoAtendimento = new TextBox();
            lblObservacoes = new Label();
            imlIcones = new ImageList(components);
            grbEtapasAtendimento = new GroupBox();
            lblEtapaAtendimento = new Label();
            cbxEtapaAtendimento = new ComboBox();
            txtEtapaObservacao = new TextBox();
            btnExcluirEtapa = new Button();
            btnAdicionarEtapa = new Button();
            lblObservações = new Label();
            dgvEtapasAtendimento = new DataGridView();
            btnPesquisarAtendimento = new Button();
            btnNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnFinalizar = new Button();
            grbDadosCliente.SuspendLayout();
            grbEtapasAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).BeginInit();
            SuspendLayout();
            // 
            // lblAtendimento
            // 
            lblAtendimento.AutoSize = true;
            lblAtendimento.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAtendimento.Location = new Point(560, 15);
            lblAtendimento.Name = "lblAtendimento";
            lblAtendimento.Size = new Size(115, 21);
            lblAtendimento.TabIndex = 0;
            lblAtendimento.Text = "Atendimento:";
            lblAtendimento.Click += lblAtendimento_Click;
            // 
            // lblDadosCliente
            // 
            lblDadosCliente.AutoSize = true;
            lblDadosCliente.Location = new Point(24, 48);
            lblDadosCliente.Name = "lblDadosCliente";
            lblDadosCliente.Size = new Size(0, 15);
            lblDadosCliente.TabIndex = 1;
            // 
            // txtCodigoAtendimento
            // 
            txtCodigoAtendimento.Location = new Point(680, 16);
            txtCodigoAtendimento.Name = "txtCodigoAtendimento";
            txtCodigoAtendimento.Size = new Size(100, 23);
            txtCodigoAtendimento.TabIndex = 2;
            // 
            // grbDadosCliente
            // 
            grbDadosCliente.Controls.Add(btnFinalizar);
            grbDadosCliente.Controls.Add(btnExcluir);
            grbDadosCliente.Controls.Add(btnEditar);
            grbDadosCliente.Controls.Add(btnNovo);
            grbDadosCliente.Controls.Add(lblObservacoes);
            grbDadosCliente.Controls.Add(txtObservaccaoAtendimento);
            grbDadosCliente.Controls.Add(btnCancelar);
            grbDadosCliente.Controls.Add(btnSalvar);
            grbDadosCliente.Controls.Add(cbxSituacaoAtendimento);
            grbDadosCliente.Controls.Add(lblSituacaoAtendimento);
            grbDadosCliente.Controls.Add(dtpAberturaAtendimento);
            grbDadosCliente.Controls.Add(lblDataAbertura);
            grbDadosCliente.Controls.Add(cbxNomeCliente);
            grbDadosCliente.Controls.Add(txtCodigoCliente);
            grbDadosCliente.Controls.Add(lblNome);
            grbDadosCliente.Controls.Add(lblCodigoCliente);
            grbDadosCliente.Location = new Point(8, 56);
            grbDadosCliente.Name = "grbDadosCliente";
            grbDadosCliente.Size = new Size(784, 208);
            grbDadosCliente.TabIndex = 11;
            grbDadosCliente.TabStop = false;
            grbDadosCliente.Text = "Dados do Cliente";
            grbDadosCliente.Enter += grbDadosCliente_Enter;
            // 
            // cbxSituacaoAtendimento
            // 
            cbxSituacaoAtendimento.FormattingEnabled = true;
            cbxSituacaoAtendimento.Location = new Point(8, 84);
            cbxSituacaoAtendimento.Name = "cbxSituacaoAtendimento";
            cbxSituacaoAtendimento.Size = new Size(184, 23);
            cbxSituacaoAtendimento.TabIndex = 18;
            // 
            // lblSituacaoAtendimento
            // 
            lblSituacaoAtendimento.AutoSize = true;
            lblSituacaoAtendimento.Location = new Point(8, 68);
            lblSituacaoAtendimento.Name = "lblSituacaoAtendimento";
            lblSituacaoAtendimento.Size = new Size(142, 15);
            lblSituacaoAtendimento.TabIndex = 17;
            lblSituacaoAtendimento.Text = "Situação do Atendimento";
            // 
            // dtpAberturaAtendimento
            // 
            dtpAberturaAtendimento.Location = new Point(512, 39);
            dtpAberturaAtendimento.Name = "dtpAberturaAtendimento";
            dtpAberturaAtendimento.Size = new Size(208, 23);
            dtpAberturaAtendimento.TabIndex = 16;
            // 
            // lblDataAbertura
            // 
            lblDataAbertura.AutoSize = true;
            lblDataAbertura.Location = new Point(519, 22);
            lblDataAbertura.Name = "lblDataAbertura";
            lblDataAbertura.Size = new Size(80, 15);
            lblDataAbertura.TabIndex = 15;
            lblDataAbertura.Text = "Data Abertura";
            // 
            // cbxNomeCliente
            // 
            cbxNomeCliente.Location = new Point(127, 40);
            cbxNomeCliente.Name = "cbxNomeCliente";
            cbxNomeCliente.Size = new Size(336, 23);
            cbxNomeCliente.TabIndex = 14;
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(8, 40);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(93, 23);
            txtCodigoCliente.TabIndex = 13;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(128, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome";
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.Location = new Point(8, 24);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(72, 15);
            lblCodigoCliente.TabIndex = 11;
            lblCodigoCliente.Text = "Cód. Cliente";
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 0;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(216, 168);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 32);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "    Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 1;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(432, 168);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 32);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "    Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtObservaccaoAtendimento
            // 
            txtObservaccaoAtendimento.Location = new Point(250, 83);
            txtObservaccaoAtendimento.Multiline = true;
            txtObservaccaoAtendimento.Name = "txtObservaccaoAtendimento";
            txtObservaccaoAtendimento.Size = new Size(464, 80);
            txtObservaccaoAtendimento.TabIndex = 21;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Location = new Point(249, 67);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(74, 15);
            lblObservacoes.TabIndex = 22;
            lblObservacoes.Text = "Observações";
            lblObservacoes.TextAlign = ContentAlignment.TopCenter;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "icone-save.png");
            imlIcones.Images.SetKeyName(1, "icone-cancelar.png");
            imlIcones.Images.SetKeyName(2, "icone-edit.png");
            imlIcones.Images.SetKeyName(3, "icone-excluir.png");
            imlIcones.Images.SetKeyName(4, "icone-novo.png");
            imlIcones.Images.SetKeyName(5, "icone-pesquisa.png");
            imlIcones.Images.SetKeyName(6, "Finalizar.png");
            // 
            // grbEtapasAtendimento
            // 
            grbEtapasAtendimento.Controls.Add(dgvEtapasAtendimento);
            grbEtapasAtendimento.Controls.Add(lblObservações);
            grbEtapasAtendimento.Controls.Add(btnExcluirEtapa);
            grbEtapasAtendimento.Controls.Add(btnAdicionarEtapa);
            grbEtapasAtendimento.Controls.Add(txtEtapaObservacao);
            grbEtapasAtendimento.Controls.Add(cbxEtapaAtendimento);
            grbEtapasAtendimento.Controls.Add(lblEtapaAtendimento);
            grbEtapasAtendimento.Location = new Point(8, 272);
            grbEtapasAtendimento.Name = "grbEtapasAtendimento";
            grbEtapasAtendimento.Size = new Size(784, 224);
            grbEtapasAtendimento.TabIndex = 12;
            grbEtapasAtendimento.TabStop = false;
            grbEtapasAtendimento.Text = "Etapas do Atendimento";
            // 
            // lblEtapaAtendimento
            // 
            lblEtapaAtendimento.AutoSize = true;
            lblEtapaAtendimento.Location = new Point(8, 21);
            lblEtapaAtendimento.Name = "lblEtapaAtendimento";
            lblEtapaAtendimento.Size = new Size(126, 15);
            lblEtapaAtendimento.TabIndex = 0;
            lblEtapaAtendimento.Text = "Etapa do Atendimento";
            // 
            // cbxEtapaAtendimento
            // 
            cbxEtapaAtendimento.FormattingEnabled = true;
            cbxEtapaAtendimento.Location = new Point(8, 37);
            cbxEtapaAtendimento.Name = "cbxEtapaAtendimento";
            cbxEtapaAtendimento.Size = new Size(184, 23);
            cbxEtapaAtendimento.TabIndex = 19;
            // 
            // txtEtapaObservacao
            // 
            txtEtapaObservacao.Location = new Point(8, 80);
            txtEtapaObservacao.Multiline = true;
            txtEtapaObservacao.Name = "txtEtapaObservacao";
            txtEtapaObservacao.Size = new Size(264, 72);
            txtEtapaObservacao.TabIndex = 22;
            // 
            // btnExcluirEtapa
            // 
            btnExcluirEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirEtapa.ImageIndex = 1;
            btnExcluirEtapa.ImageList = imlIcones;
            btnExcluirEtapa.Location = new Point(160, 168);
            btnExcluirEtapa.Name = "btnExcluirEtapa";
            btnExcluirEtapa.Size = new Size(112, 32);
            btnExcluirEtapa.TabIndex = 24;
            btnExcluirEtapa.Text = "    Excluir Etapa";
            btnExcluirEtapa.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarEtapa
            // 
            btnAdicionarEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarEtapa.ImageIndex = 4;
            btnAdicionarEtapa.ImageList = imlIcones;
            btnAdicionarEtapa.Location = new Point(8, 168);
            btnAdicionarEtapa.Name = "btnAdicionarEtapa";
            btnAdicionarEtapa.Size = new Size(136, 32);
            btnAdicionarEtapa.TabIndex = 23;
            btnAdicionarEtapa.Text = "    Adicionar Etapa";
            btnAdicionarEtapa.UseVisualStyleBackColor = true;
            // 
            // lblObservações
            // 
            lblObservações.AutoSize = true;
            lblObservações.Location = new Point(8, 64);
            lblObservações.Name = "lblObservações";
            lblObservações.Size = new Size(74, 15);
            lblObservações.TabIndex = 25;
            lblObservações.Text = "Observações";
            // 
            // dgvEtapasAtendimento
            // 
            dgvEtapasAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtapasAtendimento.Location = new Point(304, 16);
            dgvEtapasAtendimento.Name = "dgvEtapasAtendimento";
            dgvEtapasAtendimento.Size = new Size(472, 200);
            dgvEtapasAtendimento.TabIndex = 26;
            // 
            // btnPesquisarAtendimento
            // 
            btnPesquisarAtendimento.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisarAtendimento.ImageIndex = 5;
            btnPesquisarAtendimento.ImageList = imlIcones;
            btnPesquisarAtendimento.Location = new Point(16, 8);
            btnPesquisarAtendimento.Name = "btnPesquisarAtendimento";
            btnPesquisarAtendimento.Size = new Size(176, 32);
            btnPesquisarAtendimento.TabIndex = 21;
            btnPesquisarAtendimento.Text = "      Pesquisar Atendimento";
            btnPesquisarAtendimento.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 4;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(8, 168);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(88, 32);
            btnNovo.TabIndex = 23;
            btnNovo.Text = "    Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 2;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(112, 168);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 32);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "    Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 3;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(320, 168);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(99, 32);
            btnExcluir.TabIndex = 25;
            btnExcluir.Text = "    Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizar.ImageIndex = 6;
            btnFinalizar.ImageList = imlIcones;
            btnFinalizar.Location = new Point(608, 168);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(160, 32);
            btnFinalizar.TabIndex = 26;
            btnFinalizar.Text = "       Finalizar Atendimento ";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // FrmAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(btnPesquisarAtendimento);
            Controls.Add(grbEtapasAtendimento);
            Controls.Add(grbDadosCliente);
            Controls.Add(txtCodigoAtendimento);
            Controls.Add(lblDadosCliente);
            Controls.Add(lblAtendimento);
            Name = "FrmAtendimento";
            Text = "Atendimento";
            grbDadosCliente.ResumeLayout(false);
            grbDadosCliente.PerformLayout();
            grbEtapasAtendimento.ResumeLayout(false);
            grbEtapasAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAtendimento;
        private Label lblDadosCliente;
        private TextBox txtCodigoAtendimento;
        private GroupBox grbDadosCliente;
        private Button btnCancelar;
        private Button btnSalvar;
        private ComboBox cbxSituacaoAtendimento;
        private Label lblSituacaoAtendimento;
        private DateTimePicker dtpAberturaAtendimento;
        private Label lblDataAbertura;
        private TextBox cbxNomeCliente;
        private TextBox txtCodigoCliente;
        private Label lblNome;
        private Label lblCodigoCliente;
        private Label lblObservacoes;
        private TextBox txtObservaccaoAtendimento;
        private ImageList imlIcones;
        private GroupBox grbEtapasAtendimento;
        private Label lblEtapaAtendimento;
        private ComboBox cbxEtapaAtendimento;
        private Button btnExcluirEtapa;
        private Button btnAdicionarEtapa;
        private TextBox txtEtapaObservacao;
        private Label lblObservações;
        private DataGridView dgvEtapasAtendimento;
        private Button btnPesquisarAtendimento;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnNovo;
        private Button btnFinalizar;
    }
}