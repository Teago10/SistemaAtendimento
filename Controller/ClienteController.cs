using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var listaClientes = _clienteRepository.Listar(); // Chama o método Listar do repositório para obter a lista de clientes

            _frmCadastroClientes.ExibirClientes(listaClientes); // Chama o método do formulário para exibir os clientes
        }
    }
}
