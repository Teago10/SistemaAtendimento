using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmConsultaAtendimento : Form
    {
        private ConsultaAtendimentoController _consultaAtendimentoController;

        public FrmConsultaAtendimento()
        {
            InitializeComponent();
            _consultaAtendimentoController = new ConsultaAtendimentoController(this);
        }

        private void FrmConsultaAtendimento_Load(object sender, EventArgs e)
        {
            _consultaAtendimentoController.ListarAtendimento();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema de Atendimento");
        }
        public void ExibirAtendimentos(List<Atendimentos> atendimentos)
        {
            dgvConsultaAtendimento.DataSource = atendimentos;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtFiltro.Text.Trim(); // obtém o termo de pesquisa do TextBox, removendo espaços em branco extras
            string condicao = cbxFiltro.Text.Trim(); // obtém a condição selecionada no ComboBox, ou um valor padrão se nada estiver selecionado
            _consultaAtendimentoController.ListarAtendimento(termo, condicao); // chama o método do controller para listar os atendimentos com base no termo e condição fornecidos
        }


        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvConsultaAtendimento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConsultaAtendimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pega a linha do grid que seja igual ao [] campo id
                int id = (int)dgvConsultaAtendimento.Rows[e.RowIndex].Cells["id"].Value;

                //MessageBox.Show(id.ToString());
                
                FrmAtendimento frmAtendimento = new FrmAtendimento(id);
                frmAtendimento.Show();

                this.Hide();
                
            }
        }
    }
}
