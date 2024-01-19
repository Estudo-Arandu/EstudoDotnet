using APIcartao.Adapters.Inbound.HTTP.VM;
using APIcartao.Domain.Core.Models;

namespace APIcartao.Adapters.Inbound.HTTP.Mapping
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
