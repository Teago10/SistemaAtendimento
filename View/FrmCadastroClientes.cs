using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            _clienteController.Salvar(cliente); // Chama o método para salvar o cliente, puxa do controller


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
            rdbAtivo.Enabled = true;
            rdbInativo.Enabled = true;
            rdbFisica.Enabled = true;
            rdbJuridica.Enabled = true;

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
            rdbAtivo.Enabled = true;
            rdbInativo.Enabled = true;
            rdbFisica.Enabled = true;
            rdbJuridica.Enabled = true;

            btnExcluir.Enabled = true;
            btnEditar.Enabled = true;
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
            rdbAtivo.Checked = true;
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
    }
}
