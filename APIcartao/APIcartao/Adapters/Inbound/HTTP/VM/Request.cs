namespace APIcartao.Adapters.Inbound.HTTP.VM
{
    public record Request
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
