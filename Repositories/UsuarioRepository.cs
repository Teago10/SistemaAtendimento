using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class UsuarioRepository
    {
        public List<Usuarios> Listar()
        {
            var usuarios = new List<Usuarios>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "select * from usuarios";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                           usuarios.Add(new Usuarios() {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Email = linhas["email"].ToString(),
                                Senha = linhas["senha"].ToString(),
                                Perfil = linhas["perfil"].ToString()
                            });
                        }
                    }
                }
            }
            return usuarios;
        }

        public void Inserir(Usuarios usuarios)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "insert into usuarios (nome, email, senha, perfil) values (@nome, @email, @senha, @perfil)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", usuarios.Nome);
                    comando.Parameters.AddWithValue("@email", usuarios.Email);
                    comando.Parameters.AddWithValue("@senha", usuarios.Senha);
                    comando.Parameters.AddWithValue("@perfil", usuarios.Perfil);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
