using API_CARTAO_CERTA.Domain.Core.Base;
using API_CARTAO_CERTA.Domain.Core.Models;
using API_CARTAO_CERTA.Domain.Core.Ports.Outbound;
using Dapper;
using System.Data.SqlClient;

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
            return new SqlConnection(_connectionString);
        }
        public async Task<BaseReturn> Cadastro(SqlConnection connection, Conta conta)
        {
            try
            {
                var response = await connection.ExecuteAsync("INSERT INTO [TESTE] VALUES (@Nome,@DataNascimento)",
                    new
                    {
                        Nome = conta.Nome,
                        DataNascimento = conta.DataNascimento
                    });
                return new BaseReturn().Sucesso(response);
            }
            catch (Exception ex)
            {
                return new BaseReturn().ErroSistema(ex);
            }
        }
    }
}
