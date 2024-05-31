using Application.Core;
using Domain;
using FluentValidation;
using MediatR;
using Persistence;

namespace Application.Hubla.Sale
{
    public class EditSale
    {
        public class Command : IRequest<Result<Unit>>
        {
            public HublaNewSale HublaNewSale { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public class CommandValidator : AbstractValidator<Command>
            {
                public CommandValidator()
                {
                    RuleFor(x => x.HublaNewSale).SetValidator(new SaleValidator());
                }
            }
            
            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var sale = await _context.HublaNewSales.FindAsync(request.HublaNewSale.HublaNewSaleId);

                if (sale == null) return null;

                var result = await _context.SaveChangesAsync() > 0;

                if (!result) return Result<Unit>.Failure("Failed to update sale");
                
                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}