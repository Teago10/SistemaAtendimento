using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class SituacaoAtendimentoRepository
    {
        public List<SituacaoAtendimentos> Listar(string termo = "")
        {
            var situacaoAtendimentos = new List<SituacaoAtendimentos>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "select * from situacao_atendimentos";

                if (!string.IsNullOrEmpty(termo))
                {
                    sql = "select * from situacao_atendimentos where nome LIKE @termo";
                }

                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrEmpty(termo))
                    {
                        comando.Parameters.AddWithValue("@termo", "%" + termo + "%");
                    }
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            situacaoAtendimentos.Add(new SituacaoAtendimentos()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Cor = linhas["cor"].ToString(),
                                Ativo = Convert.ToBoolean(linhas["ativo"])
                            });
                        }
                    }
                }
                
            }
            return situacaoAtendimentos;
        }

        public void Inserir(SituacaoAtendimentos situacaoAtendimentos)
        {
            using (var conexao = ConexaoDB.GetConexao()) 
            { 
                string sql = "insert into situacao_atendimentos (nome, cor, ativo) values (@nome, @cor, @ativo)";
                using var comando = new SqlCommand(sql, conexao);
                {
                    comando.Parameters.AddWithValue("@nome", situacaoAtendimentos.Nome);
                    comando.Parameters.AddWithValue("@cor", situacaoAtendimentos.Cor);
                    comando.Parameters.AddWithValue("@ativo", situacaoAtendimentos.Ativo);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(SituacaoAtendimentos situacaoAtendimentos)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "update situacao_atendimentos set nome = @nome, cor = @cor, ativo = @ativo where id = @id";
                using var comando = new SqlCommand(sql, conexao);
                {
                    comando.Parameters.AddWithValue("@id", situacaoAtendimentos.Id);
                    comando.Parameters.AddWithValue("@nome", situacaoAtendimentos.Nome);
                    comando.Parameters.AddWithValue("@cor", situacaoAtendimentos.Cor);
                    comando.Parameters.AddWithValue("@ativo", situacaoAtendimentos.Ativo);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "delete from situacao_atendimentos where id = @id";
                using var comando = new SqlCommand(sql, conexao);
                {
                    comando.Parameters.AddWithValue("@id", id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
 