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

        // seleciona a palavra e use o atalho ctrl + rr para renomear todas as palavras iguais -by Hanna
        public void Inserir(Clientes cliente) // método para inserir um novo cliente no banco de dados
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "insert into clientes (nome, email, cpf_cnpj, tipo_pessoa," +
                    " telefone, celular, cep, endereco, numero, complemento, bairro, cidade," +
                    " estado, ativo) values (@nome, @email, @cpf_cnpj, @tipo_pessoa, @telefone, " +
                    "@celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado, @ativo)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", cliente.Nome);
                    comando.Parameters.AddWithValue("@email", cliente.Email);
                    comando.Parameters.AddWithValue("@cpf_cnpj", cliente.Cpf_Cnpj);
                    comando.Parameters.AddWithValue("@tipo_pessoa", cliente.TipoPessoa);
                    comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    comando.Parameters.AddWithValue("@celular", cliente.Celular);
                    comando.Parameters.AddWithValue("@cep", cliente.Cep);
                    comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                    comando.Parameters.AddWithValue("@numero", cliente.Numero);
                    comando.Parameters.AddWithValue("@complemento", cliente.Complemento);
                    comando.Parameters.AddWithValue("@bairro", cliente.Bairro);
                    comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                    comando.Parameters.AddWithValue("@estado", cliente.Estado);
                    comando.Parameters.AddWithValue("@ativo", cliente.Ativo);

                    conexao.Open();
                    comando.ExecuteNonQuery(); // Executa o comando SQL sem retornar resultados
                }
            }
        }

        public void Atualizar(Clientes cliente) // método para atualizar um cliente existente no banco de dados
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "update clientes set nome = @nome, email = @email, cpf_cnpj = @cpf_cnpj," +
                    " tipo_pessoa = @tipo_pessoa, telefone = @telefone, celular = @celular, cep = @cep," +
                    " endereco = @endereco, numero = @numero, complemento = @complemento, bairro = @bairro," +
                    " cidade = @cidade, estado = @estado, ativo = @ativo where id = @id";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", cliente.Id);
                    comando.Parameters.AddWithValue("@nome", cliente.Nome);
                    comando.Parameters.AddWithValue("@email", cliente.Email);
                    comando.Parameters.AddWithValue("@cpf_cnpj", cliente.Cpf_Cnpj);
                    comando.Parameters.AddWithValue("@tipo_pessoa", cliente.TipoPessoa);
                    comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    comando.Parameters.AddWithValue("@celular", cliente.Celular);
                    comando.Parameters.AddWithValue("@cep", cliente.Cep);
                    comando.Parameters.AddWithValue("@endereco", cliente.Endereco);
                    comando.Parameters.AddWithValue("@numero", cliente.Numero);
                    comando.Parameters.AddWithValue("@complemento", cliente.Complemento);
                    comando.Parameters.AddWithValue("@bairro", cliente.Bairro);
                    comando.Parameters.AddWithValue("@cidade", cliente.Cidade);
                    comando.Parameters.AddWithValue("@estado", cliente.Estado);
                    comando.Parameters.AddWithValue("@ativo", cliente.Ativo);
                    conexao.Open();
                    comando.ExecuteNonQuery(); // Executa o comando SQL sem retornar resultados
                }
            }
        }

        public void Excluir(int id) // método para excluir um cliente do banco de dados
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "delete from clientes where id = @id";
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
