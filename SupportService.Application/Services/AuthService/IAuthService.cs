using SupportService.Domain;

namespace SupportService.Application.Services.AuthService
{
    public interface IAuthService
    {
        AuthResult Register(User user);
      //  void Login(string username, string password);
    }
}
