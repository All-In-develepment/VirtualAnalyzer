using Application.Core;
using MediatR;
using Persistence;

namespace Application.FutebolVirtualLeagues
{
    public class DeleteLeague
    {
        // Classe de exclusão de ligas de futebol virtual
        public class Command : IRequest<Result<Unit>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var futebolVirtualLeague = await _context.FutebolVirtualLeagues.FindAsync(request.Id);

                if (futebolVirtualLeague == null) return null;

                _context.Remove(futebolVirtualLeague);

                var result = await _context.SaveChangesAsync() > 0;

                if (!result) return Result<Unit>.Failure("Failed to delete the Futebol Virtual League");

                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}