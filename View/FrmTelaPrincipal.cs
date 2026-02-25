using Microsoft.Data.SqlClient;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;
using SistemaAtendimento.View;

namespace SistemaAtendimento
{
    public partial class FrmTelaPrincipal : Form
    {

        private Usuarios _usuarioLogado;
        public FrmTelaPrincipal(Usuarios usuario)
        {
            InitializeComponent();

            _usuarioLogado = usuario;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroClientes frmCadastroClientes = new FrmCadastroClientes();
            frmCadastroClientes.ShowDialog();
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = ConexaoDB.GetConexao())
                {
                    conexao.Open();
                    MessageBox.Show("Conexão Realizada com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar:" + ex.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //fecha toda a aplicação
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_usuarioLogado.Perfil != "admin")
            {
                MessageBox.Show("Você não tem permisão para mexer nessa tela");
                return;
            }
            FrmCadastroUsuario frmCadastroUsuario = new FrmCadastroUsuario();
            frmCadastroUsuario.ShowDialog();
        }

        private void etapasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroEtapas frmCadastroEtapas = new FrmCadastroEtapas();
            frmCadastroEtapas.ShowDialog();
        }

        private void statusAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroStatusAtendimento frmCadastroStatusAtendimento = new FrmCadastroStatusAtendimento();
            frmCadastroStatusAtendimento.ShowDialog();
        }

        private void FrmTelaPrincipal_Load(object sender, EventArgs e)
        {
            slblNome.Text = $"Usuário: {_usuarioLogado.Nome}";
            slblPerfil.Text = $"Perfil: {_usuarioLogado.Perfil}";
        }

        private void novoAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtendimento frmAtendimento = new FrmAtendimento();
            frmAtendimento.ShowDialog(); // abre o formulário como uma janela modal
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendimento _frmConsultaAtendimento = new FrmConsultaAtendimento();
            _frmConsultaAtendimento.Show();
        }

        private void FrmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mnuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var clienteController = new ClienteController(null);
                clienteController.GerarRelatorioPDF();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar o relatório:{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void listaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var usuarioController = new UsuarioController(null);
                usuarioController.GerarRelatorioUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar o relatório:{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void listaDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var etapaController = new EtapaController(null);
                etapaController.GerarRelatorioEtapa();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar o relatório:{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void listaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var situacaoAtendimentoController = new SituacaoAtendimentoController(null);
                situacaoAtendimentoController.GerarRelatorioSituacaoAtendimentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar o relatório:{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
