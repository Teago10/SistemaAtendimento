using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;

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
            FrmCadastroClientes frmCadastroClientes = new FrmCadastroClientes(); //variavel()frmCadastroClientes que recebe variavel do tipo FrmCadastroClientes
            frmCadastroClientes.ShowDialog(); //ShowDialog - 
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

        }
    }
}
