export interface FutebolVirtualGames {
    Id: string;
    IdBet365: number;
    HomeTeam: string;
    AwayTeam: string;
    SumScore: number;
    FinalTimeResult: string;
    HalfTimeResult: string;
    Date: Date | null;
    HomeImg: string;
    AwayImg: string;
    LeagueId: number;
}