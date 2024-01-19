using api.cartao.Domain.Core.Enums;

namespace api.cartao.Domain.Core.Models
{
    public record Cartao
    {
        public string Nome { get; set; }
        public string Pam { get; set; }
        public EnumBandeira Bandeira { get; set; }
        public string DataValidade { get; set; }
        public string CodigoSeguranca { get; set; }
        public Cartao()
        {
            
        }
    }
    

}
