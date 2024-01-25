using API_CARTAO_CERTA.Domain.Core.Enums;

namespace API_CARTAO_CERTA.Domain.Core.Models
{
    public class Cartao
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
