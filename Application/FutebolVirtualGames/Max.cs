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
using System.Net.Http.Json;

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

            public async Task<string> Handle(Query request, CancellationToken cancellationToken)
            {
                // Cria um novo HttpClient
                var client = new HttpClient();

                // Define a URL da API
                string url = "https://www.milionariotips.com.br/Api/view/maxima/competition/20120650";

                // Obtem o valor do cookie
                var coockie = _context.Configurations.Where(x => x.ConfigurationName == "Cookie").FirstOrDefault().ConfigurationValue;

                // Adicionar cabeçalhos HTTP
                client.DefaultRequestHeaders.Add("Cookie", coockie);

                // Faz uma requisição GET e obtém um objeto Movie a partir do JSON
                // var maxima = await client.GetFromJsonAsync<Maximas>(url, cancellationToken: cancellationToken);

                var responseString = await client.GetStringAsync(url, cancellationToken: cancellationToken);

                // Console.WriteLine(responseString);

                // Console.WriteLine($"Maxima: {maxima.ToString()}");

                return (responseString);
            }
        }
    }
}