using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.Services;

namespace SistemaAtendimento.Controller
{
    public class ClienteController
    {
        private FrmCadastroClientes _frmCadastroClientes; // referência para o formulário de cadastro de clientes
        private ClienteRepository _clienteRepository; // referência para o repositório de clientes
        public ClienteController(FrmCadastroClientes view) // construtor que recebe o formulário de cadastro de clientes como parâmetro
        {
            _frmCadastroClientes = view; // inicializa o formulário de cadastro de clientes
            _clienteRepository = new ClienteRepository(); // inicializa o repositório de clientes
        }

        public void ListarClientes(string termo = "") // método para listar os clientes
        {
            //erros que ocorrem no sistema 
            try
            {
                //vai testar tudo que está dentro do bloco, se der um erro aqui vai para o catch
                var listaClientes = _clienteRepository.Listar(termo); // Chama o método Listar do repositório para obter a lista de clientes
                _frmCadastroClientes.ExibirClientes(listaClientes); // Chama o método do formulário para exibir os clientes

            }
            catch (Exception ex) 
            {
                //captura o erro e exibe uma mensagem
                _frmCadastroClientes.ExibirMensagem($"Erro ao carregar os clientes: {ex.Message}");
            }
            
        }

        public void Salvar(Clientes cliente) // método para salvar um novo cliente
        {
            
            try
            {
                _clienteRepository.Inserir(cliente);
                _frmCadastroClientes.ExibirMensagem("Cliente cadastrado com sucesso!");

                ListarClientes(); // Atualiza a lista de clientes após a inserção

                _frmCadastroClientes.DesabilitarCampos(); // desabilita os campos após salvar   
            }
            catch (Exception ex)
            {
                _frmCadastroClientes.ExibirMensagem($"Erro ao Cadastrar o cliente: {ex.Message}");
            }
        }

        public void Atualizar(Clientes cliente) // método para atualizar um cliente existente
        {
            try
            {
                _clienteRepository.Atualizar(cliente);
                _frmCadastroClientes.ExibirMensagem("Cliente atualizado com sucesso!");
                ListarClientes(); // Atualiza a lista de clientes após a atualização

                _frmCadastroClientes.DesabilitarCampos(); // desabilita os campos após salvar   
            }
            catch (Exception ex)
            {
                _frmCadastroClientes.ExibirMensagem($"Erro ao atualizar o cliente: {ex.Message}");
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _clienteRepository.Excluir(id);
                _frmCadastroClientes.ExibirMensagem("Cliente excluído com sucesso!");

                ListarClientes();
                _frmCadastroClientes.DesabilitarCampos(); // desabilita os campos após salvar
            }
            catch (Exception ex)
            {
                _frmCadastroClientes.ExibirMensagem($"Erro ao excluir o cliente: {ex.Message}");
            }
        }

        public void GerarRelatorioPDF() // método para gerar um relatório em PDF com a lista de clientes
        {

            try
            {
                var listaClientes = _clienteRepository.Listar(); // obtém a lista de clientes do repositório

                var relatorioClientes = new RelatorioClientes(); // cria uma instância do serviço de geração de relatórios

                string arquivo = relatorioClientes.GerarListaClientes(listaClientes); // gera o relatório e obtém o caminho do arquivo PDF gerado

                var psi = new ProcessStartInfo(arquivo) // configura o processo para abrir o arquivo PDF gerado
                {
                    UseShellExecute = true, // indica que o processo deve usar o shell do sistema para abrir o arquivo
                };
                Process.Start(psi); // inicia o processo para abrir o arquivo PDF gerado
            }
            catch (Exception ex)
            {
                ///Erro ao gerar o relatório
            }
            
        }
    }
}
