using API_CARTAO_CERTA.Adapters.Inbound.HTTP.Mapping;
using API_CARTAO_CERTA.Adapters.Inbound.HTTP.VM;
using API_CARTAO_CERTA.Domain.Core.Base;
using API_CARTAO_CERTA.Domain.Core.Ports.Inbound.UseCases;
using Microsoft.AspNetCore.ResponseCompression;
using System.Runtime.CompilerServices;

namespace API_CARTAO_CERTA.Adapters.Inbound.HTTP
{
    public static class HTTPService
    {
        public static void AddReceberTransacao(this WebApplication app)
        {
            app.MapPost("/receber", ReceberRequest);

        }
        private static async Task<IResult> ReceberRequest(IUseCase_ValidarConta useCase, HttpContext context, Request requestConta)
        {
            try
            {
                var response = await useCase.Execute(MappingToRequest.ToRequest(requestConta));
                return response.GetResponse();
            }
            catch (Exception ex) 
            {
                return new BaseReturn().ErroSistema(ex).GetResponse();
            }
        }
    }
}
