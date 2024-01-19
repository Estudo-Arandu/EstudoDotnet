namespace api.cartao.Domain.Core.Models
{
    public record Conta
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public Cartao Cartao { get; set; }
        public Conta()
        {
            
        }

    }
}
