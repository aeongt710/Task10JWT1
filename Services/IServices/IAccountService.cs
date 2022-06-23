using System.IdentityModel.Tokens.Jwt;
using Task10JWT1.Moels.VMs;

namespace Task10JWT1.Services.IServices
{
    public interface IAccountService
    {
        public Task<string> RegisterNewUser(RegisterVM registerVM);
        public Task<JWTLoginVM> Login(LoginVM loginVM);
        public Task Logout();
    }
}
