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
    public class ClienteRepository 
    {
        // quero que retorne uma lista de clientes
        public List<Clientes> Listar() 
        {
            var clientes = new List<Clientes>(); // Cria uma lista para armazenar os clientes

            using (var conexao = ConexaoDB.GetConexao()) // usando a conexão com o banco de dados
            {
                string sql = "select * from clientes"; // comando sql que vc quer executar no banco de dados

                using (var comando = new SqlCommand(sql, conexao)) // comando que vc quer se seja executado no sql
                {
                    conexao.Open(); // abre a conexão com o banco de dados

                    using (var linhas = comando.ExecuteReader())// vai executar e trazer todas as linhas de registro
                    {
                        while (linhas.Read())// Enquato tiver dados para ler, ele vai executar o bloco
                        {
                            clientes.Add(new Clientes() 
                            {
                                Id = Convert.ToInt32(linhas["id"]), 
                                Nome = linhas["nome"].ToString(),
                                Email = linhas["email"].ToString(),
                                Cpf_Cnpj = linhas["cpf_cnpj"].ToString(),
                                TipoPessoa = linhas["tipo_pessoa"].ToString(),
                                Telefone = linhas["telefone"].ToString(),
                                Celular = linhas["celular"].ToString(),
                                Cep = linhas["cep"].ToString(),
                                Endereco = linhas["endereco"].ToString(),
                                Numero = linhas["numero"].ToString(),
                                Complemento = linhas["complemento"].ToString(),
                                Bairro = linhas["bairro"].ToString(),
                                Cidade = linhas["cidade"].ToString(),
                                Estado = linhas["estado"].ToString(),
                                Ativo = Convert.ToBoolean(linhas["ativo"])


                            });
                        }
                    }
                }
            }

            return clientes;
        }
    }
}
