using API_CARTAO_CERTA.Domain.Core.Base;
using API_CARTAO_CERTA.Domain.Core.Models;
using System.Data.SqlClient;

namespace API_CARTAO_CERTA.Domain.Core.Ports.Outbound
{
    public interface ISQLServerAdapter
    {
        public SqlConnection Conectar();

        public Task<BaseReturn> Cadastro(SqlConnection connection, Conta conta);
    }
}
