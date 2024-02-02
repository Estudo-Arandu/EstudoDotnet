using API_CARTAO_CERTA.Domain.Core.Base;
using API_CARTAO_CERTA.Domain.Core.Models;

namespace API_CARTAO_CERTA.Domain.Core.Ports.Inbound.UseCases
{
    public interface IUseCase_ValidarConta
    {
        public Task<BaseReturn> Execute(Conta conta);
    }
}
