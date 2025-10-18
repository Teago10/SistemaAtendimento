using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento
{
    public partial class FrmCadastroClientes : Form
    {
        private ClienteController _clienteController;
        public FrmCadastroClientes()
        {
            InitializeComponent();
            _clienteController = new ClienteController(this); // inicializa o controlador de clientes
        }

        private void grdDadosCliente_Enter(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroClientes_Load(object sender, EventArgs e)
        {
            _clienteController.ListarClientes(); // Chama o método para listar os clientes quando o formulário é carregado
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem); // Exibe uma mensagem em uma caixa de diálogo
        }

        public void ExibirClientes(List<Clientes> clientes)
        {
            dgvClientes.DataSource = clientes; // Define a fonte de dados do DataGridView como a lista de clientes
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Cpf_Cnpj = txtCpfCnpj.Text,
                TipoPessoa = rdbFisica.Checked ? "F" : "J", // se o radio button Fisica estiver marcado, TipoPessoa é "F", senão é "J"
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                Cep = txtCep.Text,
                Endereco = txtEndereco.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = cbxEstado.Text,
                Ativo = rdbAtivo.Checked // se o checkbox Ativo estiver marcado, Ativo é true, senão é false
            };

            if (!ValidarDados(cliente)) // valida os dados do cliente
                return; // se os dados não forem válidos, retorna sem salvar

            if (string.IsNullOrWhiteSpace(txtCodigo.Text)) // se o campo Código estiver vazio, é um novo cliente
            {
                _clienteController.Salvar(cliente); // Chama o método para salvar o cliente, puxa do controller
            }
            else
            {
                // cliente.Id vai receber(=) o valor convertido do campo txtCodigo
                cliente.Id = Convert.ToInt32(txtCodigo.Text);

                _clienteController.Atualizar(cliente); // Chama o método para atualizar o cliente
            }


        }

        public bool ValidarDados(Clientes cliente) // método para validar os dados do cliente
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text)) // verifica se o campo Nome está vazio ou contém apenas espaços em branco
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus(); // coloca o foco no campo Nome
                return false; // retorna falso, indicando que os dados não são válidos
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirMensagem("O campo Email é obrigatório.");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCpfCnpj.Text))
            {
                if (rdbFisica.Checked)
                    ExibirMensagem("O campo CPF é obrigatório.");
                else
                    ExibirMensagem("O campo CNPJ é obrigatório.");

                txtCpfCnpj.Focus();
                return false;
            }
            else
            {
                if (rdbFisica.Checked)
                {
                    // verifica se o CPF tem 11 dígitos
                    string cpf = txtCpfCnpj.Text;

                    if (cpf.Length != 11)
                    {
                        ExibirMensagem("O CPF deve ter 11 números.");
                        txtCpfCnpj.Focus();
                        return false;
                    }
                }
                else
                {
                    // verifica se o CNPJ tem 14 dígitos
                    string cnpj = txtCpfCnpj.Text;

                    if (cnpj.Length != 14)
                    {
                        ExibirMensagem("O CNPJ deve ter 14 números.");
                        txtCpfCnpj.Focus();
                        return false;
                    }
                }
            }


            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                ExibirMensagem("O campo CEP é obrigatório.");
                txtCep.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                ExibirMensagem("O campo Endereço é obrigatório.");
                txtEndereco.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                ExibirMensagem("O campo Número é obrigatório.");
                txtNumero.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                ExibirMensagem("O campo Bairro é obrigatório.");
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                ExibirMensagem("O campo Cidade é obrigatório.");
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                ExibirMensagem("O campo Estado é obrigatório.");
                cbxEstado.Focus();
                return false;
            }

            return true; // retorna true, indicando que os dados são válidos
        }

        private void rdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbJuridica.Checked)
            {
                lblCPFCNPJ.Text = "CNPJ";
            }
        }

        private void rdbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFisica.Checked)
            {
                lblCPFCNPJ.Text = "CPF";
            }
        }
        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtCpfCnpj.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtCep.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtComplemento.ReadOnly = false;
            txtBairro.ReadOnly = false;
            txtCidade.ReadOnly = false;
            cbxEstado.Enabled = true;
            pnlSituacao.Enabled = true;
            pnlTipoPessoa.Enabled = true;


            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
        }
        public void DesabilitarCampos()
        {
            LimparCampos();
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtCpfCnpj.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCelular.ReadOnly = true;
            txtCep.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtComplemento.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtCidade.ReadOnly = true;
            cbxEstado.Enabled = false;
            pnlSituacao.Enabled = false;
            pnlTipoPessoa.Enabled = false;


            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
        }
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtCpfCnpj.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            rdbFisica.Checked = true;
            rdbJuridica.Checked = false;
            rdbAtivo.Checked = true;
            rdbInativo.Checked = false;
            cbxEstado.Text = ""; // limpa a seleção do ComboBox. Empty é uma string vazia


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvClientes.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                txtEmail.Text = linhaSelecionada.Cells["Email"].Value.ToString();
                txtCpfCnpj.Text = linhaSelecionada.Cells["Cpf_Cnpj"].Value.ToString();
                /*
                if (linhaSelecionada.Cells["TipoPessoa"].Value.ToString() == "F")
                    rdbFisica.Checked = true;
                else
                    rdbJuridica.Checked = true;*/

                // Simplificação do código acima
                rdbFisica.Checked = linhaSelecionada.Cells["TipoPessoa"].Value.ToString() == "F";
                rdbJuridica.Checked = linhaSelecionada.Cells["TipoPessoa"].Value.ToString() == "J";
                txtTelefone.Text = linhaSelecionada.Cells["Telefone"].Value.ToString();
                txtCelular.Text = linhaSelecionada.Cells["Celular"].Value.ToString();
                txtCep.Text = linhaSelecionada.Cells["Cep"].Value.ToString();
                txtEndereco.Text = linhaSelecionada.Cells["Endereco"].Value.ToString();
                txtNumero.Text = linhaSelecionada.Cells["Numero"].Value.ToString();
                txtComplemento.Text = linhaSelecionada.Cells["Complemento"].Value.ToString();
                txtBairro.Text = linhaSelecionada.Cells["Bairro"].Value.ToString();
                txtCidade.Text = linhaSelecionada.Cells["Cidade"].Value.ToString();
                cbxEstado.Text = linhaSelecionada.Cells["Estado"].Value.ToString();
                /*
                if (Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value))
                    rdbAtivo.Checked = true;
                else
                    rdbInativo.Checked = true;
                */

                // Simplificação do código acima
                rdbAtivo.Checked = Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);
                rdbInativo.Checked = !Convert.ToBoolean(linhaSelecionada.Cells["Ativo"].Value);

                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                ExibirMensagem("Nenhum cliente selecionado para exclusão.");
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja Excluir o Cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // (refere-se a linha de cima) pergunta se o usuário tem certeza que quer excluir o cliente
            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _clienteController.Excluir(id); // chama o método para excluir o cliente
            }

        }

        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        // async - aguarda a resposta de uma requisição, Task - tarefa que será executada de forma assíncrona
        private async Task BuscarEnderecoPorCep(string cep)
        {
            try
            {
                cep = cep.Replace("-", "").Trim(); // remove qualquer traço do CEP

                using (HttpClient client = new HttpClient()) // cria uma instância do HttpClient para fazer requisições HTTP
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/"; // URL da API do ViaCEP

                    var response = await client.GetAsync(url); // aguarda a resposta da requisição


                    if (response.IsSuccessStatusCode) // se a resposta for bem-sucedida
                    {
                        string json = await response.Content.ReadAsStringAsync(); // lê o conteúdo da resposta como uma string

                        dynamic? dadosEndereco = JsonConvert.DeserializeObject(json);

                        if (dadosEndereco?.erro == true)
                        {
                            ExibirMensagem("CEP não encontrado.");
                            return;
                        }


                        txtEndereco.Text = dadosEndereco?.logradouro;
                        txtBairro.Text = dadosEndereco?.bairro;
                        txtCidade.Text = dadosEndereco?.localidade;
                        cbxEstado.Text = dadosEndereco?.uf;

                    }
                    else
                    {
                        ExibirMensagem("CEP não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                ExibirMensagem($"Erro ao buscar o endereço: {ex.Message}");
            }
        }

        // Task ou void - método assíncrono que não retorna valor

        private async void txtCep_Leave_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCep.Text)) // se o campo CEP não estiver vazio
            {
                await BuscarEnderecoPorCep(txtCep.Text); // chama o método para buscar o endereço pelo CEP
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim(); // obtém o termo de busca e remove espaços em branco
            _clienteController.ListarClientes(termo); // chama o método para listar os clientes com o termo de busca
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
