using MediatR;
using RecepBekirGurbuz.Core.Entities;
using RecepBekirGurbuz.Infrastructure.Context;
using RecepBekirGurbuz.Application.Commands.Users;
using System.Threading;
using System.Threading.Tasks;

namespace RecepBekirGurbuz.Application.Handlers.Users
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly AppDbContext _context;

        public CreateUserCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                FullName = request.FullName,
                Email = request.Email,
                PasswordHash = request.PasswordHash
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync(cancellationToken);

            return user.Id;
        }
    }
}
