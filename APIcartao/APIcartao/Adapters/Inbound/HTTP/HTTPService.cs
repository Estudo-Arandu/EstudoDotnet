using APIcartao.Adapters.Inbound.HTTP.Mapping;
using APIcartao.Adapters.Inbound.HTTP.VM;
using APIcartao.Domain.Core.Ports.Inbound.UseCases;
using System.Runtime.CompilerServices;

namespace APIcartao.Adapters.Inbound.HTTP
{
    public static class HTTPService
    {
        public static void AddReceberTransacao(this WebApplication app)
        {
            app.MapPost("/receber", ReceberRequest);

        }
        private static async Task ReceberRequest(IUseCase_ValidarConta useCase, HttpContext context, Request requestConta)
        {
            try
            {
                await useCase.execute(MappingToRequest.ToRequest(requestConta));
            }
            catch (Exception ex) { }
        }
    }
}
