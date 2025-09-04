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
            _usuarioController.ListarClientes(); // Chama o método para listar os usuários quando o formulário é carregado
        }

        public void ExibirMensagem(string mensagem) // Método para exibir mensagens ao usuário
        {
            MessageBox.Show(mensagem); // Exibe uma mensagem em uma caixa de diálogo
        }
        public void ExibrirUsuarios(List<Usuarios> usuarios) // Método para exibir a lista de usuários no DataGridView
        {
            dgvListaUsuario.DataSource = usuarios; // Define a fonte de dados do DataGridView como a lista de usuários
        }
    } 
}
