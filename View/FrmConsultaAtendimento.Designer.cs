namespace SistemaAtendimento.View
{
    partial class FrmConsultaAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaAtendimento));
            dgvConsultaAtendimento = new DataGridView();
            imlIcone = new ImageList(components);
            grbFiltrar = new GroupBox();
            lblNomeCampo = new Label();
            cbxFiltro = new ComboBox();
            btnPesquisar = new Button();
            txtFiltro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).BeginInit();
            grbFiltrar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvConsultaAtendimento
            // 
            dgvConsultaAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaAtendimento.Location = new Point(8, 96);
            dgvConsultaAtendimento.Name = "dgvConsultaAtendimento";
            dgvConsultaAtendimento.ReadOnly = true;
            dgvConsultaAtendimento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultaAtendimento.Size = new Size(784, 336);
            dgvConsultaAtendimento.TabIndex = 0;
            dgvConsultaAtendimento.CellContentClick += dgvConsultaAtendimento_CellContentClick;
            dgvConsultaAtendimento.CellDoubleClick += dgvConsultaAtendimento_CellDoubleClick;
            // 
            // imlIcone
            // 
            imlIcone.ColorDepth = ColorDepth.Depth32Bit;
            imlIcone.ImageStream = (ImageListStreamer)resources.GetObject("imlIcone.ImageStream");
            imlIcone.TransparentColor = Color.Transparent;
            imlIcone.Images.SetKeyName(0, "icone-pesquisa.png");
            // 
            // grbFiltrar
            // 
            grbFiltrar.Controls.Add(lblNomeCampo);
            grbFiltrar.Controls.Add(cbxFiltro);
            grbFiltrar.Controls.Add(btnPesquisar);
            grbFiltrar.Controls.Add(txtFiltro);
            grbFiltrar.Location = new Point(8, 8);
            grbFiltrar.Name = "grbFiltrar";
            grbFiltrar.Size = new Size(784, 72);
            grbFiltrar.TabIndex = 7;
            grbFiltrar.TabStop = false;
            grbFiltrar.Text = "Filtrar por";
            // 
            // lblNomeCampo
            // 
            lblNomeCampo.AutoSize = true;
            lblNomeCampo.Location = new Point(224, 16);
            lblNomeCampo.Name = "lblNomeCampo";
            lblNomeCampo.Size = new Size(0, 15);
            lblNomeCampo.TabIndex = 11;
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Código de Atendimento", "Nome do Cliente", "CPF", "CNPJ" });
            cbxFiltro.Location = new Point(8, 34);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(191, 23);
            cbxFiltro.TabIndex = 10;
            cbxFiltro.SelectedIndexChanged += cbxFiltro_SelectedIndexChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.ImageKey = "icone-pesquisa.png";
            btnPesquisar.ImageList = imlIcone;
            btnPesquisar.Location = new Point(615, 29);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(151, 31);
            btnPesquisar.TabIndex = 8;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(216, 33);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(384, 23);
            txtFiltro.TabIndex = 7;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // FrmConsultaAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbFiltrar);
            Controls.Add(dgvConsultaAtendimento);
            Name = "FrmConsultaAtendimento";
            Text = "Consulta de Atendimento";
            Load += FrmConsultaAtendimento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).EndInit();
            grbFiltrar.ResumeLayout(false);
            grbFiltrar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConsultaAtendimento;
        private ImageList imlIcone;
        private GroupBox grbFiltrar;
        private ComboBox cbxFiltro;
        private Button btnPesquisar;
        private TextBox txtFiltro;
        private Label lblNomeCampo;
    }
}