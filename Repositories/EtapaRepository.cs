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
    public class EtapaRepository
    {
        public List<Etapas> Listar(string termo = "")
        {
            var etapas = new List<Etapas>();
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "select * from etapas";

                if (!string.IsNullOrEmpty(termo))
                {
                    sql = "select * from etapas where nome LIKE @termo";
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
                            etapas.Add(new Etapas()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Ordem = Convert.ToInt32(linhas["ordem"]),
                                Ativo = Convert.ToBoolean(linhas["ativo"])
                            });
                        }
                    }
                }
            }
            return etapas;
        }

        public void Inserir(Etapas etapa)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "insert into etapas (nome, ordem, ativo) values (@nome, @ordem, @ativo)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", etapa.Nome);
                    comando.Parameters.AddWithValue("@ordem", etapa.Ordem);
                    comando.Parameters.AddWithValue("@ativo", etapa.Ativo);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Etapas etapa)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "update etapas set nome = @nome, ordem = @ordem, ativo = @ativo where id = @id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", etapa.Nome);
                    comando.Parameters.AddWithValue("@ordem", etapa.Ordem);
                    comando.Parameters.AddWithValue("@ativo", etapa.Ativo);
                    comando.Parameters.AddWithValue("@id", etapa.Id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id) // método para excluir um cliente do banco de dados
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "delete from etapas where id = @id";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    conexao.Open();
                    comando.ExecuteNonQuery(); // Executa o comando SQL sem retornar resultados
                }
            }
        }

    }
}
