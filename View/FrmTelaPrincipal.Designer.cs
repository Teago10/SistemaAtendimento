namespace SistemaAtendimento
{
    partial class FrmTelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuPrincipal = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            etapasToolStripMenuItem = new ToolStripMenuItem();
            situacaoAtendimentoToolStripMenuItem = new ToolStripMenuItem();
            atendimentoToolStripMenuItem = new ToolStripMenuItem();
            novoAtendimentoToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            sistemasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            relatótiosToolStripMenuItem = new ToolStripMenuItem();
            listaDeClientesToolStripMenuItem = new ToolStripMenuItem();
            listaDeToolStripMenuItem = new ToolStripMenuItem();
            listaDeUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            listaDeToolStripMenuItem1 = new ToolStripMenuItem();
            btnConexao = new Button();
            statusStrip1 = new StatusStrip();
            slblNome = new ToolStripStatusLabel();
            slblPerfil = new ToolStripStatusLabel();
            mnuPrincipal.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, atendimentoToolStripMenuItem, sistemasToolStripMenuItem, relatótiosToolStripMenuItem });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(800, 24);
            mnuPrincipal.TabIndex = 0;
            mnuPrincipal.Text = "menuStrip1";
            mnuPrincipal.ItemClicked += mnuPrincipal_ItemClicked;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, usuáriosToolStripMenuItem, etapasToolStripMenuItem, situacaoAtendimentoToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(69, 20);
            cadastroToolStripMenuItem.Text = "Cadastro ";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(192, 22);
            clienteToolStripMenuItem.Text = "Clientes";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(192, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // etapasToolStripMenuItem
            // 
            etapasToolStripMenuItem.Name = "etapasToolStripMenuItem";
            etapasToolStripMenuItem.Size = new Size(192, 22);
            etapasToolStripMenuItem.Text = "Etapas";
            etapasToolStripMenuItem.Click += etapasToolStripMenuItem_Click;
            // 
            // situacaoAtendimentoToolStripMenuItem
            // 
            situacaoAtendimentoToolStripMenuItem.Name = "situacaoAtendimentoToolStripMenuItem";
            situacaoAtendimentoToolStripMenuItem.Size = new Size(192, 22);
            situacaoAtendimentoToolStripMenuItem.Text = "Situação Atendimento";
            situacaoAtendimentoToolStripMenuItem.Click += statusAtendimentoToolStripMenuItem_Click;
            // 
            // atendimentoToolStripMenuItem
            // 
            atendimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoAtendimentoToolStripMenuItem, consultasToolStripMenuItem });
            atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            atendimentoToolStripMenuItem.Size = new Size(89, 20);
            atendimentoToolStripMenuItem.Text = "Atendimento";
            // 
            // novoAtendimentoToolStripMenuItem
            // 
            novoAtendimentoToolStripMenuItem.Name = "novoAtendimentoToolStripMenuItem";
            novoAtendimentoToolStripMenuItem.Size = new Size(144, 22);
            novoAtendimentoToolStripMenuItem.Text = "Atendimento";
            novoAtendimentoToolStripMenuItem.Click += novoAtendimentoToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(144, 22);
            consultasToolStripMenuItem.Text = "Consultas";
            consultasToolStripMenuItem.Click += consultasToolStripMenuItem_Click;
            // 
            // sistemasToolStripMenuItem
            // 
            sistemasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            sistemasToolStripMenuItem.Size = new Size(65, 20);
            sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // relatótiosToolStripMenuItem
            // 
            relatótiosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeClientesToolStripMenuItem, listaDeToolStripMenuItem, listaDeUsuáriosToolStripMenuItem, listaDeToolStripMenuItem1 });
            relatótiosToolStripMenuItem.Name = "relatótiosToolStripMenuItem";
            relatótiosToolStripMenuItem.Size = new Size(71, 20);
            relatótiosToolStripMenuItem.Text = "Relatórios";
            // 
            // listaDeClientesToolStripMenuItem
            // 
            listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            listaDeClientesToolStripMenuItem.Size = new Size(187, 22);
            listaDeClientesToolStripMenuItem.Text = "Lista de Clientes";
            listaDeClientesToolStripMenuItem.Click += listaDeClientesToolStripMenuItem_Click;
            // 
            // listaDeToolStripMenuItem
            // 
            listaDeToolStripMenuItem.Name = "listaDeToolStripMenuItem";
            listaDeToolStripMenuItem.Size = new Size(187, 22);
            listaDeToolStripMenuItem.Text = "Lista de Usuários";
            listaDeToolStripMenuItem.Click += listaDeToolStripMenuItem_Click;
            // 
            // listaDeUsuáriosToolStripMenuItem
            // 
            listaDeUsuáriosToolStripMenuItem.Name = "listaDeUsuáriosToolStripMenuItem";
            listaDeUsuáriosToolStripMenuItem.Size = new Size(187, 22);
            listaDeUsuáriosToolStripMenuItem.Text = "Lista de Etapas";
            listaDeUsuáriosToolStripMenuItem.Click += listaDeUsuáriosToolStripMenuItem_Click;
            // 
            // listaDeToolStripMenuItem1
            // 
            listaDeToolStripMenuItem1.Name = "listaDeToolStripMenuItem1";
            listaDeToolStripMenuItem1.Size = new Size(187, 22);
            listaDeToolStripMenuItem1.Text = "Lista de Atendimento";
            listaDeToolStripMenuItem1.Click += listaDeToolStripMenuItem1_Click;
            // 
            // btnConexao
            // 
            btnConexao.Location = new Point(680, 360);
            btnConexao.Name = "btnConexao";
            btnConexao.Size = new Size(99, 23);
            btnConexao.TabIndex = 1;
            btnConexao.Text = "Teste Conexão";
            btnConexao.UseVisualStyleBackColor = true;
            btnConexao.Click += btnConexao_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { slblNome, slblPerfil });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // slblNome
            // 
            slblNome.Name = "slblNome";
            slblNome.Size = new Size(40, 17);
            slblNome.Text = "Nome";
            slblNome.Click += toolStripStatusLabel1_Click;
            // 
            // slblPerfil
            // 
            slblPerfil.Name = "slblPerfil";
            slblPerfil.Size = new Size(34, 17);
            slblPerfil.Text = "Perfil";
            // 
            // FrmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(btnConexao);
            Controls.Add(mnuPrincipal);
            MainMenuStrip = mnuPrincipal;
            Name = "FrmTelaPrincipal";
            Text = "Sistema de Atendimento";
            FormClosed += FrmTelaPrincipal_FormClosed;
            Load += FrmTelaPrincipal_Load;
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuPrincipal;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem etapasToolStripMenuItem;
        private ToolStripMenuItem situacaoAtendimentoToolStripMenuItem;
        private ToolStripMenuItem atendimentoToolStripMenuItem;
        private ToolStripMenuItem novoAtendimentoToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem sistemasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Button btnConexao;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel slblNome;
        private ToolStripStatusLabel slblPerfil;
        private ToolStripMenuItem relatótiosToolStripMenuItem;
        private ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private ToolStripMenuItem listaDeToolStripMenuItem;
        private ToolStripMenuItem listaDeUsuáriosToolStripMenuItem;
        private ToolStripMenuItem listaDeToolStripMenuItem1;
    }
}
