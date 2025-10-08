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
    public class EtapaController
    {
        private FrmCadastroEtapas _frmCadastroEtapas;
        private EtapaRepository _etapaRepository;

        public EtapaController(FrmCadastroEtapas view)
        {
            _frmCadastroEtapas = view;
            _etapaRepository = new EtapaRepository();
        }

        public void ListarEtapas(string termo = "")
        {
            try
            {
                var listaEtapas = _etapaRepository.Listar(termo);
                _frmCadastroEtapas.ExibirEtapas(listaEtapas);
            }
            catch (Exception ex)
            {
                _frmCadastroEtapas.ExibirMensagem($"Erro ao listar etapas: {ex.Message}");
            }
        }
        public void Salvar(Etapas etapa)
        {
            try
            {
                _etapaRepository.Inserir(etapa);
                _frmCadastroEtapas.ExibirMensagem("Etapa cadastrada com sucesso!");

                ListarEtapas(); // Atualiza a lista de etapas após a inserção
                _frmCadastroEtapas.DesabilitarCampos(); // desabilita os campos após salvar
            }
            catch (Exception ex)
            {
                _frmCadastroEtapas.ExibirMensagem($"Erro ao cadastrar a etapa: {ex.Message}");
            }
        }

        public void Atualizar(Etapas etapa)
        {
            try
            {
                // Implementar a lógica de atualização aqui
                _etapaRepository.Atualizar(etapa);
                _frmCadastroEtapas.ExibirMensagem("Etapa atualizada com sucesso!");
                ListarEtapas(); // Atualiza a lista de etapas após a atualização

                _frmCadastroEtapas.DesabilitarCampos(); // desabilita os campos após salvar
            }
            catch (Exception ex)
            {
                _frmCadastroEtapas.ExibirMensagem($"Erro ao atualizar a etapa: {ex.Message}");
            }
        }
    }
}
