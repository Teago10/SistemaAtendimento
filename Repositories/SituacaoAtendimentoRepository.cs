using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class SituacaoAtendimentoRepository
    {
        public List<SituacaoAtendimentos> Listar()
        {
            var situacaoAtendimentos = new List<SituacaoAtendimentos>();
            
            using (var conexao = ConexaoDB.GetConexao()
            {
                string sql = "select * from situacaoatendimentos";
            }
            return situacaoAtendimentos;
        }
    }
}
