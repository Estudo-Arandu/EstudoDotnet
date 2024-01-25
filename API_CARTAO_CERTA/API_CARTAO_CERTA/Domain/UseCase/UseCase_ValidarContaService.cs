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
        public Task<BaseReturn> execute(Conta conta)
        {
            throw new NotImplementedException();
        }
    }
}
