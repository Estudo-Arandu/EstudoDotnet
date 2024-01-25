using API_CARTAO_CERTA.Adapters.Driven.SQLServer;
using API_CARTAO_CERTA.Adapters.Inbound.HTTP;
using API_CARTAO_CERTA.Domain.Core.Ports.Inbound.UseCases;
using API_CARTAO_CERTA.Domain.Core.Ports.Outbound;
using API_CARTAO_CERTA.Domain.UseCase;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IUseCase_ValidarConta, UseCase_ValidarContaService>();
builder.Services.AddSingleton<ISQLServerAdapter, SQLServerService>();




var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.AddReceberTransacao();
app.Add

app.Run();