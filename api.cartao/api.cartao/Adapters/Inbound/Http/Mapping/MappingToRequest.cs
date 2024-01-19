using api.cartao.Adapters.Inbound.Http.VM;
using api.cartao.Domain.Core.Models;

namespace api.cartao.Adapters.Inbound.Http.Mapping
{
    public static class MappingToRequest
    {
        public static Conta toRequest(RequestConta request)
        {
            return new Conta
            {
                Nome = request.Nome,
                DataNascimento = request.DataNascimento
            };
        }
    }
}
