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
        ConsultaAtendimentoController _consultaAtendimentoController;
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
            string condicao = cbxFiltro.SelectedItem?.ToString() ?? " "; // obtém a condição selecionada no ComboBox, ou um valor padrão se nada estiver selecionado
            _consultaAtendimentoController.ListarAtendimento(termo, condicao); // chama o método do controller para listar os atendimentos com base no termo e condição fornecidos
        }

        // Atualiza o label lblNomeCampo quando a seleção do ComboBox cbxFiltro é alterada
        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.SelectedItem != null) // verifica se um item está selecionado
            {
                lblNomeCampo.Text = cbxFiltro.SelectedItem.ToString(); // atualiza o texto do label com o item selecionado
            }
            else
            {
                lblNomeCampo.Text = string.Empty; // define um valor padrão caso nenhum item esteja selecionado
            }
        }
    }
}
