using System.Net.Http.Json;

namespace GetJsonExample
{
    public class AwayTop3
    {
        public string TeamHome { get; set; }
        public string TeamAway { get; set; }
        public string HomeImg { get; set; }
        public string AwayImg { get; set; }
        public int Id { get; set; }
        public int IdCompetition { get; set; }
        public int IdChallenge { get; set; }
        public int IdFixture { get; set; }
        public DateTime Date { get; set; }
        public DateTime UserDate { get; set; }
        public string Title { get; set; }
        public int IdTeamHome { get; set; }
        public int IdTeamAway { get; set; }
        public int IdTeamWinnerHalfTime { get; set; }
        public int IdTeamWinner { get; set; }
        public int IdTeamScoreFirst { get; set; }
        public string HalfTimeResult { get; set; }
        public string FinalTimeResult { get; set; }
        public int HalfTimeHomeScore { get; set; }
        public int HalfTimeAwayScore { get; set; }
        public bool HalfTimeDraw { get; set; }
        public bool FinalTimeDraw { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public int SumScore { get; set; }
        public int IdTeamScoreLast { get; set; }
        public string PositionFirstGoalscorer { get; set; }
    }

    public class Chart
    {
        public List<int> Over15 { get; set; }
        public List<int> Over25 { get; set; }
        public List<int> Under25 { get; set; }
        public List<int> AmbasMarcam { get; set; }
        public List<int> CasaHT { get; set; }
        public List<int> EmpateHT { get; set; }
        public List<int> VisitanteHT { get; set; }
        public List<int> CasaFT { get; set; }
        public List<int> EmpateFT { get; set; }
        public List<int> VisitanteFT { get; set; }
        public List<int> EmpateOuCasa { get; set; }
        public List<int> VisitanteOuCasa { get; set; }
        public List<int> EmpateOuVisitante { get; set; }
    }

    public class Data
    {
        public string TeamHome { get; set; }
        public string TeamAway { get; set; }
        public string HomeImg { get; set; }
        public string AwayImg { get; set; }
        public int Id { get; set; }
        public int IdCompetition { get; set; }
        public int IdChallenge { get; set; }
        public int IdFixture { get; set; }
        public DateTime Date { get; set; }
        public DateTime UserDate { get; set; }
        public string Title { get; set; }
        public int IdTeamHome { get; set; }
        public int IdTeamAway { get; set; }
        public int IdTeamWinnerHalfTime { get; set; }
        public int IdTeamWinner { get; set; }
        public int IdTeamScoreFirst { get; set; }
        public string HalfTimeResult { get; set; }
        public string FinalTimeResult { get; set; }
        public int HalfTimeHomeScore { get; set; }
        public int HalfTimeAwayScore { get; set; }
        public bool HalfTimeDraw { get; set; }
        public bool FinalTimeDraw { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public int SumScore { get; set; }
        public int IdTeamScoreLast { get; set; }
        public string PositionFirstGoalscorer { get; set; }
    }

    public class HomeTop3
    {
        public string TeamHome { get; set; }
        public string TeamAway { get; set; }
        public string HomeImg { get; set; }
        public string AwayImg { get; set; }
        public int Id { get; set; }
        public int IdCompetition { get; set; }
        public int IdChallenge { get; set; }
        public int IdFixture { get; set; }
        public DateTime Date { get; set; }
        public DateTime UserDate { get; set; }
        public string Title { get; set; }
        public int IdTeamHome { get; set; }
        public int IdTeamAway { get; set; }
        public int IdTeamWinnerHalfTime { get; set; }
        public int IdTeamWinner { get; set; }
        public int IdTeamScoreFirst { get; set; }
        public string HalfTimeResult { get; set; }
        public string FinalTimeResult { get; set; }
        public int HalfTimeHomeScore { get; set; }
        public int HalfTimeAwayScore { get; set; }
        public bool HalfTimeDraw { get; set; }
        public bool FinalTimeDraw { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public int SumScore { get; set; }
        public int IdTeamScoreLast { get; set; }
        public string PositionFirstGoalscorer { get; set; }
    }

    public class ListMaxima
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public int IdCompetition { get; set; }
        public int IdStatistic { get; set; }
        public DateTime DataUpdate { get; set; }
        public int Atual { get; set; }
        public int Maxima { get; set; }
        public double Porcentagem { get; set; }
        public DateTime? DataEnvio { get; set; }
        public object ValorEnvio { get; set; }
        public object IdTelegramMessage { get; set; }
        public int? IdNextMatch { get; set; }
        public bool? IsGreen { get; set; }
        public DateTime? GreenRedStartDate { get; set; }
        public DateTime? GreenRedEndDate { get; set; }
    }

    public class Match
    {
        public Data Data { get; set; }
        public List<HomeTop3> HomeTop3 { get; set; }
        public List<AwayTop3> AwayTop3 { get; set; }
    }

    public class Maxima
    {
        public List<ListMaxima> ListMaximas { get; set; }
        public List<Match> Matches { get; set; }
        public Chart Chart { get; set; }
    }


    public class Program
    {
        public static async Task Main()
        {
            // Cria um cliente HTTP
            var client = new HttpClient();

            // Define a URL da API
            string url = "https://www.milionariotips.com.br/Api/view/maxima/competition/20120650";

            // Faz uma requisição GET e obtém um objeto Movie a partir do JSON
            var maxima = await client.GetFromJsonAsync<Maxima>(url);

            // Adicionar cabeçalhos HTTP
            client.DefaultRequestHeaders.Add("Cookie", ".AspNet.ApplicationCookie=QfTn5zSblN6Dh8-ETjaaUhURdgv3dgHQIT9gQLi3oHI1jov01-Xk2xRqq-Gv06nY8pMiQXZcQu8Io9rWfv8pCN77SZnz1VWUHko_xx7F0Ac_7PtSNrPu38DH8uuF1OjVG7-QzPe1Ex77RJiJYOfUrs3bPFWKLjntaAwNb1b9zFlrovvgjaX3pPRQ80JgN6p14Wb_jJViYhIsFkzCygDF4I_tIHAI4G3OQ9uDERIPOnXI4n7Po1WtXpasgHgE-vPMWKb2JWtSLML0rG0XC6jbM0PSBjGUwIvaDpo2DSheiNMvRK2eybew0pX2tuW8dVFuIWvMRd-6o3v6ERajS5g5IOQ2Bvs5Ad2wUPteoXM0HrNBIvGHfVTndcqyArbw8U08SZ37eSHODpKRUFHrHaHDBo41kBTDsCXvk9mbM1gJW03U3QdqdEjy3oXP9VHwvSJpLij9Q6wbpznpC2bGzwvG49534DfYhEB31a-HzQ66uQ-XaxDg7TdZQEPrghL1J-U4; path=/; secure; HttpOnly");

            // Exibe as informações do filme
            Console.WriteLine($"Name: {maxima.ListMaximas[0].Nome}");
            Console.WriteLine($"Release date: {maxima.Matches[0].Data.Date}");
            // Console.WriteLine($"Genres: {string.Join(", ", maxima.Genres)}");
        }
    }
}
