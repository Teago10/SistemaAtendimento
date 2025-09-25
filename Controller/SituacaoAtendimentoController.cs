﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
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

        public void Salvar(SituacaoAtendimentos situacaoAtendimentos)
        {
            try
            {
                _situacaoAtendimentoRepository.Inserir(situacaoAtendimentos);
                _frmCadastroStatusAtendimento.ExibirMensagem("Situação de atendimento cadastrada com sucesso!");
                ListarSituacoesAtendimento();
                _frmCadastroStatusAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroStatusAtendimento.ExibirMensagem($"Erro ao salvar situação de atendimento: {ex.Message}");
            }
        }

        public void Atualizar(SituacaoAtendimentos situacaoAtendimentos)
        {
            try
            {
                _situacaoAtendimentoRepository.Atualizar(situacaoAtendimentos);
                _frmCadastroStatusAtendimento.ExibirMensagem("Situação de atendimento atualizada com sucesso!");
                ListarSituacoesAtendimento();
                _frmCadastroStatusAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroStatusAtendimento.ExibirMensagem($"Erro ao atualizar situação de atendimento: {ex.Message}");
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _situacaoAtendimentoRepository.Excluir(id);
                _frmCadastroStatusAtendimento.ExibirMensagem("Situação de atendimento excluída com sucesso!");
                ListarSituacoesAtendimento();
            }
            catch (Exception ex)
            {
                _frmCadastroStatusAtendimento.ExibirMensagem($"Erro ao excluir situação de atendimento: {ex.Message}");
            }
        }
    }
}
