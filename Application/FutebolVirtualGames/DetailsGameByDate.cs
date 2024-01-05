using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Persistence;
using SQLitePCL;

namespace Application.FutebolVirtualGames
{
    public class DetailsGameByDate
    {
        public class Query : IRequest<Result<List<FutebolVirtualGamesDto>>>
        {
            public DateTime Date { get; set; }
            public int LeagueId { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<List<FutebolVirtualGamesDto>>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Result<List<FutebolVirtualGamesDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var futebolVirtualGames = _context.FutebolVirtualGames
                    .Where(d => d.Date <= request.Date && d.Date >= request.Date.AddDays(-2) && d.LeagueId == request.LeagueId)
                    .OrderBy(d => d.Date)
                    .ProjectTo<FutebolVirtualGamesDto>(_mapper.ConfigurationProvider)
                    .AsQueryable();
                
                var futebolVirtualGamesToReturn = _mapper.Map<List<FutebolVirtualGamesDto>>(futebolVirtualGames);

                return Result<List<FutebolVirtualGamesDto>>
                    .Success(futebolVirtualGamesToReturn);
            }
        }
    }
}