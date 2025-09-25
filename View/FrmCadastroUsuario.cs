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

namespace SistemaAtendimento.View
{
    public partial class FrmCadastroUsuario : Form //Formulario de Cadastro de Usuários
    {
        private UsuarioController _usuarioController; // Controlador de Usuários
        public FrmCadastroUsuario() //Construtor do formulário
        {
            InitializeComponent(); // Inicializa os componentes do formulário
            _usuarioController = new UsuarioController(this); // inicializa o controlador de usuários
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e) // Evento disparado quando o formulário é carregado
        {
            _usuarioController.ListarUsuarios(); // Chama o método para listar os usuários quando o formulário é carregado
        }

        public void ExibirMensagem(string mensagem) // Método para exibir mensagens ao usuário
        {
            MessageBox.Show(mensagem); // Exibe uma mensagem em uma caixa de diálogo
        }
        public void ExibrirUsuarios(List<Usuarios> usuarios) // Método para exibir a lista de usuários no DataGridView
        {
            dgvListaUsuario.DataSource = usuarios; // Define a fonte de dados do DataGridView como a lista de usuários
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios() // Cria um novo objeto de usuário com os dados dos campos de texto
            {
                Nome = txtNome.Text,
                Senha = txtSenha.Text,
                Perfil = cbxPerfil.Text,
                Email = txtEmail.Text

            };

            if(!ValidarDados(usuario))
                return;
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                _usuarioController.Salvar(usuario);
            }
            else
            {
                usuario.Id = Convert.ToInt32(txtCodigo.Text);
                _usuarioController.Atualizar(usuario);
            }
            
        }

        public bool ValidarDados(Usuarios usuarios)
        {
            if (string.IsNullOrWhiteSpace(usuarios.Nome))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(usuarios.Email))
            {
                ExibirMensagem("O campo Email é obrigatório.");
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(usuarios.Senha))
            {
                ExibirMensagem("O campo Senha é obrigatório.");
                txtSenha.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(usuarios.Perfil))
            {
                ExibirMensagem("O campo Perfil é obrigatório.");
                cbxPerfil.Focus();
                return false;
            }
            return true;
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSenha.ReadOnly = false;
            cbxPerfil.Enabled = true;

            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
        }

        public void DesabilitarCampos()
        {
            LimparCampos();
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSenha.ReadOnly = true;
            cbxPerfil.Enabled = false;

            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cbxPerfil.Text = "";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                ExibirMensagem("Selecione um usuário para excluir.");
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _usuarioController.Excluir(id);
            }
        }

        private void dgvListaUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvListaUsuario.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                txtEmail.Text = linhaSelecionada.Cells["Email"].Value.ToString();
                txtSenha.Text = linhaSelecionada.Cells["Senha"].Value.ToString();
                cbxPerfil.Text = linhaSelecionada.Cells["Perfil"].Value.ToString();

                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }


    }
}
