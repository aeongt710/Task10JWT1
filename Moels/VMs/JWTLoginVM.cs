using System.IdentityModel.Tokens.Jwt;

namespace Task10JWT1.Moels.VMs
{
    public class JWTLoginVM
    {
        public string Token { get; set; }
        public string Validity { get; set; }
    }
}
