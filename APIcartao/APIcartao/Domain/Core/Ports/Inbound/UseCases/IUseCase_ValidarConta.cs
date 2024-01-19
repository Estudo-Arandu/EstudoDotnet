using APIcartao.Domain.Core.Models;

namespace APIcartao.Domain.Core.Ports.Inbound.UseCases
{
    public interface IUseCase_ValidarConta
    {
        public Task execute(Conta conta);
    }
}
