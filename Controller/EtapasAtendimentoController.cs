using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class EtapasAtendimentoController
    {
        private EtapasAtendimentoRepository _etapasAtendimentoRepository; 
        private FrmAtendimento _frmAtendimento;
        
        public EtapasAtendimentoController(FrmAtendimento view)
        {
            _etapasAtendimentoRepository = new EtapasAtendimentoRepository();
        }

        public List<EtapaAtendimentos> Listar(int atendimentoId)
        {
            return _etapasAtendimentoRepository.Listar(atendimentoId);
        }
        public void Salvar(EtapaAtendimentos etapaAtendimentos)
        {
            try
            {
                _etapasAtendimentoRepository.Inserir(etapaAtendimentos);
                _frmAtendimento.ExibirMensagem("Atendimento Etapa Salvo com Sucesso.");
            }
            catch (Exception ex) 
            {
                _frmAtendimento.ExibirMensagem($"Erro ao Cadastrar o Atendimento Etapa: {ex.Message}");
            }

        }

        public void Excluir(int id)
        {
            try
            {
                _etapasAtendimentoRepository.Excluir(id);
                _frmAtendimento.ExibirMensagem("Etapa do Atendimento Excluida com Secesso.");
            }
            catch (Exception ex) 
            {
                _frmAtendimento.ExibirMensagem($"Erro ao Excluir Etapa do Atendimento: {ex.Message}");
            }
        }
    }
}
