using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class SituacaoAtendimentoController
    {
        private FrmCadastroStatusAtendimento _frmCadastroStatusAtendimento;
        private SituacaoAtendimentoRepository _situacaoAtendimentoRepository;

        public SituacaoAtendimentoController(FrmCadastroStatusAtendimento view) 
        {
            _frmCadastroStatusAtendimento = view;
            _situacaoAtendimentoRepository = new SituacaoAtendimentoRepository();
        }
        public void ListarSituacoesAtendimento()
        {
            try 
            { 
                var listaSituacaoAtendimentos = _situacaoAtendimentoRepository.Listar();
                _frmCadastroStatusAtendimento.ExibirSituacaoAtendimentos(listaSituacaoAtendimentos);
            }
            catch (Exception ex)
            {
                // Tratar exceção (exibir mensagem de erro, log, etc.)
                _frmCadastroStatusAtendimento.ExibirMensagem($"Erro ao listar situações de atendimento: { ex.Message}");
            }
        }
    }
}
