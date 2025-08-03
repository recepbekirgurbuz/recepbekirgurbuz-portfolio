using MediatR;

namespace RecepBekirGurbuz.Application.Handlers.Users
{
    public class CreateUserCommand : IRequest<int>
    {
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
    }
}
