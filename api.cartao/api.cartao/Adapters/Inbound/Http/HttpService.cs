using api.cartao.Adapters.Inbound.Http.VM;
using api.cartao.Domain.Core.Ports.Inbound.UseCases;

namespace api.cartao.Adapters.Inbound.Http
{
    public static class HttpService
    {
        public static void AddReceberTransacao(this WebApplication app)
        {
            app.MapPost("/receber", ReceberRequest);
        }
        private static async Task<IResult> ReceberRequest(IUseCaseValidarConta useCase, HttpContext context, RequestConta request)
        {
            try
            {
                var response = await useCase.ReceberTransacao(MappingToResponse.ToResponse(request));
                return response.GetResponse();
            }
            catch (Exception ex)
            {
                return new BaseReturn().ErroSistema(ex).GetResponse();
            }
        }

    }
}
