using SupportService.Domain;

namespace SupportService.Application.Services.AuthService
{
    public class AuthService : IAuthService
    {
        public AuthResult Register(User user)
        {
            return new AuthResult(Guid.NewGuid(), user.FirstName, user.LastName, user.Email, "token");
        }

       /* public AuthResult Login(string username, string password)
        {
        }*/b
    }
}
