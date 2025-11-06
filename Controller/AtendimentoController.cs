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
    public class AtendimentoController
    {
        private FrmAtendimento _frmAtendimento;
        private AtendimentoRepository _atendimentoRepository;
        private ClienteRepository _clienteRepository;
        private SituacaoAtendimentoRepository _situacaoRepository;
        private EtapaRepository _etapaRepository;

        public AtendimentoController(FrmAtendimento view) // construtor que recebe a view como parâmetro
        {
            _frmAtendimento = view;
            _atendimentoRepository = new AtendimentoRepository();
            _clienteRepository = new ClienteRepository();
            _situacaoRepository = new SituacaoAtendimentoRepository();
            _etapaRepository = new EtapaRepository();
        }

        // método para listar clientes. List<Clientes> esta pegando do model
        public List<Clientes> ListarClientes()
        {
            return _clienteRepository.Listar(); //chama o método Listar do ClienteRepository para obter a lista de clientes
        }

        public List<SituacaoAtendimentos> ListarSituacao()
        {
            return _situacaoRepository.Listar();
        }
        public List<Etapas> ListarEtapas()
        {
            return _etapaRepository.Listar();
        }
        public void Salvar(Atendimentos atendimento)
        {
            try
            {
                _atendimentoRepository.Inserir(atendimento);
                _frmAtendimento.ExibirMensagem("Atendimento Salvo com Sucesso");
            }
            catch (Exception ex)
            {
                _frmAtendimento.ExibirMensagem($"Erro ao Cadastrar o Atendimento: {ex.Message}");
            }
        }
    }
}
