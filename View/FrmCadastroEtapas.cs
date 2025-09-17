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
                Ordem = Convert.ToInt32(txtSenha.Text),
                Ativo = rdbAtivo.Checked
            };
            if(!ValidarDados(etapa))
                return;
            
            _etapaController.Salvar(etapa);
        }

        public bool ValidarDados(Etapas etapa)
        {
            if(string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                ExibirMensagem("O campo Senha é obrigatório.");
                txtSenha.Focus();
                return false;
            }
            
            return true;
        }
    }
}
