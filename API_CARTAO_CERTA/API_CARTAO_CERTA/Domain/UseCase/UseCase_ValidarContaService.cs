using API_CARTAO_CERTA.Domain.Core.Base;
using API_CARTAO_CERTA.Domain.Core.Models;
using API_CARTAO_CERTA.Domain.Core.Ports.Inbound.UseCases;
using API_CARTAO_CERTA.Domain.Core.Ports.Outbound;

namespace API_CARTAO_CERTA.Domain.UseCase
{
    public class UseCase_ValidarContaService : IUseCase_ValidarConta
    {
        private readonly ISQLServerAdapter _sql;
        public UseCase_ValidarContaService(IServiceProvider provider)
        {
            _sql = provider.GetRequiredService<ISQLServerAdapter>();
        }
        public async Task<BaseReturn> Execute(Conta conta)
        {
            try
            {
                //var connection = _sql.Conectar();
                //var response = await _sql.Cadastro(connection, conta);
                //return new BaseReturn().Sucesso(response.Body);
                return new BaseReturn().Sucesso("Conta cadastrada!");
            }
            catch (Exception)
            {
                return new BaseReturn().ErroNegocio("Erro no cadastro do banco de dados.");
            }
        }
    }
}
