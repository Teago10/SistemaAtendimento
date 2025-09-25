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
    public class UsuarioController
    {
        // Implementar métodos para gerenciar usuários 
        private FrmCadastroUsuario _frmCadastroUsuario;
        private UsuarioRepository _usuarioRepository;

        public UsuarioController(FrmCadastroUsuario view)
        {
            _frmCadastroUsuario = view;
            _usuarioRepository = new UsuarioRepository();
        }

        public void ListarUsuarios()
        {
            try
            {
                var listaUsuarios = _usuarioRepository.Listar();
                _frmCadastroUsuario.ExibrirUsuarios (listaUsuarios);
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao carregar os usuários: {ex.Message}");
            }
        }

        public void Salvar(Usuarios usuario)
        {
            // Implementar lógica para salvar um novo usuário
            try
            {
                _usuarioRepository.Inserir(usuario);
                _frmCadastroUsuario.ExibirMensagem("Usuário cadastrado com sucesso!");
                ListarUsuarios(); // Atualiza a lista de usuários após a inserção
                _frmCadastroUsuario.DesabilitarCampos(); // desabilita os campos após salvar
            }
            catch(Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao cadastrar o usuário: {ex.Message}");
            }
        }
        public void Atualizar(Usuarios usuario)
        {
            // Implementar lógica para atualizar um usuário existente
            try
            {
                _usuarioRepository.Atualizar(usuario);
                _frmCadastroUsuario.ExibirMensagem("Usuário atualizado com sucesso!");
                ListarUsuarios();
                _frmCadastroUsuario.DesabilitarCampos(); // desabilita os campos após salvar
            }
            catch (Exception ex) 
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao atualizar o usuário: {ex.Message}");
            }
        }

        public void Excluir(int Id)
        {
            // Implementar lógica para excluir um usuário
            try
            {
                _usuarioRepository.Excluir(Id);
                _frmCadastroUsuario.ExibirMensagem("Usuário excluído com sucesso!");
                ListarUsuarios();
                _frmCadastroUsuario.DesabilitarCampos(); // desabilita os campos após salvar
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao excluir o usuário: {ex.Message}");
            }
        }
    }
}
