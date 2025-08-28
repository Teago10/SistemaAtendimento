using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.View;

namespace SistemaAtendimento
{
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
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
    }
}
