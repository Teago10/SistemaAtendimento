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
    }
}
