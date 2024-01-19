namespace APIcartao.Domain.Core.Models
{
    public record Conta
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cartao Cartao { get; set; }
        public Conta()
        {
            
        }
    }
}
