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
    public partial class FrmCadastroStatusAtendimento : Form
    {
        private SituacaoAtendimentoController _situacaoAtendimentoController;
        public FrmCadastroStatusAtendimento()
        {
            InitializeComponent();
            _situacaoAtendimentoController = new SituacaoAtendimentoController(this);
        }

        private void FrmCadastroStatusAtendimento_Load(object sender, EventArgs e)
        {
            _situacaoAtendimentoController.ListarSituacoesAtendimento();
        }
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
        public void ExibirSituacaoAtendimentos(List<SituacaoAtendimentos> situacoes)
        {
            dgvSituacaoAtendimento.DataSource = situacoes;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var situacaoAtendimentos = new SituacaoAtendimentos
            {
                Nome = txtNome.Text,
                Cor = txtCor.Text,
                Ativo = rdbAtivo.Checked
            };

            if (!ValidarDados(situacaoAtendimentos))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                _situacaoAtendimentoController.Salvar(situacaoAtendimentos);
            }
            else
            {
                situacaoAtendimentos.Id = Convert.ToInt32(txtCodigo.Text);
                _situacaoAtendimentoController.Atualizar(situacaoAtendimentos);
            }
        }

        public bool ValidarDados(SituacaoAtendimentos situacaoAtendimentos)
        {
            if (string.IsNullOrWhiteSpace(situacaoAtendimentos.Nome))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(situacaoAtendimentos.Cor))
            {
                ExibirMensagem("O campo Cor é obrigatório.");
                return false;
            }
            return true;
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtCor.ReadOnly = false;
            pnlSituacao.Enabled = true;

            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
        }
        public void DesabilitarCampos()
        {
            LimparDados();
            txtNome.ReadOnly = true;
            txtCor.ReadOnly = true;
            pnlSituacao.Enabled = false;

            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;

        }

        private void LimparDados()
        {
            txtNome.Clear();
            txtCor.Clear();
            rdbAtivo.Checked = true;
            rdbInativo.Checked = false;
        }


        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                ExibirMensagem("Selecione uma situação de atendimento para excluir.");
                return;
            }
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir essa situação de atendimento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _situacaoAtendimentoController.Excluir(id);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void dgvSituacaoAtendimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                DataGridViewRow linhaSelecionada = dgvSituacaoAtendimento.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                txtCor.Text = linhaSelecionada.Cells["Cor"].Value.ToString();
                rdbAtivo.Checked = Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);
                rdbInativo.Checked = !Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);

                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim();
            _situacaoAtendimentoController.ListarSituacoesAtendimento(termo);
        }
    }
}
