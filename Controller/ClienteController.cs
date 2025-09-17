using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;

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

        public void ListarClientes() // método para listar os clientes
        {
            //erros que ocorrem no sistema 
            try
            {
                //vai testar tudo que está dentro do bloco, se der um erro aqui vai para o catch
                var listaClientes = _clienteRepository.Listar(); // Chama o método Listar do repositório para obter a lista de clientes
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
    }
}
