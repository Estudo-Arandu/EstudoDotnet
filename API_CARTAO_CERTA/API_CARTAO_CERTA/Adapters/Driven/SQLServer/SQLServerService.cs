using API_CARTAO_CERTA.Domain.Core.Ports.Outbound;
using Microsoft.Data.SqlClient;

namespace API_CARTAO_CERTA.Adapters.Driven.SQLServer
{
    public class SQLServerService : ISQLServerAdapter
    {
        private readonly string _connectionString;
        public SQLServerService(IServiceProvider provider) 
        {
            _connectionString = "";
        }

        public SqlConnection Conectar()
        {
            throw new NotImplementedException();
        }
    }
}
