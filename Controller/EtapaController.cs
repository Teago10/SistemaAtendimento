using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class EtapaController
    {
        private FrmCadastroEtapas _frmCadastroEtapas;
        private EtapaRepository _etapaRepository;

        public EtapaController(FrmCadastroEtapas view)
        {
            _frmCadastroEtapas = view;
            _etapaRepository = new EtapaRepository();
        }

        public void ListarEtapas()
        {
            try
            {
                var listaEtapas = _etapaRepository.Listar();
                _frmCadastroEtapas.ExibirEtapas(listaEtapas);
            }
            catch (Exception ex)
            {
                _frmCadastroEtapas.ExibirMensagem($"Erro ao listar etapas: {ex.Message}");
            }
        }
    }
}
