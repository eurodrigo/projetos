using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace IO.Infra.CrossCutting.Identity.Authorization
{
    public class SigningCredentialsConfiguration
    {
        private const string SecretKey = "baseProjIo@meuambienteToken";
        public static readonly SymmetricSecurityKey Key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));
        public SigningCredentials SigningCredentials { get; }

        public SigningCredentialsConfiguration()
        {
            SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);
        }
    }
}
