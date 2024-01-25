using Microsoft.Data.SqlClient;

namespace API_CARTAO_CERTA.Domain.Core.Ports.Outbound
{
    public interface ISQLServerAdapter
    {
        public SqlConnection Conectar();
    }
}
