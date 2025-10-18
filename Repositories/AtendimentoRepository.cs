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
    public class AtendimentoRepository
    {
        public List<Atendimentos> Listar(string termo = "", string condicao = "")
        {
           var lista = new List<Atendimentos>();
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"SELECT a.*, c.nome AS cliente_nome, sa.nome AS situacao_nome," +
                    " u.nome AS usuario_nome, c.cpf_cnpj " +
                    "FROM atendimentos a\r\n" +
                    "INNER JOIN clientes c ON c.id = a.cliente_id\r\n" +
                    "INNER JOIN situacao_atendimentos sa ON sa.id = a.situacao_atendimento_id\r\n" +
                    "INNER JOIN usuarios u ON u.id = a.usuario_id";

                //só aplica o filtro se o usuário tiver digitado algo no campo de busca
                if (!string.IsNullOrEmpty(termo) && !string.IsNullOrEmpty(condicao))
                {
                    if (condicao == "Código do Atendimento")
                    {
                        sql += " WHERE a.id = @termo";
                    } 
                    else if(condicao == "Nome do Cliente")
                    {
                        sql += " WHERE c.nome LIKE @termo";
                        termo = $"%{termo}%";
                    }
                    else 
                    {
                        sql += " WHERE c.cpf_cnpj = @termo";
                    }
                }

                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrEmpty(termo))
                    {
                        comando.Parameters.AddWithValue("@termo", termo);
                    }
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            lista.Add(new Atendimentos
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                ClienteId = Convert.ToInt32(linhas["cliente_id"]),
                                UsuarioId = Convert.ToInt32(linhas["usuario_id"]),
                                DataAbertura = linhas["data_abertura"] as DateTime?,
                                DataFechamento = linhas["data_fechamento"] as DateTime?,
                                Observacao = linhas["observacao"].ToString(),
                                SituacaoAtendimentoId = Convert.ToInt32(linhas["situacao_atendimento_id"]),
                                ClienteNome = linhas["cliente_nome"].ToString(),
                                situacaoAtendimentoNome = linhas["situacao_nome"].ToString(),
                                UsuarioNome = linhas["usuario_nome"].ToString(),
                                Cpf_Cnpj = linhas["cpf_cnpj"].ToString()

                            });
                        } 
                    }
                }

            }
            return lista;

        }
        public void Inserir(Atendimentos atendimento)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"INSERT INTO atendimentos (cliente_id, usuario_id, data_Abertura, data_fechamento, observacao, situacao_atendimento_id, cpf_cnpj) 
                values (@cliente_id, @usuario_id, @data_Abertura, @data_fechamento, @observacao, @situacao_atendimento_id, @cpf_cnpj)";

                using (var comando = new SqlCommand(sql, conexao)) 
                {
                    comando.Parameters.AddWithValue("@cliente_id", atendimento.ClienteId);
                    comando.Parameters.AddWithValue("@usuario_id", atendimento.UsuarioId);
                    comando.Parameters.AddWithValue("@data_abertura", atendimento.DataAbertura);
                    comando.Parameters.AddWithValue("@data_fechamento", atendimento.DataFechamento);
                    comando.Parameters.AddWithValue("@observacao", atendimento.Observacao);
                    comando.Parameters.AddWithValue("@situacao_atendimento_id", atendimento.SituacaoAtendimentoId);
                    comando.Parameters.AddWithValue("@cpf_cnpj", atendimento.Cpf_Cnpj);
                    conexao.Open();
                    comando.ExecuteNonQuery();

                }
            }
        }
            
        public void Atualizar(Atendimentos atendimento)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = @"UPDATE atendimentos SET cliente_id = @cliente_id, usuario_id = @usuario_id, data_Abertura = @data_Abertura,
                data_fechamento = @data_fechamento, observacao = @observacao, situacao_atendimento_id = @situacao_atendimento_id, cpf_cnpj = @cpf_cnpj
                WHERE id = @id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", atendimento.Id);
                    comando.Parameters.AddWithValue("@cliente_id", atendimento.ClienteId);
                    comando.Parameters.AddWithValue("@usuario_id", atendimento.UsuarioId);
                    comando.Parameters.AddWithValue("@data_abertura", atendimento.DataAbertura);
                    comando.Parameters.AddWithValue("@data_fechamento", atendimento.DataFechamento);
                    comando.Parameters.AddWithValue("@observacao", atendimento.Observacao);
                    comando.Parameters.AddWithValue("@situacao_atendimento_id", atendimento.SituacaoAtendimentoId);
                    comando.Parameters.AddWithValue("@cpf_cnpj", atendimento.Cpf_Cnpj);
                    comando.Parameters.AddWithValue("@id", atendimento.Id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM atendimentos WHERE id = @id";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

    }
}
