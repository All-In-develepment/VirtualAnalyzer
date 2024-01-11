using Application.Core;
using Application.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AutoMapper.QueryableExtensions;
using MediatR;
using Persistence;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Text.Json;
using Domain;

namespace Application.FutebolVirtualGames
{
    public class Max
    {
        // Class to list the max values of the games
        public class Query : IRequest<string>
        {
            public FutebolVirtualGamesParams Params { get; set; }
        }

        public class Handler : IRequestHandler<Query, string>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            private readonly HttpClient _httpClient;

            public Handler(DataContext context, IMapper mapper, HttpClient httpClient)
            {
                _mapper = mapper;
                _context = context;
                _httpClient = httpClient;
            }

            // public async Task<Result<IActionResult>> Handle(Query request, CancellationToken cancellationToken)
            // {
            //     // Add header whit key and value
            //     _httpClient.DefaultRequestHeaders.Add("Cookie", _context.Configurations.FirstOrDefault(x => x.ConfigurationName == "Cookie").ToString());
            //     var response = await _httpClient.GetAsync("https://localhost:5001/api/futebolvirtualgames/max");
            //     if (response.IsSuccessStatusCode)
            //     {
            //         var json = await response.Content.ReadAsStringAsync();
            //         return Ok(Content(json, "application/json"));
            //     }

            //     return NotFound();
            // }

            public async Task<string> Handle(Query request, CancellationToken cancellationToken)
            {
                // var futebolVirtualGames = _context.FutebolVirtualGames
                //     .Where(x => x.LeagueId == request.Params.LeagueId)
                //     .OrderBy(d => d.Date)
                //     .ProjectTo<FutebolVirtualGamesDto>(_mapper.ConfigurationProvider)
                //     .AsQueryable();

                // var futebolVirtualGamesToReturn = _mapper.Map<List<FutebolVirtualGamesDto>>(futebolVirtualGames);

                // return Result<PagedList<FutebolVirtualGamesDto>>
                //     .Success(await PagedList<FutebolVirtualGamesDto>
                //     .CreateAsync(futebolVirtualGames, request.Params.PageNumber, request.Params.PageSize));
                
                // Add header whit key and value
                _httpClient.DefaultRequestHeaders.Add("Cookie", _context.Configurations.FirstOrDefault(x => x.ConfigurationName == "Cookie").ToString());
                var response = await _httpClient.GetAsync("https://localhost:5001/api/futebolvirtualgames/max");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return json;
                }

                return 'NotFound()'.ToString();
            }
        }
    }
}