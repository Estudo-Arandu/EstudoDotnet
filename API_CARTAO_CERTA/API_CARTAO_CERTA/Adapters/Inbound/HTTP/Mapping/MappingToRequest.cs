using API_CARTAO_CERTA.Adapters.Inbound.HTTP.VM;
using API_CARTAO_CERTA.Domain.Core.Models;

namespace API_CARTAO_CERTA.Adapters.Inbound.HTTP.Mapping
{
    public static class MappingToRequest
    {
        public static Conta ToRequest(Request request)
        {
            return new Conta
            {
                Nome = request.Nome,
                DataNascimento = request.DataNascimento
            };

        }
    }
}
