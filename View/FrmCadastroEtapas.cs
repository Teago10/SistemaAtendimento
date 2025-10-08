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
    public partial class FrmCadastroEtapas : Form
    {
        private EtapaController _etapaController;
        public FrmCadastroEtapas()
        {
            InitializeComponent();
            _etapaController = new EtapaController(this);
        }

        private void FrmCadastroEtapas_Load(object sender, EventArgs e)
        {
            _etapaController.ListarEtapas();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirEtapas(List<Etapas> etapas)
        {
            dgvListaEtapas.DataSource = etapas;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var etapa = new Etapas
            {
                Nome = txtNome.Text,
                Ordem = Convert.ToInt32(txtOrdem.Text),
                Ativo = rdbAtivo.Checked
            };
            if (!ValidarDados(etapa))
                return;

            if (string.IsNullOrWhiteSpace(txtCodigo.Text)) // se o campo código estiver vazio, é um novo cadastro
            {
                _etapaController.Salvar(etapa);
            }
            else // se o campo código tiver preenchido, é uma atualização
            {
                etapa.Id = Convert.ToInt32(txtCodigo.Text);
                _etapaController.Atualizar(etapa);
            }
        }

        public bool ValidarDados(Etapas etapa)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtOrdem.Text))
            {
                ExibirMensagem("O campo Ordem é obrigatório.");
                txtOrdem.Focus();
                return false;
            }

            return true;
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtOrdem.ReadOnly = false;
            pnlSituacao.Enabled = true;

            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
        }
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtOrdem.Clear();
            rdbAtivo.Checked = true;
            rdbInativo.Checked = false;
        }
        public void DesabilitarCampos()
        {
            LimparCampos();
            txtNome.ReadOnly = true;
            txtOrdem.ReadOnly = true;
            pnlSituacao.Enabled = false;

            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
        }


        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            // IGNORAR
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvListaEtapas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvListaEtapas.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                txtOrdem.Text = linhaSelecionada.Cells["Ordem"].Value.ToString();
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
            _etapaController.ListarEtapas(termo);
        }
    }
}
