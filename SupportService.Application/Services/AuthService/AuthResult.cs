namespace SupportService.Application.Services.AuthService
{
    public record AuthResult(Guid? id, string username, string FirstName, string LastName, string Email, string Token);
}
