using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context,
            UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any() && !context.Activities.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser
                    {
                        DisplayName = "Bob",
                        UserName = "bob",
                        Email = "bob@test.com",
                        JoinDate = DateTime.UtcNow,
                        ExpireDate = DateTime.UtcNow.AddDays(30)
                    },
                    new AppUser
                    {
                        DisplayName = "Jane",
                        UserName = "jane",
                        Email = "jane@test.com",
                        JoinDate = DateTime.UtcNow,
                        ExpireDate = DateTime.UtcNow.AddDays(30)
                    },
                    new AppUser
                    {
                        DisplayName = "Tom",
                        UserName = "tom",
                        Email = "tom@test.com",
                        JoinDate = DateTime.UtcNow,
                        ExpireDate = DateTime.UtcNow.AddDays(30)
                    },
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }

                

                var activities = new List<Activity>
                {
                    new Activity
                    {
                        Title = "Past Activity 1",
                        Date = DateTime.UtcNow.AddMonths(-2),
                        Description = "Activity 2 months ago",
                        Category = "drinks",
                        City = "London",
                        Venue = "Pub",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[0],
                                IsHost = true
                            }
                        }
                    },
                    new Activity
                    {
                        Title = "Past Activity 2",
                        Date = DateTime.UtcNow.AddMonths(-1),
                        Description = "Activity 1 month ago",
                        Category = "culture",
                        City = "Paris",
                        Venue = "The Louvre",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[0],
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[1],
                                IsHost = false
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Future Activity 1",
                        Date = DateTime.UtcNow.AddMonths(1),
                        Description = "Activity 1 month in future",
                        Category = "music",
                        City = "London",
                        Venue = "Wembly Stadium",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[2],
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[1],
                                IsHost = false
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Future Activity 2",
                        Date = DateTime.UtcNow.AddMonths(2),
                        Description = "Activity 2 months in future",
                        Category = "food",
                        City = "London",
                        Venue = "Jamies Italian",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[0],
                                IsHost = true
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[2],
                                IsHost = false
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Future Activity 3",
                        Date = DateTime.UtcNow.AddMonths(3),
                        Description = "Activity 3 months in future",
                        Category = "drinks",
                        City = "London",
                        Venue = "Pub",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[1],
                                IsHost = true                            
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[0],
                                IsHost = false                            
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Future Activity 4",
                        Date = DateTime.UtcNow.AddMonths(4),
                        Description = "Activity 4 months in future",
                        Category = "culture",
                        City = "London",
                        Venue = "British Museum",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[1],
                                IsHost = true                            
                            }
                        }
                    },
                    new Activity
                    {
                        Title = "Future Activity 5",
                        Date = DateTime.UtcNow.AddMonths(5),
                        Description = "Activity 5 months in future",
                        Category = "drinks",
                        City = "London",
                        Venue = "Punch and Judy",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[0],
                                IsHost = true                            
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[1],
                                IsHost = false                            
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Future Activity 6",
                        Date = DateTime.UtcNow.AddMonths(6),
                        Description = "Activity 6 months in future",
                        Category = "music",
                        City = "London",
                        Venue = "O2 Arena",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[2],
                                IsHost = true                            
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[1],
                                IsHost = false                            
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Future Activity 7",
                        Date = DateTime.UtcNow.AddMonths(7),
                        Description = "Activity 7 months in future",
                        Category = "travel",
                        City = "Berlin",
                        Venue = "All",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[0],
                                IsHost = true                            
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[2],
                                IsHost = false                            
                            },
                        }
                    },
                    new Activity
                    {
                        Title = "Future Activity 8",
                        Date = DateTime.UtcNow.AddMonths(8),
                        Description = "Activity 8 months in future",
                        Category = "drinks",
                        City = "London",
                        Venue = "Pub",
                        Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                AppUser = users[2],
                                IsHost = true                            
                            },
                            new ActivityAttendee
                            {
                                AppUser = users[1],
                                IsHost = false                            
                            },
                        }
                    }
                };

                await context.Activities.AddRangeAsync(activities);
                await context.SaveChangesAsync();
            }

            if (!context.FutebolVirtualGames.Any())
            {
                var games = new List<FutebolVirtualGame>
                {
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011684,
                        LeagueId = 20120650,
                        HomeTeam = "Sérvia",
                        AwayTeam = "Brasil",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T14:07:00"),
                        HomeImg = "eu_7.png",
                        AwayImg = "19.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011680,
                        LeagueId = 20120650,
                        HomeTeam = "Costa Rica",
                        AwayTeam = "Gana",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T14:04:00"),
                        HomeImg = "22.png",
                        AwayImg = "11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011675,
                        LeagueId = 20120650,
                        HomeTeam = "Camarões",
                        AwayTeam = "Arábia Saudita",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T14:01:00"),
                        HomeImg = "6.png",
                        AwayImg = "Arábia Saudita.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011669,
                        LeagueId = 20120650,
                        HomeTeam = "Costa Rica",
                        AwayTeam = "França",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:58:00"),
                        HomeImg = "22.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011665,
                        LeagueId = 20120650,
                        HomeTeam = "Camarões",
                        AwayTeam = "Gana",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T13:55:00"),
                        HomeImg = "6.png",
                        AwayImg = "11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011661,
                        LeagueId = 20120650,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Senegal",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:52:00"),
                        HomeImg = "14.png",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011656,
                        LeagueId = 20120650,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Irã",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T13:49:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "1.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011653,
                        LeagueId = 20120650,
                        HomeTeam = "Arábia Saudita",
                        AwayTeam = "Costa Rica",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:46:00"),
                        HomeImg = "Arábia Saudita.png",
                        AwayImg = "22.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011646,
                        LeagueId = 20120650,
                        HomeTeam = "Polônia",
                        AwayTeam = "Qatar",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:43:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "Qatar.jpg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011642,
                        LeagueId = 20120650,
                        HomeTeam = "México",
                        AwayTeam = "Equador",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:40:00"),
                        HomeImg = "20.png",
                        AwayImg = "13.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011638,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "País de Gales",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:37:00"),
                        HomeImg = "18.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011633,
                        LeagueId = 20120650,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Qatar",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:34:00"),
                        HomeImg = "32.png",
                        AwayImg = "Qatar.jpg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011630,
                        LeagueId = 20120650,
                        HomeTeam = "Suíça",
                        AwayTeam = "Dinamarca",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T13:31:00"),
                        HomeImg = "12.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011625,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "Espanha",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:28:00"),
                        HomeImg = "18.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011621,
                        LeagueId = 20120650,
                        HomeTeam = "Camarões",
                        AwayTeam = "Coréia Do Sul",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:25:00"),
                        HomeImg = "6.png",
                        AwayImg = "26.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011617,
                        LeagueId = 20120650,
                        HomeTeam = "Costa Rica",
                        AwayTeam = "Inglaterra",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T13:22:00"),
                        HomeImg = "22.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011612,
                        LeagueId = 20120650,
                        HomeTeam = "Canadá",
                        AwayTeam = "Eua",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:19:00"),
                        HomeImg = "Canadá.png",
                        AwayImg = "21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011608,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "França",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T13:16:00"),
                        HomeImg = "18.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011603,
                        LeagueId = 20120650,
                        HomeTeam = "Canadá",
                        AwayTeam = "Argentina",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T13:13:00"),
                        HomeImg = "Canadá.png",
                        AwayImg = "8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011599,
                        LeagueId = 20120650,
                        HomeTeam = "Sérvia",
                        AwayTeam = "Qatar",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T13:10:00"),
                        HomeImg = "eu_7.png",
                        AwayImg = "Qatar.jpg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011594,
                        LeagueId = 20120650,
                        HomeTeam = "Uruguai",
                        AwayTeam = "Camarões",
                        SumScore = 4,
                        FinalTimeResult = "4-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T13:07:00"),
                        HomeImg = "23.png",
                        AwayImg = "6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011590,
                        LeagueId = 20120650,
                        HomeTeam = "Coréia Do Sul",
                        AwayTeam = "Polônia",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T13:04:00"),
                        HomeImg = "26.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011586,
                        LeagueId = 20120650,
                        HomeTeam = "Equador",
                        AwayTeam = "Sérvia",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:01:00"),
                        HomeImg = "13.png",
                        AwayImg = "eu_7.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011581,
                        LeagueId = 20120650,
                        HomeTeam = "Uruguai",
                        AwayTeam = "Senegal",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:58:00"),
                        HomeImg = "23.png",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011576,
                        LeagueId = 20120650,
                        HomeTeam = "Arábia Saudita",
                        AwayTeam = "Países Baixos",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T12:55:00"),
                        HomeImg = "Arábia Saudita.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011571,
                        LeagueId = 20120650,
                        HomeTeam = "Suíça",
                        AwayTeam = "Equador",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:52:00"),
                        HomeImg = "12.png",
                        AwayImg = "13.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011568,
                        LeagueId = 20120650,
                        HomeTeam = "Japão",
                        AwayTeam = "País de Gales",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:49:00"),
                        HomeImg = "16.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011564,
                        LeagueId = 20120650,
                        HomeTeam = "Brasil",
                        AwayTeam = "Inglaterra",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:46:00"),
                        HomeImg = "19.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011559,
                        LeagueId = 20120650,
                        HomeTeam = "Equador",
                        AwayTeam = "Suíça",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:43:00"),
                        HomeImg = "13.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011556,
                        LeagueId = 20120650,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Tunísia",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:40:00"),
                        HomeImg = "14.png",
                        AwayImg = "Tunísia.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011552,
                        LeagueId = 20120650,
                        HomeTeam = "México",
                        AwayTeam = "Camarões",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:37:00"),
                        HomeImg = "20.png",
                        AwayImg = "6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011548,
                        LeagueId = 20120650,
                        HomeTeam = "Costa Rica",
                        AwayTeam = "Tunísia",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:34:00"),
                        HomeImg = "22.png",
                        AwayImg = "Tunísia.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011544,
                        LeagueId = 20120650,
                        HomeTeam = "Portugal",
                        AwayTeam = "França",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:31:00"),
                        HomeImg = "28.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011540,
                        LeagueId = 20120650,
                        HomeTeam = "Polônia",
                        AwayTeam = "Sérvia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:28:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "eu_7.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011535,
                        LeagueId = 20120650,
                        HomeTeam = "Marrocos",
                        AwayTeam = "Uruguai",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:25:00"),
                        HomeImg = "Marrocos.png",
                        AwayImg = "23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011531,
                        LeagueId = 20120650,
                        HomeTeam = "Irã",
                        AwayTeam = "México",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T12:22:00"),
                        HomeImg = "1.png",
                        AwayImg = "20.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011526,
                        LeagueId = 20120650,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Camarões",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T12:19:00"),
                        HomeImg = "14.png",
                        AwayImg = "6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011522,
                        LeagueId = 20120650,
                        HomeTeam = "Brasil",
                        AwayTeam = "França",
                        SumScore = 5,
                        FinalTimeResult = "4-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T12:16:00"),
                        HomeImg = "19.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011517,
                        LeagueId = 20120650,
                        HomeTeam = "Marrocos",
                        AwayTeam = "Espanha",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T12:13:00"),
                        HomeImg = "Marrocos.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011513,
                        LeagueId = 20120650,
                        HomeTeam = "Canadá",
                        AwayTeam = "Qatar",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:10:00"),
                        HomeImg = "Canadá.png",
                        AwayImg = "Qatar.jpg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011509,
                        LeagueId = 20120650,
                        HomeTeam = "Argentina",
                        AwayTeam = "Espanha",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:07:00"),
                        HomeImg = "8.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011505,
                        LeagueId = 20120650,
                        HomeTeam = "Irã",
                        AwayTeam = "Portugal",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T12:04:00"),
                        HomeImg = "1.png",
                        AwayImg = "28.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011501,
                        LeagueId = 20120650,
                        HomeTeam = "Qatar",
                        AwayTeam = "Coréia Do Sul",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T12:01:00"),
                        HomeImg = "Qatar.jpg",
                        AwayImg = "26.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011496,
                        LeagueId = 20120650,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Arábia Saudita",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:58:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "Arábia Saudita.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011492,
                        LeagueId = 20120650,
                        HomeTeam = "Argentina",
                        AwayTeam = "Inglaterra",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:55:00"),
                        HomeImg = "8.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011488,
                        LeagueId = 20120650,
                        HomeTeam = "Austrália",
                        AwayTeam = "País de Gales",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:52:00"),
                        HomeImg = "25.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011483,
                        LeagueId = 20120650,
                        HomeTeam = "Sérvia",
                        AwayTeam = "Senegal",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:49:00"),
                        HomeImg = "eu_7.png",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011480,
                        LeagueId = 20120650,
                        HomeTeam = "Polônia",
                        AwayTeam = "País de Gales",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T11:46:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011475,
                        LeagueId = 20120650,
                        HomeTeam = "Qatar",
                        AwayTeam = "Inglaterra",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:43:00"),
                        HomeImg = "Qatar.jpg",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011472,
                        LeagueId = 20120650,
                        HomeTeam = "Eua",
                        AwayTeam = "França",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:40:00"),
                        HomeImg = "21.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011466,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "Inglaterra",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:37:00"),
                        HomeImg = "18.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011463,
                        LeagueId = 20120650,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Japão",
                        SumScore = 5,
                        FinalTimeResult = "4-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T11:34:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "16.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011458,
                        LeagueId = 20120650,
                        HomeTeam = "França",
                        AwayTeam = "México",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:31:00"),
                        HomeImg = "31.png",
                        AwayImg = "20.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011454,
                        LeagueId = 20120650,
                        HomeTeam = "Uruguai",
                        AwayTeam = "Irã",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:28:00"),
                        HomeImg = "23.png",
                        AwayImg = "1.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011450,
                        LeagueId = 20120650,
                        HomeTeam = "Argentina",
                        AwayTeam = "Senegal",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:25:00"),
                        HomeImg = "8.png",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011446,
                        LeagueId = 20120650,
                        HomeTeam = "Qatar",
                        AwayTeam = "Costa Rica",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:22:00"),
                        HomeImg = "Qatar.jpg",
                        AwayImg = "22.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011442,
                        LeagueId = 20120650,
                        HomeTeam = "Canadá",
                        AwayTeam = "Espanha",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:19:00"),
                        HomeImg = "Canadá.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011438,
                        LeagueId = 20120650,
                        HomeTeam = "Tunísia",
                        AwayTeam = "Gana",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:16:00"),
                        HomeImg = "Tunísia.png",
                        AwayImg = "11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011434,
                        LeagueId = 20120650,
                        HomeTeam = "Coréia Do Sul",
                        AwayTeam = "Uruguai",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:13:00"),
                        HomeImg = "26.png",
                        AwayImg = "23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011431,
                        LeagueId = 20120650,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Croácia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:10:00"),
                        HomeImg = "32.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011426,
                        LeagueId = 20120650,
                        HomeTeam = "Tunísia",
                        AwayTeam = "Países Baixos",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:07:00"),
                        HomeImg = "Tunísia.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011422,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "Sérvia",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T11:04:00"),
                        HomeImg = "18.png",
                        AwayImg = "eu_7.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011418,
                        LeagueId = 20120650,
                        HomeTeam = "Equador",
                        AwayTeam = "Bélgica",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T11:01:00"),
                        HomeImg = "13.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011414,
                        LeagueId = 20120650,
                        HomeTeam = "Coréia Do Sul",
                        AwayTeam = "Portugal",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:58:00"),
                        HomeImg = "26.png",
                        AwayImg = "28.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011411,
                        LeagueId = 20120650,
                        HomeTeam = "Senegal",
                        AwayTeam = "Croácia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:55:00"),
                        HomeImg = "Senegal.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011407,
                        LeagueId = 20120650,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Alemanha",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T10:52:00"),
                        HomeImg = "32.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011403,
                        LeagueId = 20120650,
                        HomeTeam = "Arábia Saudita",
                        AwayTeam = "México",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:49:00"),
                        HomeImg = "Arábia Saudita.png",
                        AwayImg = "20.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011399,
                        LeagueId = 20120650,
                        HomeTeam = "Japão",
                        AwayTeam = "Polônia",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:46:00"),
                        HomeImg = "16.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011393,
                        LeagueId = 20120650,
                        HomeTeam = "Coréia Do Sul",
                        AwayTeam = "Costa Rica",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T10:43:00"),
                        HomeImg = "26.png",
                        AwayImg = "22.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011390,
                        LeagueId = 20120650,
                        HomeTeam = "Arábia Saudita",
                        AwayTeam = "Argentina",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:40:00"),
                        HomeImg = "Arábia Saudita.png",
                        AwayImg = "8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011385,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "Austrália",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T10:37:00"),
                        HomeImg = "18.png",
                        AwayImg = "25.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011380,
                        LeagueId = 20120650,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Gana",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T10:34:00"),
                        HomeImg = "14.png",
                        AwayImg = "11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011376,
                        LeagueId = 20120650,
                        HomeTeam = "México",
                        AwayTeam = "Coréia Do Sul",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T10:31:00"),
                        HomeImg = "20.png",
                        AwayImg = "26.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011372,
                        LeagueId = 20120650,
                        HomeTeam = "Costa Rica",
                        AwayTeam = "Camarões",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:28:00"),
                        HomeImg = "22.png",
                        AwayImg = "6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011368,
                        LeagueId = 20120650,
                        HomeTeam = "Suíça",
                        AwayTeam = "Uruguai",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:25:00"),
                        HomeImg = "12.png",
                        AwayImg = "23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011364,
                        LeagueId = 20120650,
                        HomeTeam = "Costa Rica",
                        AwayTeam = "Irã",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T10:22:00"),
                        HomeImg = "22.png",
                        AwayImg = "1.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011359,
                        LeagueId = 20120650,
                        HomeTeam = "Tunísia",
                        AwayTeam = "Polônia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T10:19:00"),
                        HomeImg = "Tunísia.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011355,
                        LeagueId = 20120650,
                        HomeTeam = "Austrália",
                        AwayTeam = "Japão",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:16:00"),
                        HomeImg = "25.png",
                        AwayImg = "16.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011352,
                        LeagueId = 20120650,
                        HomeTeam = "Canadá",
                        AwayTeam = "Polônia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:13:00"),
                        HomeImg = "Canadá.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011348,
                        LeagueId = 20120650,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Senegal",
                        SumScore = 6,
                        FinalTimeResult = "5+-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T10:10:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011344,
                        LeagueId = 20120650,
                        HomeTeam = "Coréia Do Sul",
                        AwayTeam = "Brasil",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T10:07:00"),
                        HomeImg = "26.png",
                        AwayImg = "19.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011339,
                        LeagueId = 20120650,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Dinamarca",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:04:00"),
                        HomeImg = "32.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011335,
                        LeagueId = 20120650,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Coréia Do Sul",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T10:01:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "26.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011331,
                        LeagueId = 20120650,
                        HomeTeam = "Austrália",
                        AwayTeam = "Canadá",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T09:58:00"),
                        HomeImg = "25.png",
                        AwayImg = "Canadá.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011328,
                        LeagueId = 20120650,
                        HomeTeam = "Suíça",
                        AwayTeam = "Senegal",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:55:00"),
                        HomeImg = "12.png",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011323,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "Marrocos",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T09:52:00"),
                        HomeImg = "18.png",
                        AwayImg = "Marrocos.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011319,
                        LeagueId = 20120650,
                        HomeTeam = "Senegal",
                        AwayTeam = "Sérvia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T09:49:00"),
                        HomeImg = "Senegal.png",
                        AwayImg = "eu_7.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011315,
                        LeagueId = 20120650,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Japão",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T09:46:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "16.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011312,
                        LeagueId = 20120650,
                        HomeTeam = "Argentina",
                        AwayTeam = "Polônia",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T09:43:00"),
                        HomeImg = "8.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011307,
                        LeagueId = 20120650,
                        HomeTeam = "Suíça",
                        AwayTeam = "Canadá",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T09:40:00"),
                        HomeImg = "12.png",
                        AwayImg = "Canadá.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011303,
                        LeagueId = 20120650,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Bélgica",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T09:37:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011299,
                        LeagueId = 20120650,
                        HomeTeam = "Senegal",
                        AwayTeam = "Camarões",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T09:34:00"),
                        HomeImg = "Senegal.png",
                        AwayImg = "6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011296,
                        LeagueId = 20120650,
                        HomeTeam = "Japão",
                        AwayTeam = "Marrocos",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T09:31:00"),
                        HomeImg = "16.png",
                        AwayImg = "Marrocos.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011291,
                        LeagueId = 20120650,
                        HomeTeam = "Gana",
                        AwayTeam = "Brasil",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T09:28:00"),
                        HomeImg = "11.png",
                        AwayImg = "19.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011287,
                        LeagueId = 20120650,
                        HomeTeam = "Irã",
                        AwayTeam = "Argentina",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T09:25:00"),
                        HomeImg = "1.png",
                        AwayImg = "8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011283,
                        LeagueId = 20120650,
                        HomeTeam = "Eua",
                        AwayTeam = "Senegal",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:22:00"),
                        HomeImg = "21.png",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011279,
                        LeagueId = 20120650,
                        HomeTeam = "França",
                        AwayTeam = "País de Gales",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T09:19:00"),
                        HomeImg = "31.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011274,
                        LeagueId = 20120650,
                        HomeTeam = "Espanha",
                        AwayTeam = "Coréia Do Sul",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:16:00"),
                        HomeImg = "4.png",
                        AwayImg = "26.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011270,
                        LeagueId = 20120650,
                        HomeTeam = "Brasil",
                        AwayTeam = "País de Gales",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T09:13:00"),
                        HomeImg = "19.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011266,
                        LeagueId = 20120650,
                        HomeTeam = "França",
                        AwayTeam = "Coréia Do Sul",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:10:00"),
                        HomeImg = "31.png",
                        AwayImg = "26.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011262,
                        LeagueId = 20120650,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Austrália",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T09:07:00"),
                        HomeImg = "32.png",
                        AwayImg = "25.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011258,
                        LeagueId = 20120650,
                        HomeTeam = "Polônia",
                        AwayTeam = "Senegal",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T09:04:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011254,
                        LeagueId = 20120650,
                        HomeTeam = "Tunísia",
                        AwayTeam = "Alemanha",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:01:00"),
                        HomeImg = "Tunísia.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011249,
                        LeagueId = 20120650,
                        HomeTeam = "Camarões",
                        AwayTeam = "Austrália",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:58:00"),
                        HomeImg = "6.png",
                        AwayImg = "25.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011244,
                        LeagueId = 20120650,
                        HomeTeam = "Gana",
                        AwayTeam = "Eua",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:55:00"),
                        HomeImg = "11.png",
                        AwayImg = "21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011239,
                        LeagueId = 20120650,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Croácia",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T08:52:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011236,
                        LeagueId = 20120650,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Austrália",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T08:49:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "25.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011232,
                        LeagueId = 20120650,
                        HomeTeam = "Costa Rica",
                        AwayTeam = "Alemanha",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T08:46:00"),
                        HomeImg = "22.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011228,
                        LeagueId = 20120650,
                        HomeTeam = "Equador",
                        AwayTeam = "Coréia Do Sul",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:43:00"),
                        HomeImg = "13.png",
                        AwayImg = "26.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011223,
                        LeagueId = 20120650,
                        HomeTeam = "Polônia",
                        AwayTeam = "Irã",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:40:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "1.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011220,
                        LeagueId = 20120650,
                        HomeTeam = "Gana",
                        AwayTeam = "Marrocos",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:37:00"),
                        HomeImg = "11.png",
                        AwayImg = "Marrocos.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011216,
                        LeagueId = 20120650,
                        HomeTeam = "Austrália",
                        AwayTeam = "Sérvia",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:34:00"),
                        HomeImg = "25.png",
                        AwayImg = "eu_7.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011212,
                        LeagueId = 20120650,
                        HomeTeam = "Arábia Saudita",
                        AwayTeam = "França",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:31:00"),
                        HomeImg = "Arábia Saudita.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011206,
                        LeagueId = 20120650,
                        HomeTeam = "Argentina",
                        AwayTeam = "Sérvia",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T08:28:00"),
                        HomeImg = "8.png",
                        AwayImg = "eu_7.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011202,
                        LeagueId = 20120650,
                        HomeTeam = "Polônia",
                        AwayTeam = "Suíça",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:25:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011198,
                        LeagueId = 20120650,
                        HomeTeam = "França",
                        AwayTeam = "Alemanha",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T08:22:00"),
                        HomeImg = "31.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011194,
                        LeagueId = 20120650,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Costa Rica",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T08:19:00"),
                        HomeImg = "32.png",
                        AwayImg = "22.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011190,
                        LeagueId = 20120650,
                        HomeTeam = "Suíça",
                        AwayTeam = "Gana",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:16:00"),
                        HomeImg = "12.png",
                        AwayImg = "11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011188,
                        LeagueId = 20120650,
                        HomeTeam = "Japão",
                        AwayTeam = "Bélgica",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:13:00"),
                        HomeImg = "16.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011182,
                        LeagueId = 20120650,
                        HomeTeam = "Senegal",
                        AwayTeam = "Canadá",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T08:10:00"),
                        HomeImg = "Senegal.png",
                        AwayImg = "Canadá.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011178,
                        LeagueId = 20120650,
                        HomeTeam = "Sérvia",
                        AwayTeam = "Costa Rica",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:07:00"),
                        HomeImg = "eu_7.png",
                        AwayImg = "22.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011173,
                        LeagueId = 20120650,
                        HomeTeam = "Suíça",
                        AwayTeam = "Coréia Do Sul",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:04:00"),
                        HomeImg = "12.png",
                        AwayImg = "26.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011169,
                        LeagueId = 20120650,
                        HomeTeam = "Argentina",
                        AwayTeam = "Croácia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:01:00"),
                        HomeImg = "8.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011165,
                        LeagueId = 20120650,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Arábia Saudita",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:58:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "Arábia Saudita.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011161,
                        LeagueId = 20120650,
                        HomeTeam = "Tunísia",
                        AwayTeam = "Bélgica",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:55:00"),
                        HomeImg = "Tunísia.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011158,
                        LeagueId = 20120650,
                        HomeTeam = "Qatar",
                        AwayTeam = "Senegal",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T07:52:00"),
                        HomeImg = "Qatar.jpg",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011153,
                        LeagueId = 20120650,
                        HomeTeam = "Canadá",
                        AwayTeam = "Inglaterra",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:49:00"),
                        HomeImg = "Canadá.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011150,
                        LeagueId = 20120650,
                        HomeTeam = "Senegal",
                        AwayTeam = "Austrália",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T07:46:00"),
                        HomeImg = "Senegal.png",
                        AwayImg = "25.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011146,
                        LeagueId = 20120650,
                        HomeTeam = "Polônia",
                        AwayTeam = "Tunísia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:43:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "Tunísia.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011142,
                        LeagueId = 20120650,
                        HomeTeam = "Equador",
                        AwayTeam = "Gana",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:40:00"),
                        HomeImg = "13.png",
                        AwayImg = "11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011138,
                        LeagueId = 20120650,
                        HomeTeam = "Canadá",
                        AwayTeam = "Uruguai",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:37:00"),
                        HomeImg = "Canadá.png",
                        AwayImg = "23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011132,
                        LeagueId = 20120650,
                        HomeTeam = "Arábia Saudita",
                        AwayTeam = "Inglaterra",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T07:34:00"),
                        HomeImg = "Arábia Saudita.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011127,
                        LeagueId = 20120650,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Marrocos",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:31:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "Marrocos.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011123,
                        LeagueId = 20120650,
                        HomeTeam = "Qatar",
                        AwayTeam = "México",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:28:00"),
                        HomeImg = "Qatar.jpg",
                        AwayImg = "20.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011119,
                        LeagueId = 20120650,
                        HomeTeam = "Equador",
                        AwayTeam = "Irã",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:25:00"),
                        HomeImg = "13.png",
                        AwayImg = "1.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011116,
                        LeagueId = 20120650,
                        HomeTeam = "Alemanha",
                        AwayTeam = "França",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T07:22:00"),
                        HomeImg = "9.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011111,
                        LeagueId = 20120650,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Bélgica",
                        SumScore = 6,
                        FinalTimeResult = "5+-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T07:19:00"),
                        HomeImg = "14.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011107,
                        LeagueId = 20120650,
                        HomeTeam = "França",
                        AwayTeam = "Polônia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:16:00"),
                        HomeImg = "31.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011103,
                        LeagueId = 20120650,
                        HomeTeam = "Austrália",
                        AwayTeam = "Marrocos",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T07:13:00"),
                        HomeImg = "25.png",
                        AwayImg = "Marrocos.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011099,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "Irã",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:10:00"),
                        HomeImg = "18.png",
                        AwayImg = "1.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011095,
                        LeagueId = 20120650,
                        HomeTeam = "Brasil",
                        AwayTeam = "Canadá",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:07:00"),
                        HomeImg = "19.png",
                        AwayImg = "Canadá.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011092,
                        LeagueId = 20120650,
                        HomeTeam = "Japão",
                        AwayTeam = "México",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T07:04:00"),
                        HomeImg = "16.png",
                        AwayImg = "20.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011088,
                        LeagueId = 20120650,
                        HomeTeam = "Argentina",
                        AwayTeam = "Camarões",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T07:01:00"),
                        HomeImg = "8.png",
                        AwayImg = "6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011083,
                        LeagueId = 20120650,
                        HomeTeam = "México",
                        AwayTeam = "Canadá",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:58:00"),
                        HomeImg = "20.png",
                        AwayImg = "Canadá.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011080,
                        LeagueId = 20120650,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Inglaterra",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T06:55:00"),
                        HomeImg = "32.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011076,
                        LeagueId = 20120650,
                        HomeTeam = "Equador",
                        AwayTeam = "Tunísia",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:52:00"),
                        HomeImg = "13.png",
                        AwayImg = "Tunísia.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011072,
                        LeagueId = 20120650,
                        HomeTeam = "Argentina",
                        AwayTeam = "México",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T06:49:00"),
                        HomeImg = "8.png",
                        AwayImg = "20.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011067,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "Suíça",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:46:00"),
                        HomeImg = "18.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011063,
                        LeagueId = 20120650,
                        HomeTeam = "Coréia Do Sul",
                        AwayTeam = "Tunísia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:43:00"),
                        HomeImg = "26.png",
                        AwayImg = "Tunísia.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011059,
                        LeagueId = 20120650,
                        HomeTeam = "Uruguai",
                        AwayTeam = "País de Gales",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T06:40:00"),
                        HomeImg = "23.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011053,
                        LeagueId = 20120650,
                        HomeTeam = "Brasil",
                        AwayTeam = "Camarões",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T06:37:00"),
                        HomeImg = "19.png",
                        AwayImg = "6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011050,
                        LeagueId = 20120650,
                        HomeTeam = "Tunísia",
                        AwayTeam = "Croácia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:34:00"),
                        HomeImg = "Tunísia.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011046,
                        LeagueId = 20120650,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Austrália",
                        SumScore = 6,
                        FinalTimeResult = "5+-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T06:31:00"),
                        HomeImg = "9.png",
                        AwayImg = "25.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011042,
                        LeagueId = 20120650,
                        HomeTeam = "Eua",
                        AwayTeam = "Gana",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T06:28:00"),
                        HomeImg = "21.png",
                        AwayImg = "11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011038,
                        LeagueId = 20120650,
                        HomeTeam = "Sérvia",
                        AwayTeam = "País de Gales",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:25:00"),
                        HomeImg = "eu_7.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011033,
                        LeagueId = 20120650,
                        HomeTeam = "Senegal",
                        AwayTeam = "França",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:22:00"),
                        HomeImg = "Senegal.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011030,
                        LeagueId = 20120650,
                        HomeTeam = "Austrália",
                        AwayTeam = "Países Baixos",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:19:00"),
                        HomeImg = "25.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011026,
                        LeagueId = 20120650,
                        HomeTeam = "Equador",
                        AwayTeam = "Arábia Saudita",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:16:00"),
                        HomeImg = "13.png",
                        AwayImg = "Arábia Saudita.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011022,
                        LeagueId = 20120650,
                        HomeTeam = "Espanha",
                        AwayTeam = "Irã",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T06:13:00"),
                        HomeImg = "4.png",
                        AwayImg = "1.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011018,
                        LeagueId = 20120650,
                        HomeTeam = "Senegal",
                        AwayTeam = "Polônia",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:10:00"),
                        HomeImg = "Senegal.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011013,
                        LeagueId = 20120650,
                        HomeTeam = "Austrália",
                        AwayTeam = "Qatar",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:07:00"),
                        HomeImg = "25.png",
                        AwayImg = "Qatar.jpg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011009,
                        LeagueId = 20120650,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Suíça",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T06:04:00"),
                        HomeImg = "14.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011005,
                        LeagueId = 20120650,
                        HomeTeam = "Austrália",
                        AwayTeam = "Bélgica",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:01:00"),
                        HomeImg = "25.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011001,
                        LeagueId = 20120650,
                        HomeTeam = "Portugal",
                        AwayTeam = "Espanha",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:58:00"),
                        HomeImg = "28.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010996,
                        LeagueId = 20120650,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Qatar",
                        SumScore = 5,
                        FinalTimeResult = "1-4",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T05:55:00"),
                        HomeImg = "14.png",
                        AwayImg = "Qatar.jpg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010993,
                        LeagueId = 20120650,
                        HomeTeam = "Suíça",
                        AwayTeam = "Brasil",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:52:00"),
                        HomeImg = "12.png",
                        AwayImg = "19.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010988,
                        LeagueId = 20120650,
                        HomeTeam = "Sérvia",
                        AwayTeam = "Arábia Saudita",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T05:49:00"),
                        HomeImg = "eu_7.png",
                        AwayImg = "Arábia Saudita.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010985,
                        LeagueId = 20120650,
                        HomeTeam = "Eua",
                        AwayTeam = "Inglaterra",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:46:00"),
                        HomeImg = "21.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010980,
                        LeagueId = 20120650,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Irã",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:43:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "1.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010976,
                        LeagueId = 20120650,
                        HomeTeam = "Sérvia",
                        AwayTeam = "Equador",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:40:00"),
                        HomeImg = "eu_7.png",
                        AwayImg = "13.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010972,
                        LeagueId = 20120650,
                        HomeTeam = "Uruguai",
                        AwayTeam = "Coréia Do Sul",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:37:00"),
                        HomeImg = "23.png",
                        AwayImg = "26.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010967,
                        LeagueId = 20120650,
                        HomeTeam = "Marrocos",
                        AwayTeam = "Argentina",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T05:34:00"),
                        HomeImg = "Marrocos.png",
                        AwayImg = "8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010964,
                        LeagueId = 20120650,
                        HomeTeam = "Austrália",
                        AwayTeam = "País de Gales",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:31:00"),
                        HomeImg = "25.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010959,
                        LeagueId = 20120650,
                        HomeTeam = "Brasil",
                        AwayTeam = "Senegal",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:28:00"),
                        HomeImg = "19.png",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010955,
                        LeagueId = 20120650,
                        HomeTeam = "Gana",
                        AwayTeam = "Dinamarca",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T05:25:00"),
                        HomeImg = "11.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010950,
                        LeagueId = 20120650,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Equador",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:22:00"),
                        HomeImg = "9.png",
                        AwayImg = "13.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010944,
                        LeagueId = 20120650,
                        HomeTeam = "Espanha",
                        AwayTeam = "Eua",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:19:00"),
                        HomeImg = "4.png",
                        AwayImg = "21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010940,
                        LeagueId = 20120650,
                        HomeTeam = "Costa Rica",
                        AwayTeam = "Portugal",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T05:16:00"),
                        HomeImg = "22.png",
                        AwayImg = "28.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010937,
                        LeagueId = 20120650,
                        HomeTeam = "Japão",
                        AwayTeam = "Qatar",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T05:13:00"),
                        HomeImg = "16.png",
                        AwayImg = "Qatar.jpg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010932,
                        LeagueId = 20120650,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Equador",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:10:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "13.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010927,
                        LeagueId = 20120650,
                        HomeTeam = "Irã",
                        AwayTeam = "México",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T05:07:00"),
                        HomeImg = "1.png",
                        AwayImg = "20.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010923,
                        LeagueId = 20120650,
                        HomeTeam = "Sérvia",
                        AwayTeam = "Inglaterra",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T05:04:00"),
                        HomeImg = "eu_7.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010920,
                        LeagueId = 20120650,
                        HomeTeam = "Arábia Saudita",
                        AwayTeam = "Costa Rica",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T05:01:00"),
                        HomeImg = "Arábia Saudita.png",
                        AwayImg = "22.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010915,
                        LeagueId = 20120650,
                        HomeTeam = "Brasil",
                        AwayTeam = "Sérvia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:58:00"),
                        HomeImg = "19.png",
                        AwayImg = "eu_7.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010910,
                        LeagueId = 20120650,
                        HomeTeam = "Qatar",
                        AwayTeam = "Países Baixos",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T04:55:00"),
                        HomeImg = "Qatar.jpg",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010905,
                        LeagueId = 20120650,
                        HomeTeam = "Gana",
                        AwayTeam = "Irã",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T04:52:00"),
                        HomeImg = "11.png",
                        AwayImg = "1.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010902,
                        LeagueId = 20120650,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Canadá",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:49:00"),
                        HomeImg = "32.png",
                        AwayImg = "Canadá.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010897,
                        LeagueId = 20120650,
                        HomeTeam = "Portugal",
                        AwayTeam = "Senegal",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:46:00"),
                        HomeImg = "28.png",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010893,
                        LeagueId = 20120650,
                        HomeTeam = "Canadá",
                        AwayTeam = "Espanha",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T04:43:00"),
                        HomeImg = "Canadá.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010890,
                        LeagueId = 20120650,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Coréia Do Sul",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:40:00"),
                        HomeImg = "14.png",
                        AwayImg = "26.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010885,
                        LeagueId = 20120650,
                        HomeTeam = "Portugal",
                        AwayTeam = "Sérvia",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:37:00"),
                        HomeImg = "28.png",
                        AwayImg = "eu_7.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010881,
                        LeagueId = 20120650,
                        HomeTeam = "Espanha",
                        AwayTeam = "Austrália",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:34:00"),
                        HomeImg = "4.png",
                        AwayImg = "25.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010877,
                        LeagueId = 20120650,
                        HomeTeam = "Japão",
                        AwayTeam = "França",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:31:00"),
                        HomeImg = "16.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010874,
                        LeagueId = 20120650,
                        HomeTeam = "Brasil",
                        AwayTeam = "Irã",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T04:28:00"),
                        HomeImg = "19.png",
                        AwayImg = "1.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010869,
                        LeagueId = 20120650,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Polônia",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:25:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010865,
                        LeagueId = 20120650,
                        HomeTeam = "Tunísia",
                        AwayTeam = "Canadá",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T04:22:00"),
                        HomeImg = "Tunísia.png",
                        AwayImg = "Canadá.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010861,
                        LeagueId = 20120650,
                        HomeTeam = "Coréia Do Sul",
                        AwayTeam = "Marrocos",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:19:00"),
                        HomeImg = "26.png",
                        AwayImg = "Marrocos.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010858,
                        LeagueId = 20120650,
                        HomeTeam = "Eua",
                        AwayTeam = "Polônia",
                        SumScore = 5,
                        FinalTimeResult = "4-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T04:16:00"),
                        HomeImg = "21.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010853,
                        LeagueId = 20120650,
                        HomeTeam = "Tunísia",
                        AwayTeam = "Inglaterra",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:13:00"),
                        HomeImg = "Tunísia.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010849,
                        LeagueId = 20120650,
                        HomeTeam = "Eua",
                        AwayTeam = "Costa Rica",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:10:00"),
                        HomeImg = "21.png",
                        AwayImg = "22.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010845,
                        LeagueId = 20120650,
                        HomeTeam = "Austrália",
                        AwayTeam = "Inglaterra",
                        SumScore = 5,
                        FinalTimeResult = "4-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T04:07:00"),
                        HomeImg = "25.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010841,
                        LeagueId = 20120650,
                        HomeTeam = "Arábia Saudita",
                        AwayTeam = "Polônia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:04:00"),
                        HomeImg = "Arábia Saudita.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010838,
                        LeagueId = 20120650,
                        HomeTeam = "Eua",
                        AwayTeam = "Países Baixos",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:01:00"),
                        HomeImg = "21.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010834,
                        LeagueId = 20120650,
                        HomeTeam = "Brasil",
                        AwayTeam = "França",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T03:58:00"),
                        HomeImg = "19.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010830,
                        LeagueId = 20120650,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Países Baixos",
                        SumScore = 6,
                        FinalTimeResult = "1-5+",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T03:55:00"),
                        HomeImg = "32.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010826,
                        LeagueId = 20120650,
                        HomeTeam = "Marrocos",
                        AwayTeam = "Uruguai",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:52:00"),
                        HomeImg = "Marrocos.png",
                        AwayImg = "23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010822,
                        LeagueId = 20120650,
                        HomeTeam = "Canadá",
                        AwayTeam = "Dinamarca",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T03:49:00"),
                        HomeImg = "Canadá.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010817,
                        LeagueId = 20120650,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Costa Rica",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T03:46:00"),
                        HomeImg = "9.png",
                        AwayImg = "22.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010813,
                        LeagueId = 20120650,
                        HomeTeam = "Austrália",
                        AwayTeam = "Gana",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T03:43:00"),
                        HomeImg = "25.png",
                        AwayImg = "11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010808,
                        LeagueId = 20120650,
                        HomeTeam = "Arábia Saudita",
                        AwayTeam = "Bélgica",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:40:00"),
                        HomeImg = "Arábia Saudita.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010805,
                        LeagueId = 20120650,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Sérvia",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T03:37:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "eu_7.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010800,
                        LeagueId = 20120650,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Alemanha",
                        SumScore = 4,
                        FinalTimeResult = "0-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T03:34:00"),
                        HomeImg = "14.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010797,
                        LeagueId = 20120650,
                        HomeTeam = "Espanha",
                        AwayTeam = "Equador",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:31:00"),
                        HomeImg = "4.png",
                        AwayImg = "13.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010793,
                        LeagueId = 20120650,
                        HomeTeam = "Qatar",
                        AwayTeam = "País de Gales",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T03:28:00"),
                        HomeImg = "Qatar.jpg",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010788,
                        LeagueId = 20120650,
                        HomeTeam = "Argentina",
                        AwayTeam = "Coréia Do Sul",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T03:25:00"),
                        HomeImg = "8.png",
                        AwayImg = "26.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010785,
                        LeagueId = 20120650,
                        HomeTeam = "Qatar",
                        AwayTeam = "Japão",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:22:00"),
                        HomeImg = "Qatar.jpg",
                        AwayImg = "16.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010780,
                        LeagueId = 20120650,
                        HomeTeam = "Canadá",
                        AwayTeam = "Suíça",
                        SumScore = 5,
                        FinalTimeResult = "4-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T03:19:00"),
                        HomeImg = "Canadá.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010775,
                        LeagueId = 20120650,
                        HomeTeam = "Arábia Saudita",
                        AwayTeam = "Equador",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T03:16:00"),
                        HomeImg = "Arábia Saudita.png",
                        AwayImg = "13.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010770,
                        LeagueId = 20120650,
                        HomeTeam = "Senegal",
                        AwayTeam = "Irã",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:13:00"),
                        HomeImg = "Senegal.png",
                        AwayImg = "1.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010766,
                        LeagueId = 20120650,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Portugal",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T03:10:00"),
                        HomeImg = "32.png",
                        AwayImg = "28.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010763,
                        LeagueId = 20120650,
                        HomeTeam = "Marrocos",
                        AwayTeam = "Suíça",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T03:07:00"),
                        HomeImg = "Marrocos.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010758,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "México",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:04:00"),
                        HomeImg = "18.png",
                        AwayImg = "20.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010755,
                        LeagueId = 20120650,
                        HomeTeam = "Portugal",
                        AwayTeam = "Países Baixos",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:01:00"),
                        HomeImg = "28.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010751,
                        LeagueId = 20120650,
                        HomeTeam = "Costa Rica",
                        AwayTeam = "Croácia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:58:00"),
                        HomeImg = "22.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010746,
                        LeagueId = 20120650,
                        HomeTeam = "Arábia Saudita",
                        AwayTeam = "Brasil",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T02:55:00"),
                        HomeImg = "Arábia Saudita.png",
                        AwayImg = "19.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010740,
                        LeagueId = 20120650,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Croácia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:52:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010737,
                        LeagueId = 20120650,
                        HomeTeam = "Coréia Do Sul",
                        AwayTeam = "País de Gales",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:49:00"),
                        HomeImg = "26.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010733,
                        LeagueId = 20120650,
                        HomeTeam = "Costa Rica",
                        AwayTeam = "Espanha",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:46:00"),
                        HomeImg = "22.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010729,
                        LeagueId = 20120650,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Canadá",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:43:00"),
                        HomeImg = "9.png",
                        AwayImg = "Canadá.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010723,
                        LeagueId = 20120650,
                        HomeTeam = "Eua",
                        AwayTeam = "Camarões",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:40:00"),
                        HomeImg = "21.png",
                        AwayImg = "6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010719,
                        LeagueId = 20120650,
                        HomeTeam = "Gana",
                        AwayTeam = "Arábia Saudita",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T02:37:00"),
                        HomeImg = "11.png",
                        AwayImg = "Arábia Saudita.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010714,
                        LeagueId = 20120650,
                        HomeTeam = "Coréia Do Sul",
                        AwayTeam = "Equador",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:34:00"),
                        HomeImg = "26.png",
                        AwayImg = "13.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010710,
                        LeagueId = 20120650,
                        HomeTeam = "Gana",
                        AwayTeam = "Espanha",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T02:31:00"),
                        HomeImg = "11.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010707,
                        LeagueId = 20120650,
                        HomeTeam = "França",
                        AwayTeam = "Brasil",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T02:28:00"),
                        HomeImg = "31.png",
                        AwayImg = "19.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010702,
                        LeagueId = 20120650,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Suíça",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T02:25:00"),
                        HomeImg = "9.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010698,
                        LeagueId = 20120650,
                        HomeTeam = "Costa Rica",
                        AwayTeam = "Uruguai",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T02:22:00"),
                        HomeImg = "22.png",
                        AwayImg = "23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010695,
                        LeagueId = 20120650,
                        HomeTeam = "Irã",
                        AwayTeam = "Espanha",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T02:19:00"),
                        HomeImg = "1.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010691,
                        LeagueId = 20120650,
                        HomeTeam = "Eua",
                        AwayTeam = "Canadá",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T02:16:00"),
                        HomeImg = "21.png",
                        AwayImg = "Canadá.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010686,
                        LeagueId = 20120650,
                        HomeTeam = "Marrocos",
                        AwayTeam = "Costa Rica",
                        SumScore = 5,
                        FinalTimeResult = "5+-0",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T02:13:00"),
                        HomeImg = "Marrocos.png",
                        AwayImg = "22.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010681,
                        LeagueId = 20120650,
                        HomeTeam = "Equador",
                        AwayTeam = "Eua",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T02:10:00"),
                        HomeImg = "13.png",
                        AwayImg = "21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010676,
                        LeagueId = 20120650,
                        HomeTeam = "Senegal",
                        AwayTeam = "Gana",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T02:07:00"),
                        HomeImg = "Senegal.png",
                        AwayImg = "11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010673,
                        LeagueId = 20120650,
                        HomeTeam = "Japão",
                        AwayTeam = "Países Baixos",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T02:04:00"),
                        HomeImg = "16.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010669,
                        LeagueId = 20120650,
                        HomeTeam = "Suíça",
                        AwayTeam = "Coréia Do Sul",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:01:00"),
                        HomeImg = "12.png",
                        AwayImg = "26.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010664,
                        LeagueId = 20120650,
                        HomeTeam = "México",
                        AwayTeam = "Irã",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:58:00"),
                        HomeImg = "20.png",
                        AwayImg = "1.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010661,
                        LeagueId = 20120650,
                        HomeTeam = "Marrocos",
                        AwayTeam = "Eua",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T01:55:00"),
                        HomeImg = "Marrocos.png",
                        AwayImg = "21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010657,
                        LeagueId = 20120650,
                        HomeTeam = "Camarões",
                        AwayTeam = "Gana",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:52:00"),
                        HomeImg = "6.png",
                        AwayImg = "11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010651,
                        LeagueId = 20120650,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "País de Gales",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:49:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010648,
                        LeagueId = 20120650,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Equador",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T01:46:00"),
                        HomeImg = "32.png",
                        AwayImg = "13.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010644,
                        LeagueId = 20120650,
                        HomeTeam = "México",
                        AwayTeam = "Senegal",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:43:00"),
                        HomeImg = "20.png",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010640,
                        LeagueId = 20120650,
                        HomeTeam = "Gana",
                        AwayTeam = "Suíça",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T01:40:00"),
                        HomeImg = "11.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010635,
                        LeagueId = 20120650,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Inglaterra",
                        SumScore = 4,
                        FinalTimeResult = "0-4",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:37:00"),
                        HomeImg = "9.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010631,
                        LeagueId = 20120650,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Argentina",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:34:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010628,
                        LeagueId = 20120650,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Japão",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:31:00"),
                        HomeImg = "9.png",
                        AwayImg = "16.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010623,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "Costa Rica",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:28:00"),
                        HomeImg = "18.png",
                        AwayImg = "22.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010618,
                        LeagueId = 20120650,
                        HomeTeam = "Senegal",
                        AwayTeam = "Inglaterra",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:25:00"),
                        HomeImg = "Senegal.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010612,
                        LeagueId = 20120650,
                        HomeTeam = "Irã",
                        AwayTeam = "Marrocos",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T01:22:00"),
                        HomeImg = "1.png",
                        AwayImg = "Marrocos.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010609,
                        LeagueId = 20120650,
                        HomeTeam = "Argentina",
                        AwayTeam = "Gana",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T01:19:00"),
                        HomeImg = "8.png",
                        AwayImg = "11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010605,
                        LeagueId = 20120650,
                        HomeTeam = "Camarões",
                        AwayTeam = "Tunísia",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:16:00"),
                        HomeImg = "6.png",
                        AwayImg = "Tunísia.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010597,
                        LeagueId = 20120650,
                        HomeTeam = "Coréia Do Sul",
                        AwayTeam = "Portugal",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T01:13:00"),
                        HomeImg = "26.png",
                        AwayImg = "28.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010592,
                        LeagueId = 20120650,
                        HomeTeam = "Irã",
                        AwayTeam = "Argentina",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:10:00"),
                        HomeImg = "1.png",
                        AwayImg = "8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010588,
                        LeagueId = 20120650,
                        HomeTeam = "México",
                        AwayTeam = "Equador",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:07:00"),
                        HomeImg = "20.png",
                        AwayImg = "13.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010585,
                        LeagueId = 20120650,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Croácia",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T01:04:00"),
                        HomeImg = "14.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010580,
                        LeagueId = 20120650,
                        HomeTeam = "Suíça",
                        AwayTeam = "Tunísia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:01:00"),
                        HomeImg = "12.png",
                        AwayImg = "Tunísia.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010577,
                        LeagueId = 20120650,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Gana",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:58:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010571,
                        LeagueId = 20120650,
                        HomeTeam = "Polônia",
                        AwayTeam = "México",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:55:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "20.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010568,
                        LeagueId = 20120650,
                        HomeTeam = "França",
                        AwayTeam = "Marrocos",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:52:00"),
                        HomeImg = "31.png",
                        AwayImg = "Marrocos.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010563,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "Senegal",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T00:49:00"),
                        HomeImg = "18.png",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010558,
                        LeagueId = 20120650,
                        HomeTeam = "Polônia",
                        AwayTeam = "Canadá",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:46:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "Canadá.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010555,
                        LeagueId = 20120650,
                        HomeTeam = "Portugal",
                        AwayTeam = "Dinamarca",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:43:00"),
                        HomeImg = "28.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010551,
                        LeagueId = 20120650,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Austrália",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:40:00"),
                        HomeImg = "32.png",
                        AwayImg = "25.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010546,
                        LeagueId = 20120650,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Canadá",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:37:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "Canadá.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010541,
                        LeagueId = 20120650,
                        HomeTeam = "Gana",
                        AwayTeam = "Marrocos",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:34:00"),
                        HomeImg = "11.png",
                        AwayImg = "Marrocos.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010535,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "Qatar",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:31:00"),
                        HomeImg = "18.png",
                        AwayImg = "Qatar.jpg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010531,
                        LeagueId = 20120650,
                        HomeTeam = "Argentina",
                        AwayTeam = "Japão",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:28:00"),
                        HomeImg = "8.png",
                        AwayImg = "16.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010527,
                        LeagueId = 20120650,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Gana",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T00:25:00"),
                        HomeImg = "9.png",
                        AwayImg = "11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010523,
                        LeagueId = 20120650,
                        HomeTeam = "Polônia",
                        AwayTeam = "Arábia Saudita",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:22:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "Arábia Saudita.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010518,
                        LeagueId = 20120650,
                        HomeTeam = "Croácia",
                        AwayTeam = "Inglaterra",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:19:00"),
                        HomeImg = "18.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010514,
                        LeagueId = 20120650,
                        HomeTeam = "Eua",
                        AwayTeam = "Argentina",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:16:00"),
                        HomeImg = "21.png",
                        AwayImg = "8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010510,
                        LeagueId = 20120650,
                        HomeTeam = "Senegal",
                        AwayTeam = "Marrocos",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T00:13:00"),
                        HomeImg = "Senegal.png",
                        AwayImg = "Marrocos.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010505,
                        LeagueId = 20120650,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Bélgica",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T00:10:00"),
                        HomeImg = "9.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010502,
                        LeagueId = 20120650,
                        HomeTeam = "Camarões",
                        AwayTeam = "Senegal",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:07:00"),
                        HomeImg = "6.png",
                        AwayImg = "Senegal.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010497,
                        LeagueId = 20120650,
                        HomeTeam = "Uruguai",
                        AwayTeam = "Suíça",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T00:04:00"),
                        HomeImg = "23.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010494,
                        LeagueId = 20120650,
                        HomeTeam = "Argentina",
                        AwayTeam = "Espanha",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:01:00"),
                        HomeImg = "8.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011681,
                        LeagueId = 20700663,
                        HomeTeam = "Polônia",
                        AwayTeam = "Bélgica",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T14:05:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011676,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "Itália",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T14:02:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "2.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011672,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Hungria",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:59:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011667,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "Alemanha",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:56:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011662,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Hungria",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:53:00"),
                        HomeImg = "14.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011658,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "França",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T13:50:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011654,
                        LeagueId = 20700663,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Macedônia do Norte",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T13:47:00"),
                        HomeImg = "9.png",
                        AwayImg = "eu_9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011649,
                        LeagueId = 20700663,
                        HomeTeam = "Eslováquia",
                        AwayTeam = "País de Gales",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:44:00"),
                        HomeImg = "eu_6.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011644,
                        LeagueId = 20700663,
                        HomeTeam = "Polônia",
                        AwayTeam = "Hungria",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T13:41:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011640,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "Inglaterra",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T13:38:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011635,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "Ucrânia",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T13:35:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "eu_8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011631,
                        LeagueId = 20700663,
                        HomeTeam = "Áustria",
                        AwayTeam = "Croácia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:32:00"),
                        HomeImg = "eu_11.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011627,
                        LeagueId = 20700663,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Suécia",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T13:29:00"),
                        HomeImg = "9.png",
                        AwayImg = "eu_31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011623,
                        LeagueId = 20700663,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Croácia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:26:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011619,
                        LeagueId = 20700663,
                        HomeTeam = "Hungria",
                        AwayTeam = "República Tcheca",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T13:23:00"),
                        HomeImg = "eu_34.png",
                        AwayImg = "eu_12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011614,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "Áustria",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:20:00"),
                        HomeImg = "4.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011609,
                        LeagueId = 20700663,
                        HomeTeam = "Croácia",
                        AwayTeam = "Hungria",
                        SumScore = 4,
                        FinalTimeResult = "4-0",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T13:17:00"),
                        HomeImg = "18.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011605,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "Bélgica",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:14:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011601,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "República Tcheca",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T13:11:00"),
                        HomeImg = "12.png",
                        AwayImg = "eu_12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011596,
                        LeagueId = 20700663,
                        HomeTeam = "Portugal",
                        AwayTeam = "Alemanha",
                        SumScore = 7,
                        FinalTimeResult = "5+-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T13:08:00"),
                        HomeImg = "28.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011592,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "Ucrânia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:05:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "eu_8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011587,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "País de Gales",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:02:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011583,
                        LeagueId = 20700663,
                        HomeTeam = "Itália",
                        AwayTeam = "Inglaterra",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T12:59:00"),
                        HomeImg = "2.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011578,
                        LeagueId = 20700663,
                        HomeTeam = "França",
                        AwayTeam = "Áustria",
                        SumScore = 6,
                        FinalTimeResult = "4-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T12:56:00"),
                        HomeImg = "31.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011573,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "Dinamarca",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T12:53:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011569,
                        LeagueId = 20700663,
                        HomeTeam = "Eslováquia",
                        AwayTeam = "Espanha",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T12:50:00"),
                        HomeImg = "eu_6.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011565,
                        LeagueId = 20700663,
                        HomeTeam = "Áustria",
                        AwayTeam = "Rússia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:47:00"),
                        HomeImg = "eu_11.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011561,
                        LeagueId = 20700663,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Turquia",
                        SumScore = 5,
                        FinalTimeResult = "5+-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T12:44:00"),
                        HomeImg = "32.png",
                        AwayImg = "eu_21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011557,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Croácia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T12:41:00"),
                        HomeImg = "14.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011553,
                        LeagueId = 20700663,
                        HomeTeam = "Macedônia do Norte",
                        AwayTeam = "Finlândia",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T12:38:00"),
                        HomeImg = "eu_9.png",
                        AwayImg = "eu_32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011549,
                        LeagueId = 20700663,
                        HomeTeam = "Itália",
                        AwayTeam = "Bélgica",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:35:00"),
                        HomeImg = "2.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011545,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Alemanha",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:32:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011541,
                        LeagueId = 20700663,
                        HomeTeam = "Ucrânia",
                        AwayTeam = "Suécia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:29:00"),
                        HomeImg = "eu_8.png",
                        AwayImg = "eu_31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011537,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "Dinamarca",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:26:00"),
                        HomeImg = "4.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011532,
                        LeagueId = 20700663,
                        HomeTeam = "Eslováquia",
                        AwayTeam = "Hungria",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T12:23:00"),
                        HomeImg = "eu_6.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011527,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Espanha",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T12:20:00"),
                        HomeImg = "14.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011523,
                        LeagueId = 20700663,
                        HomeTeam = "Finlândia",
                        AwayTeam = "Escócia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:17:00"),
                        HomeImg = "eu_32.png",
                        AwayImg = "eu_17.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011518,
                        LeagueId = 20700663,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Suíça",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:14:00"),
                        HomeImg = "32.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011514,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "Países Baixos",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T12:11:00"),
                        HomeImg = "4.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011510,
                        LeagueId = 20700663,
                        HomeTeam = "Hungria",
                        AwayTeam = "Itália",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:08:00"),
                        HomeImg = "eu_34.png",
                        AwayImg = "2.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011506,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "Áustria",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T12:05:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011502,
                        LeagueId = 20700663,
                        HomeTeam = "Ucrânia",
                        AwayTeam = "Macedônia do Norte",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:02:00"),
                        HomeImg = "eu_8.png",
                        AwayImg = "eu_9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011498,
                        LeagueId = 20700663,
                        HomeTeam = "Finlândia",
                        AwayTeam = "Bélgica",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:59:00"),
                        HomeImg = "eu_32.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011494,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Suécia",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:56:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "eu_31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011489,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Eslováquia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:53:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "eu_6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011485,
                        LeagueId = 20700663,
                        HomeTeam = "Portugal",
                        AwayTeam = "Finlândia",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:50:00"),
                        HomeImg = "28.png",
                        AwayImg = "eu_32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011481,
                        LeagueId = 20700663,
                        HomeTeam = "Croácia",
                        AwayTeam = "Escócia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:47:00"),
                        HomeImg = "18.png",
                        AwayImg = "eu_17.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011477,
                        LeagueId = 20700663,
                        HomeTeam = "Polônia",
                        AwayTeam = "Ucrânia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:44:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "eu_8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011473,
                        LeagueId = 20700663,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Áustria",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T11:41:00"),
                        HomeImg = "32.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011469,
                        LeagueId = 20700663,
                        HomeTeam = "Hungria",
                        AwayTeam = "Alemanha",
                        SumScore = 4,
                        FinalTimeResult = "4-0",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T11:38:00"),
                        HomeImg = "eu_34.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011464,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Eslováquia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:35:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "eu_6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011460,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Alemanha",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:32:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011456,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "França",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:29:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011452,
                        LeagueId = 20700663,
                        HomeTeam = "Hungria",
                        AwayTeam = "Espanha",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T11:26:00"),
                        HomeImg = "eu_34.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011448,
                        LeagueId = 20700663,
                        HomeTeam = "Portugal",
                        AwayTeam = "Dinamarca",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T11:23:00"),
                        HomeImg = "28.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011444,
                        LeagueId = 20700663,
                        HomeTeam = "França",
                        AwayTeam = "Ucrânia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:20:00"),
                        HomeImg = "31.png",
                        AwayImg = "eu_8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011440,
                        LeagueId = 20700663,
                        HomeTeam = "Rússia",
                        AwayTeam = "República Tcheca",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:17:00"),
                        HomeImg = "5.png",
                        AwayImg = "eu_12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011436,
                        LeagueId = 20700663,
                        HomeTeam = "Ucrânia",
                        AwayTeam = "Espanha",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T11:14:00"),
                        HomeImg = "eu_8.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011432,
                        LeagueId = 20700663,
                        HomeTeam = "Polônia",
                        AwayTeam = "Inglaterra",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:11:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011428,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Rússia",
                        SumScore = 5,
                        FinalTimeResult = "0-5+",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T11:08:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011424,
                        LeagueId = 20700663,
                        HomeTeam = "Croácia",
                        AwayTeam = "Turquia",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:05:00"),
                        HomeImg = "18.png",
                        AwayImg = "eu_21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011420,
                        LeagueId = 20700663,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "País de Gales",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T11:02:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011416,
                        LeagueId = 20700663,
                        HomeTeam = "Áustria",
                        AwayTeam = "Hungria",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:59:00"),
                        HomeImg = "eu_11.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011412,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "País de Gales",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:56:00"),
                        HomeImg = "14.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011408,
                        LeagueId = 20700663,
                        HomeTeam = "Finlândia",
                        AwayTeam = "Ucrânia",
                        SumScore = 6,
                        FinalTimeResult = "2-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T10:53:00"),
                        HomeImg = "eu_32.png",
                        AwayImg = "eu_8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011404,
                        LeagueId = 20700663,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Polônia",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:50:00"),
                        HomeImg = "32.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011400,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Suíça",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:47:00"),
                        HomeImg = "14.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011395,
                        LeagueId = 20700663,
                        HomeTeam = "Itália",
                        AwayTeam = "Eslováquia",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T10:44:00"),
                        HomeImg = "2.png",
                        AwayImg = "eu_6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011391,
                        LeagueId = 20700663,
                        HomeTeam = "Macedônia do Norte",
                        AwayTeam = "Portugal",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:41:00"),
                        HomeImg = "eu_9.png",
                        AwayImg = "28.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011386,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "Escócia",
                        SumScore = 7,
                        FinalTimeResult = "5+-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T10:38:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "eu_17.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011382,
                        LeagueId = 20700663,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Hungria",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:35:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011378,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "República Tcheca",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:32:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "eu_12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011374,
                        LeagueId = 20700663,
                        HomeTeam = "Áustria",
                        AwayTeam = "França",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:29:00"),
                        HomeImg = "eu_11.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011369,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Alemanha",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T10:26:00"),
                        HomeImg = "14.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011365,
                        LeagueId = 20700663,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Polônia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:23:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011361,
                        LeagueId = 20700663,
                        HomeTeam = "República Tcheca",
                        AwayTeam = "Eslováquia",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T10:20:00"),
                        HomeImg = "eu_12.png",
                        AwayImg = "eu_6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011357,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Suécia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T10:17:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "eu_31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011353,
                        LeagueId = 20700663,
                        HomeTeam = "Portugal",
                        AwayTeam = "Macedônia do Norte",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T10:14:00"),
                        HomeImg = "28.png",
                        AwayImg = "eu_9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011349,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "Países Baixos",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T10:11:00"),
                        HomeImg = "12.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011345,
                        LeagueId = 20700663,
                        HomeTeam = "Polônia",
                        AwayTeam = "Rússia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T10:08:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011341,
                        LeagueId = 20700663,
                        HomeTeam = "Finlândia",
                        AwayTeam = "Áustria",
                        SumScore = 7,
                        FinalTimeResult = "4-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T10:05:00"),
                        HomeImg = "eu_32.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011337,
                        LeagueId = 20700663,
                        HomeTeam = "Macedônia do Norte",
                        AwayTeam = "Rússia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:02:00"),
                        HomeImg = "eu_9.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011333,
                        LeagueId = 20700663,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Suíça",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:59:00"),
                        HomeImg = "9.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011329,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "Itália",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T09:56:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "2.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011325,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "Macedônia do Norte",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T09:53:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "eu_9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011321,
                        LeagueId = 20700663,
                        HomeTeam = "Áustria",
                        AwayTeam = "Portugal",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T09:50:00"),
                        HomeImg = "eu_11.png",
                        AwayImg = "28.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011317,
                        LeagueId = 20700663,
                        HomeTeam = "Macedônia do Norte",
                        AwayTeam = "Inglaterra",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T09:47:00"),
                        HomeImg = "eu_9.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011313,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "País de Gales",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:44:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011309,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "Suécia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T09:41:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "eu_31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011305,
                        LeagueId = 20700663,
                        HomeTeam = "República Tcheca",
                        AwayTeam = "Bélgica",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T09:38:00"),
                        HomeImg = "eu_12.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011301,
                        LeagueId = 20700663,
                        HomeTeam = "Itália",
                        AwayTeam = "Países Baixos",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T09:35:00"),
                        HomeImg = "2.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011297,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Rússia",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:32:00"),
                        HomeImg = "14.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011292,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "França",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T09:29:00"),
                        HomeImg = "12.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011288,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "Bélgica",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T09:26:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011284,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Suíça",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T09:23:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011280,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "Macedônia do Norte",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:20:00"),
                        HomeImg = "4.png",
                        AwayImg = "eu_9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011276,
                        LeagueId = 20700663,
                        HomeTeam = "Croácia",
                        AwayTeam = "França",
                        SumScore = 5,
                        FinalTimeResult = "4-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T09:17:00"),
                        HomeImg = "18.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011272,
                        LeagueId = 20700663,
                        HomeTeam = "Hungria",
                        AwayTeam = "Rússia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T09:14:00"),
                        HomeImg = "eu_34.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011267,
                        LeagueId = 20700663,
                        HomeTeam = "Eslováquia",
                        AwayTeam = "Inglaterra",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T09:11:00"),
                        HomeImg = "eu_6.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011264,
                        LeagueId = 20700663,
                        HomeTeam = "Ucrânia",
                        AwayTeam = "Portugal",
                        SumScore = 6,
                        FinalTimeResult = "3-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T09:08:00"),
                        HomeImg = "eu_8.png",
                        AwayImg = "28.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011260,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Áustria",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T09:05:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011255,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "Rússia",
                        SumScore = 5,
                        FinalTimeResult = "1-4",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T09:02:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011251,
                        LeagueId = 20700663,
                        HomeTeam = "Hungria",
                        AwayTeam = "Turquia",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:59:00"),
                        HomeImg = "eu_34.png",
                        AwayImg = "eu_21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011246,
                        LeagueId = 20700663,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Finlândia",
                        SumScore = 6,
                        FinalTimeResult = "3-3",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T08:56:00"),
                        HomeImg = "9.png",
                        AwayImg = "eu_32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011242,
                        LeagueId = 20700663,
                        HomeTeam = "França",
                        AwayTeam = "Turquia",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:53:00"),
                        HomeImg = "31.png",
                        AwayImg = "eu_21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011237,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Finlândia",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T08:50:00"),
                        HomeImg = "14.png",
                        AwayImg = "eu_32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011233,
                        LeagueId = 20700663,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Áustria",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T08:47:00"),
                        HomeImg = "9.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011229,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "Polônia",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:44:00"),
                        HomeImg = "12.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011225,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "Países Baixos",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T08:41:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011221,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "Polônia",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T08:38:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011217,
                        LeagueId = 20700663,
                        HomeTeam = "República Tcheca",
                        AwayTeam = "Portugal",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:35:00"),
                        HomeImg = "eu_12.png",
                        AwayImg = "28.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011213,
                        LeagueId = 20700663,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Dinamarca",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:32:00"),
                        HomeImg = "32.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011209,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Áustria",
                        SumScore = 5,
                        FinalTimeResult = "4-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:29:00"),
                        HomeImg = "14.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011204,
                        LeagueId = 20700663,
                        HomeTeam = "Rússia",
                        AwayTeam = "França",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T08:26:00"),
                        HomeImg = "5.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011200,
                        LeagueId = 20700663,
                        HomeTeam = "Eslováquia",
                        AwayTeam = "Alemanha",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:23:00"),
                        HomeImg = "eu_6.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011196,
                        LeagueId = 20700663,
                        HomeTeam = "Finlândia",
                        AwayTeam = "Suíça",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T08:20:00"),
                        HomeImg = "eu_32.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011191,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "Ucrânia",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T08:17:00"),
                        HomeImg = "4.png",
                        AwayImg = "eu_8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011187,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "Macedônia do Norte",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:14:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "eu_9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011184,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "Dinamarca",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T08:11:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011180,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Bélgica",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:08:00"),
                        HomeImg = "14.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011175,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "Hungria",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T08:05:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011171,
                        LeagueId = 20700663,
                        HomeTeam = "Eslováquia",
                        AwayTeam = "Itália",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T08:02:00"),
                        HomeImg = "eu_6.png",
                        AwayImg = "2.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011167,
                        LeagueId = 20700663,
                        HomeTeam = "Áustria",
                        AwayTeam = "Suíça",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T07:59:00"),
                        HomeImg = "eu_11.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011163,
                        LeagueId = 20700663,
                        HomeTeam = "Finlândia",
                        AwayTeam = "Rússia",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:56:00"),
                        HomeImg = "eu_32.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011159,
                        LeagueId = 20700663,
                        HomeTeam = "Áustria",
                        AwayTeam = "Polônia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:53:00"),
                        HomeImg = "eu_11.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011155,
                        LeagueId = 20700663,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Escócia",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T07:50:00"),
                        HomeImg = "9.png",
                        AwayImg = "eu_17.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011151,
                        LeagueId = 20700663,
                        HomeTeam = "Eslováquia",
                        AwayTeam = "Bélgica",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:47:00"),
                        HomeImg = "eu_6.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011147,
                        LeagueId = 20700663,
                        HomeTeam = "Rússia",
                        AwayTeam = "Suécia",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T07:44:00"),
                        HomeImg = "5.png",
                        AwayImg = "eu_31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011143,
                        LeagueId = 20700663,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Hungria",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T07:41:00"),
                        HomeImg = "32.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011139,
                        LeagueId = 20700663,
                        HomeTeam = "Itália",
                        AwayTeam = "Suíça",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T07:38:00"),
                        HomeImg = "2.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011134,
                        LeagueId = 20700663,
                        HomeTeam = "Macedônia do Norte",
                        AwayTeam = "Eslováquia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:35:00"),
                        HomeImg = "eu_9.png",
                        AwayImg = "eu_6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011129,
                        LeagueId = 20700663,
                        HomeTeam = "Hungria",
                        AwayTeam = "País de Gales",
                        SumScore = 5,
                        FinalTimeResult = "4-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T07:32:00"),
                        HomeImg = "eu_34.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011125,
                        LeagueId = 20700663,
                        HomeTeam = "Rússia",
                        AwayTeam = "Países Baixos",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T07:29:00"),
                        HomeImg = "5.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011121,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "Portugal",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:26:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "28.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011117,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Finlândia",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T07:23:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "eu_32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011113,
                        LeagueId = 20700663,
                        HomeTeam = "Macedônia do Norte",
                        AwayTeam = "Hungria",
                        SumScore = 5,
                        FinalTimeResult = "5+-0",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T07:20:00"),
                        HomeImg = "eu_9.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011109,
                        LeagueId = 20700663,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Áustria",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T07:17:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011105,
                        LeagueId = 20700663,
                        HomeTeam = "Croácia",
                        AwayTeam = "País de Gales",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:14:00"),
                        HomeImg = "18.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011101,
                        LeagueId = 20700663,
                        HomeTeam = "Ucrânia",
                        AwayTeam = "Inglaterra",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:11:00"),
                        HomeImg = "eu_8.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011097,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "Hungria",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T07:08:00"),
                        HomeImg = "12.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011093,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Macedônia do Norte",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T07:05:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "eu_9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011089,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "Finlândia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:02:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "eu_32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011085,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "Portugal",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T06:59:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "28.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011081,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "Alemanha",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:56:00"),
                        HomeImg = "12.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011077,
                        LeagueId = 20700663,
                        HomeTeam = "Croácia",
                        AwayTeam = "Áustria",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T06:53:00"),
                        HomeImg = "18.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011073,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "Países Baixos",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T06:50:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011068,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "Rússia",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:47:00"),
                        HomeImg = "12.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011064,
                        LeagueId = 20700663,
                        HomeTeam = "Macedônia do Norte",
                        AwayTeam = "República Tcheca",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T06:44:00"),
                        HomeImg = "eu_9.png",
                        AwayImg = "eu_12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011060,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Itália",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:41:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "2.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011056,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Croácia",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T06:38:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011051,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "França",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:35:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011047,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "Suíça",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T06:32:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011043,
                        LeagueId = 20700663,
                        HomeTeam = "Rússia",
                        AwayTeam = "Itália",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T06:29:00"),
                        HomeImg = "5.png",
                        AwayImg = "2.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011039,
                        LeagueId = 20700663,
                        HomeTeam = "França",
                        AwayTeam = "Polônia",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:26:00"),
                        HomeImg = "31.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011035,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Ucrânia",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:23:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "eu_8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011031,
                        LeagueId = 20700663,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Dinamarca",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:20:00"),
                        HomeImg = "9.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011027,
                        LeagueId = 20700663,
                        HomeTeam = "França",
                        AwayTeam = "Itália",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:17:00"),
                        HomeImg = "31.png",
                        AwayImg = "2.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011023,
                        LeagueId = 20700663,
                        HomeTeam = "Finlândia",
                        AwayTeam = "Espanha",
                        SumScore = 6,
                        FinalTimeResult = "3-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T06:14:00"),
                        HomeImg = "eu_32.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011019,
                        LeagueId = 20700663,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Bélgica",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:11:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011015,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "Suécia",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T06:08:00"),
                        HomeImg = "4.png",
                        AwayImg = "eu_31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011010,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Macedônia do Norte",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T06:05:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "eu_9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011006,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Ucrânia",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:02:00"),
                        HomeImg = "14.png",
                        AwayImg = "eu_8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011002,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "Áustria",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:59:00"),
                        HomeImg = "4.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010998,
                        LeagueId = 20700663,
                        HomeTeam = "Itália",
                        AwayTeam = "República Tcheca",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:56:00"),
                        HomeImg = "2.png",
                        AwayImg = "eu_12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010994,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "Áustria",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:53:00"),
                        HomeImg = "12.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010990,
                        LeagueId = 20700663,
                        HomeTeam = "Macedônia do Norte",
                        AwayTeam = "Turquia",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:50:00"),
                        HomeImg = "eu_9.png",
                        AwayImg = "eu_21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010986,
                        LeagueId = 20700663,
                        HomeTeam = "Áustria",
                        AwayTeam = "Rússia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T05:47:00"),
                        HomeImg = "eu_11.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010982,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "Países Baixos",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T05:44:00"),
                        HomeImg = "4.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010977,
                        LeagueId = 20700663,
                        HomeTeam = "Macedônia do Norte",
                        AwayTeam = "Áustria",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:41:00"),
                        HomeImg = "eu_9.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010973,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "Eslováquia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:38:00"),
                        HomeImg = "4.png",
                        AwayImg = "eu_6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010969,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "Croácia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T05:35:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010965,
                        LeagueId = 20700663,
                        HomeTeam = "Portugal",
                        AwayTeam = "Hungria",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:32:00"),
                        HomeImg = "28.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010961,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "País de Gales",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T05:29:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010957,
                        LeagueId = 20700663,
                        HomeTeam = "Portugal",
                        AwayTeam = "Espanha",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:26:00"),
                        HomeImg = "28.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010952,
                        LeagueId = 20700663,
                        HomeTeam = "Macedônia do Norte",
                        AwayTeam = "Finlândia",
                        SumScore = 8,
                        FinalTimeResult = "4-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T05:23:00"),
                        HomeImg = "eu_9.png",
                        AwayImg = "eu_32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010946,
                        LeagueId = 20700663,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Ucrânia",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T05:20:00"),
                        HomeImg = "32.png",
                        AwayImg = "eu_8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010942,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "Itália",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:17:00"),
                        HomeImg = "12.png",
                        AwayImg = "2.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010938,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "Áustria",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:14:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010933,
                        LeagueId = 20700663,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Polônia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T05:11:00"),
                        HomeImg = "9.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010929,
                        LeagueId = 20700663,
                        HomeTeam = "Ucrânia",
                        AwayTeam = "Itália",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:08:00"),
                        HomeImg = "eu_8.png",
                        AwayImg = "2.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010925,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Espanha",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T05:05:00"),
                        HomeImg = "14.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010921,
                        LeagueId = 20700663,
                        HomeTeam = "Áustria",
                        AwayTeam = "Ucrânia",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:02:00"),
                        HomeImg = "eu_11.png",
                        AwayImg = "eu_8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010917,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Turquia",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:59:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "eu_21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010912,
                        LeagueId = 20700663,
                        HomeTeam = "Áustria",
                        AwayTeam = "Hungria",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T04:56:00"),
                        HomeImg = "eu_11.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010907,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Espanha",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T04:53:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010903,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "Escócia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T04:50:00"),
                        HomeImg = "12.png",
                        AwayImg = "eu_17.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010899,
                        LeagueId = 20700663,
                        HomeTeam = "Hungria",
                        AwayTeam = "Países Baixos",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:47:00"),
                        HomeImg = "eu_34.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010895,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "Rússia",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:44:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010891,
                        LeagueId = 20700663,
                        HomeTeam = "Croácia",
                        AwayTeam = "Bélgica",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:41:00"),
                        HomeImg = "18.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010887,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Hungria",
                        SumScore = 6,
                        FinalTimeResult = "4-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T04:38:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010883,
                        LeagueId = 20700663,
                        HomeTeam = "Croácia",
                        AwayTeam = "Eslováquia",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T04:35:00"),
                        HomeImg = "18.png",
                        AwayImg = "eu_6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010879,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "Polônia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:32:00"),
                        HomeImg = "4.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010875,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Escócia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:29:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "eu_17.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010871,
                        LeagueId = 20700663,
                        HomeTeam = "Croácia",
                        AwayTeam = "Turquia",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:26:00"),
                        HomeImg = "18.png",
                        AwayImg = "eu_21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010867,
                        LeagueId = 20700663,
                        HomeTeam = "França",
                        AwayTeam = "Dinamarca",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T04:23:00"),
                        HomeImg = "31.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010863,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "Rússia",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T04:20:00"),
                        HomeImg = "4.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010859,
                        LeagueId = 20700663,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Dinamarca",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:17:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010855,
                        LeagueId = 20700663,
                        HomeTeam = "Finlândia",
                        AwayTeam = "Polônia",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T04:14:00"),
                        HomeImg = "eu_32.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010851,
                        LeagueId = 20700663,
                        HomeTeam = "França",
                        AwayTeam = "Suíça",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:11:00"),
                        HomeImg = "31.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010847,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Suécia",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T04:08:00"),
                        HomeImg = "14.png",
                        AwayImg = "eu_31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010843,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "País de Gales",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T04:05:00"),
                        HomeImg = "4.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010839,
                        LeagueId = 20700663,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Rússia",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T04:02:00"),
                        HomeImg = "9.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010835,
                        LeagueId = 20700663,
                        HomeTeam = "França",
                        AwayTeam = "Hungria",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:59:00"),
                        HomeImg = "31.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010831,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Itália",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:56:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "2.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010827,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "República Tcheca",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T03:53:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "eu_12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010823,
                        LeagueId = 20700663,
                        HomeTeam = "Finlândia",
                        AwayTeam = "Eslováquia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T03:50:00"),
                        HomeImg = "eu_32.png",
                        AwayImg = "eu_6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010819,
                        LeagueId = 20700663,
                        HomeTeam = "Polônia",
                        AwayTeam = "França",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:47:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010815,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "Bélgica",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T03:44:00"),
                        HomeImg = "12.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010810,
                        LeagueId = 20700663,
                        HomeTeam = "Ucrânia",
                        AwayTeam = "Macedônia do Norte",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:41:00"),
                        HomeImg = "eu_8.png",
                        AwayImg = "eu_9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010806,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "Bélgica",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:38:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010802,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Inglaterra",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:35:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010798,
                        LeagueId = 20700663,
                        HomeTeam = "República Tcheca",
                        AwayTeam = "Ucrânia",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:32:00"),
                        HomeImg = "eu_12.png",
                        AwayImg = "eu_8.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010794,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "Bélgica",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T03:29:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010790,
                        LeagueId = 20700663,
                        HomeTeam = "Hungria",
                        AwayTeam = "Suíça",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:26:00"),
                        HomeImg = "eu_34.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010786,
                        LeagueId = 20700663,
                        HomeTeam = "Croácia",
                        AwayTeam = "Alemanha",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:23:00"),
                        HomeImg = "18.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010781,
                        LeagueId = 20700663,
                        HomeTeam = "Portugal",
                        AwayTeam = "Suíça",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T03:20:00"),
                        HomeImg = "28.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010777,
                        LeagueId = 20700663,
                        HomeTeam = "Rússia",
                        AwayTeam = "Dinamarca",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:17:00"),
                        HomeImg = "5.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010772,
                        LeagueId = 20700663,
                        HomeTeam = "Ucrânia",
                        AwayTeam = "Alemanha",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:14:00"),
                        HomeImg = "eu_8.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010768,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Eslováquia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:11:00"),
                        HomeImg = "14.png",
                        AwayImg = "eu_6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010764,
                        LeagueId = 20700663,
                        HomeTeam = "Itália",
                        AwayTeam = "França",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:08:00"),
                        HomeImg = "2.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010760,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "Polônia",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T03:05:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010756,
                        LeagueId = 20700663,
                        HomeTeam = "Portugal",
                        AwayTeam = "Dinamarca",
                        SumScore = 5,
                        FinalTimeResult = "4-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T03:02:00"),
                        HomeImg = "28.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010752,
                        LeagueId = 20700663,
                        HomeTeam = "República Tcheca",
                        AwayTeam = "Alemanha",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T02:59:00"),
                        HomeImg = "eu_12.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010747,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "Turquia",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:56:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "eu_21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010742,
                        LeagueId = 20700663,
                        HomeTeam = "Macedônia do Norte",
                        AwayTeam = "Croácia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:53:00"),
                        HomeImg = "eu_9.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010738,
                        LeagueId = 20700663,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Eslováquia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:50:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "eu_6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010734,
                        LeagueId = 20700663,
                        HomeTeam = "Polônia",
                        AwayTeam = "Bélgica",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T02:47:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010730,
                        LeagueId = 20700663,
                        HomeTeam = "Hungria",
                        AwayTeam = "Alemanha",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:44:00"),
                        HomeImg = "eu_34.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010725,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Portugal",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:41:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "28.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010720,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "França",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:38:00"),
                        HomeImg = "4.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010716,
                        LeagueId = 20700663,
                        HomeTeam = "Escócia",
                        AwayTeam = "Rússia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:35:00"),
                        HomeImg = "eu_17.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010712,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "Dinamarca",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T02:32:00"),
                        HomeImg = "4.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010708,
                        LeagueId = 20700663,
                        HomeTeam = "Áustria",
                        AwayTeam = "Finlândia",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T02:29:00"),
                        HomeImg = "eu_11.png",
                        AwayImg = "eu_32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010704,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "França",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:26:00"),
                        HomeImg = "12.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010700,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "Espanha",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:23:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "4.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010696,
                        LeagueId = 20700663,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Turquia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T02:20:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "eu_21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010692,
                        LeagueId = 20700663,
                        HomeTeam = "Rússia",
                        AwayTeam = "Bélgica",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:17:00"),
                        HomeImg = "5.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010687,
                        LeagueId = 20700663,
                        HomeTeam = "República Tcheca",
                        AwayTeam = "Turquia",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:14:00"),
                        HomeImg = "eu_12.png",
                        AwayImg = "eu_21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010682,
                        LeagueId = 20700663,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Eslováquia",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:11:00"),
                        HomeImg = "9.png",
                        AwayImg = "eu_6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010678,
                        LeagueId = 20700663,
                        HomeTeam = "Países Baixos",
                        AwayTeam = "Suíça",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:08:00"),
                        HomeImg = "eu_37.png",
                        AwayImg = "12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010674,
                        LeagueId = 20700663,
                        HomeTeam = "Ucrânia",
                        AwayTeam = "Dinamarca",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T02:05:00"),
                        HomeImg = "eu_8.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010670,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Finlândia",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:02:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "eu_32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010666,
                        LeagueId = 20700663,
                        HomeTeam = "França",
                        AwayTeam = "Portugal",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:59:00"),
                        HomeImg = "31.png",
                        AwayImg = "28.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010662,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "República Tcheca",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T01:56:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "eu_12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010658,
                        LeagueId = 20700663,
                        HomeTeam = "Itália",
                        AwayTeam = "Croácia",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T01:53:00"),
                        HomeImg = "2.png",
                        AwayImg = "18.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010654,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "Turquia",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T01:50:00"),
                        HomeImg = "12.png",
                        AwayImg = "eu_21.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010649,
                        LeagueId = 20700663,
                        HomeTeam = "Áustria",
                        AwayTeam = "Inglaterra",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T01:47:00"),
                        HomeImg = "eu_11.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010645,
                        LeagueId = 20700663,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Macedônia do Norte",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:44:00"),
                        HomeImg = "9.png",
                        AwayImg = "eu_9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010641,
                        LeagueId = 20700663,
                        HomeTeam = "Itália",
                        AwayTeam = "Escócia",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:41:00"),
                        HomeImg = "2.png",
                        AwayImg = "eu_17.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010637,
                        LeagueId = 20700663,
                        HomeTeam = "Bélgica",
                        AwayTeam = "República Tcheca",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:38:00"),
                        HomeImg = "32.png",
                        AwayImg = "eu_12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010633,
                        LeagueId = 20700663,
                        HomeTeam = "Eslováquia",
                        AwayTeam = "Rússia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:35:00"),
                        HomeImg = "eu_6.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010629,
                        LeagueId = 20700663,
                        HomeTeam = "Macedônia do Norte",
                        AwayTeam = "Inglaterra",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T01:32:00"),
                        HomeImg = "eu_9.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010625,
                        LeagueId = 20700663,
                        HomeTeam = "Bélgica",
                        AwayTeam = "País de Gales",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T01:29:00"),
                        HomeImg = "32.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010620,
                        LeagueId = 20700663,
                        HomeTeam = "República Tcheca",
                        AwayTeam = "Escócia",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T01:26:00"),
                        HomeImg = "eu_12.png",
                        AwayImg = "eu_17.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010614,
                        LeagueId = 20700663,
                        HomeTeam = "Hungria",
                        AwayTeam = "País de Gales",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:23:00"),
                        HomeImg = "eu_34.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010610,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Dinamarca",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:20:00"),
                        HomeImg = "14.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010606,
                        LeagueId = 20700663,
                        HomeTeam = "Alemanha",
                        AwayTeam = "Suécia",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:17:00"),
                        HomeImg = "9.png",
                        AwayImg = "eu_31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010601,
                        LeagueId = 20700663,
                        HomeTeam = "Portugal",
                        AwayTeam = "República Tcheca",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:14:00"),
                        HomeImg = "28.png",
                        AwayImg = "eu_12.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010595,
                        LeagueId = 20700663,
                        HomeTeam = "Croácia",
                        AwayTeam = "Suécia",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:11:00"),
                        HomeImg = "18.png",
                        AwayImg = "eu_31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010590,
                        LeagueId = 20700663,
                        HomeTeam = "Portugal",
                        AwayTeam = "Países Baixos",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T01:08:00"),
                        HomeImg = "28.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010586,
                        LeagueId = 20700663,
                        HomeTeam = "Espanha",
                        AwayTeam = "Escócia",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:05:00"),
                        HomeImg = "4.png",
                        AwayImg = "eu_17.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010582,
                        LeagueId = 20700663,
                        HomeTeam = "Croácia",
                        AwayTeam = "Dinamarca",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:02:00"),
                        HomeImg = "18.png",
                        AwayImg = "eu_23.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010578,
                        LeagueId = 20700663,
                        HomeTeam = "Hungria",
                        AwayTeam = "Polônia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T00:59:00"),
                        HomeImg = "eu_34.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010573,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Inglaterra",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:56:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "14.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010569,
                        LeagueId = 20700663,
                        HomeTeam = "República Tcheca",
                        AwayTeam = "Rússia",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:53:00"),
                        HomeImg = "eu_12.png",
                        AwayImg = "5.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010564,
                        LeagueId = 20700663,
                        HomeTeam = "País de Gales",
                        AwayTeam = "Polônia",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T00:50:00"),
                        HomeImg = "eu_24.png",
                        AwayImg = "eu_3.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010560,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "Hungria",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T00:47:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010556,
                        LeagueId = 20700663,
                        HomeTeam = "Bélgica",
                        AwayTeam = "Eslováquia",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T00:44:00"),
                        HomeImg = "32.png",
                        AwayImg = "eu_6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010552,
                        LeagueId = 20700663,
                        HomeTeam = "França",
                        AwayTeam = "País de Gales",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T00:41:00"),
                        HomeImg = "31.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010547,
                        LeagueId = 20700663,
                        HomeTeam = "República Tcheca",
                        AwayTeam = "Eslováquia",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:38:00"),
                        HomeImg = "eu_12.png",
                        AwayImg = "eu_6.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010543,
                        LeagueId = 20700663,
                        HomeTeam = "Portugal",
                        AwayTeam = "Alemanha",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:35:00"),
                        HomeImg = "28.png",
                        AwayImg = "9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010537,
                        LeagueId = 20700663,
                        HomeTeam = "Dinamarca",
                        AwayTeam = "Áustria",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:32:00"),
                        HomeImg = "eu_23.png",
                        AwayImg = "eu_11.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010532,
                        LeagueId = 20700663,
                        HomeTeam = "Itália",
                        AwayTeam = "Países Baixos",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:29:00"),
                        HomeImg = "2.png",
                        AwayImg = "eu_37.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010528,
                        LeagueId = 20700663,
                        HomeTeam = "Finlândia",
                        AwayTeam = "País de Gales",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:26:00"),
                        HomeImg = "eu_32.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010524,
                        LeagueId = 20700663,
                        HomeTeam = "Suécia",
                        AwayTeam = "França",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T00:23:00"),
                        HomeImg = "eu_31.png",
                        AwayImg = "31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010520,
                        LeagueId = 20700663,
                        HomeTeam = "Inglaterra",
                        AwayTeam = "Bélgica",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T00:20:00"),
                        HomeImg = "14.png",
                        AwayImg = "32.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010515,
                        LeagueId = 20700663,
                        HomeTeam = "Áustria",
                        AwayTeam = "Macedônia do Norte",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T00:17:00"),
                        HomeImg = "eu_11.png",
                        AwayImg = "eu_9.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010511,
                        LeagueId = 20700663,
                        HomeTeam = "Polônia",
                        AwayTeam = "País de Gales",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T00:14:00"),
                        HomeImg = "eu_3.png",
                        AwayImg = "eu_24.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010507,
                        LeagueId = 20700663,
                        HomeTeam = "Suíça",
                        AwayTeam = "Hungria",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T00:11:00"),
                        HomeImg = "12.png",
                        AwayImg = "eu_34.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010503,
                        LeagueId = 20700663,
                        HomeTeam = "Turquia",
                        AwayTeam = "Itália",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T00:08:00"),
                        HomeImg = "eu_21.png",
                        AwayImg = "2.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010499,
                        LeagueId = 20700663,
                        HomeTeam = "Ucrânia",
                        AwayTeam = "Escócia",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T00:05:00"),
                        HomeImg = "eu_8.png",
                        AwayImg = "eu_17.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010495,
                        LeagueId = 20700663,
                        HomeTeam = "República Tcheca",
                        AwayTeam = "Suécia",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:02:00"),
                        HomeImg = "eu_12.png",
                        AwayImg = "eu_31.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011683,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Itaquera",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T14:07:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011679,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "La Boca",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T14:04:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011674,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Penarol",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T14:01:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011671,
                        LeagueId = 20849528,
                        HomeTeam = "Asuncion",
                        AwayTeam = "Avellaneda",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T13:58:00"),
                        HomeImg = "Asuncion.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011666,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:55:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011660,
                        LeagueId = 20849528,
                        HomeTeam = "Bogota",
                        AwayTeam = "Guayaquil",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:52:00"),
                        HomeImg = "Bogota.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011657,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Sao Paulo",
                        SumScore = 6,
                        FinalTimeResult = "4-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T13:49:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Sao Paulo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011652,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "Santiago",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T13:46:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "Santiago.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011648,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "Santos",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:43:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011643,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Guayaquil",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:40:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011639,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Santos",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:37:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011634,
                        LeagueId = 20849528,
                        HomeTeam = "Bogota",
                        AwayTeam = "Montevideo",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T13:34:00"),
                        HomeImg = "Bogota.jpeg",
                        AwayImg = "Montevideo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011629,
                        LeagueId = 20849528,
                        HomeTeam = "Asuncion",
                        AwayTeam = "Porto Alegre",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T13:31:00"),
                        HomeImg = "Asuncion.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011626,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "Buenos Aires",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:28:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "Buenos Aires.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011622,
                        LeagueId = 20849528,
                        HomeTeam = "Penarol",
                        AwayTeam = "Asuncion",
                        SumScore = 6,
                        FinalTimeResult = "2-4",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T13:25:00"),
                        HomeImg = "Penarol.jpeg",
                        AwayImg = "Asuncion.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011618,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Avellaneda",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T13:22:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011613,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "Medellin",
                        SumScore = 6,
                        FinalTimeResult = "5+-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T13:19:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "Medellin.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011607,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Asuncion",
                        SumScore = 4,
                        FinalTimeResult = "0-4",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T13:16:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Asuncion.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011602,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "La Plata",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:13:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011598,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Asuncion",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:10:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Asuncion.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011595,
                        LeagueId = 20849528,
                        HomeTeam = "Medellin",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:07:00"),
                        HomeImg = "Medellin.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011591,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Rio de Janeiro",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:04:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Rio de Janeiro.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011585,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Santos",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:01:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011582,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Avellaneda",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T12:58:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011577,
                        LeagueId = 20849528,
                        HomeTeam = "Agua Branca",
                        AwayTeam = "Guayaquil",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:55:00"),
                        HomeImg = "Agua Branca.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011572,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Penarol",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:52:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011567,
                        LeagueId = 20849528,
                        HomeTeam = "Santiago",
                        AwayTeam = "Quito",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:49:00"),
                        HomeImg = "Santiago.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011563,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "La Boca",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T12:46:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011560,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Asuncion",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:43:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Asuncion.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011555,
                        LeagueId = 20849528,
                        HomeTeam = "Itaquera",
                        AwayTeam = "Montevideo",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T12:40:00"),
                        HomeImg = "Itaquera.jpeg",
                        AwayImg = "Montevideo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011551,
                        LeagueId = 20849528,
                        HomeTeam = "Asuncion",
                        AwayTeam = "Quito",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:37:00"),
                        HomeImg = "Asuncion.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011547,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Lima",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T12:34:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Lima.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011543,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Agua Branca",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:31:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Agua Branca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011539,
                        LeagueId = 20849528,
                        HomeTeam = "Itaquera",
                        AwayTeam = "Santos",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T12:28:00"),
                        HomeImg = "Itaquera.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011536,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "Santiago",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T12:25:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "Santiago.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011530,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Itaquera",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:22:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011525,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "La Boca",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T12:19:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011521,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Itaquera",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T12:16:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011516,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "La Boca",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T12:13:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011512,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "Santos",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T12:10:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011508,
                        LeagueId = 20849528,
                        HomeTeam = "Itaquera",
                        AwayTeam = "La Plata",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:07:00"),
                        HomeImg = "Itaquera.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011504,
                        LeagueId = 20849528,
                        HomeTeam = "Santiago",
                        AwayTeam = "Lima",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T12:04:00"),
                        HomeImg = "Santiago.jpeg",
                        AwayImg = "Lima.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011500,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T12:01:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011497,
                        LeagueId = 20849528,
                        HomeTeam = "Itaquera",
                        AwayTeam = "Buenos Aires",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T11:58:00"),
                        HomeImg = "Itaquera.jpeg",
                        AwayImg = "Buenos Aires.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011491,
                        LeagueId = 20849528,
                        HomeTeam = "Penarol",
                        AwayTeam = "Bogota",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:55:00"),
                        HomeImg = "Penarol.jpeg",
                        AwayImg = "Bogota.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011487,
                        LeagueId = 20849528,
                        HomeTeam = "Agua Branca",
                        AwayTeam = "Rio de Janeiro",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:52:00"),
                        HomeImg = "Agua Branca.jpeg",
                        AwayImg = "Rio de Janeiro.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011484,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Penarol",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:49:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011479,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:46:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011476,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "Penarol",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T11:43:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011471,
                        LeagueId = 20849528,
                        HomeTeam = "Santiago",
                        AwayTeam = "La Boca",
                        SumScore = 5,
                        FinalTimeResult = "1-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T11:40:00"),
                        HomeImg = "Santiago.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011468,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "Rio de Janeiro",
                        SumScore = 4,
                        FinalTimeResult = "0-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T11:37:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "Rio de Janeiro.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011462,
                        LeagueId = 20849528,
                        HomeTeam = "Penarol",
                        AwayTeam = "Porto Alegre",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T11:34:00"),
                        HomeImg = "Penarol.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011459,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Quito",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:31:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011455,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Lima",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:28:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Lima.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011451,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Quito",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T11:25:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011447,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "Itaquera",
                        SumScore = 4,
                        FinalTimeResult = "0-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T11:22:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011443,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Quito",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:19:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011439,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "Guayaquil",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:16:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011435,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Quito",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:13:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011430,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Itaquera",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:10:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011427,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Santos",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:07:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011423,
                        LeagueId = 20849528,
                        HomeTeam = "Medellin",
                        AwayTeam = "Penarol",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:04:00"),
                        HomeImg = "Medellin.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011419,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Lima",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T11:01:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Lima.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011415,
                        LeagueId = 20849528,
                        HomeTeam = "Penarol",
                        AwayTeam = "Buenos Aires",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T10:58:00"),
                        HomeImg = "Penarol.jpeg",
                        AwayImg = "Buenos Aires.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011410,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Agua Branca",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T10:55:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Agua Branca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011406,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Lima",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T10:52:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Lima.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011402,
                        LeagueId = 20849528,
                        HomeTeam = "Penarol",
                        AwayTeam = "Rio de Janeiro",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:49:00"),
                        HomeImg = "Penarol.jpeg",
                        AwayImg = "Rio de Janeiro.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011398,
                        LeagueId = 20849528,
                        HomeTeam = "Bogota",
                        AwayTeam = "Sao Paulo",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T10:46:00"),
                        HomeImg = "Bogota.jpeg",
                        AwayImg = "Sao Paulo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011394,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Avellaneda",
                        SumScore = 7,
                        FinalTimeResult = "4-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T10:43:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011389,
                        LeagueId = 20849528,
                        HomeTeam = "Agua Branca",
                        AwayTeam = "Medellin",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T10:40:00"),
                        HomeImg = "Agua Branca.jpeg",
                        AwayImg = "Medellin.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011384,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "Penarol",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T10:37:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011381,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "Agua Branca",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T10:34:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "Agua Branca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011377,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Bogota",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T10:31:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Bogota.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011373,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Santiago",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T10:28:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Santiago.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011367,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Guayaquil",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:25:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011363,
                        LeagueId = 20849528,
                        HomeTeam = "Medellin",
                        AwayTeam = "La Boca",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:22:00"),
                        HomeImg = "Medellin.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011360,
                        LeagueId = 20849528,
                        HomeTeam = "Agua Branca",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:19:00"),
                        HomeImg = "Agua Branca.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011356,
                        LeagueId = 20849528,
                        HomeTeam = "Santiago",
                        AwayTeam = "Santos",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T10:16:00"),
                        HomeImg = "Santiago.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011351,
                        LeagueId = 20849528,
                        HomeTeam = "Asuncion",
                        AwayTeam = "Itaquera",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T10:13:00"),
                        HomeImg = "Asuncion.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011347,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "Avellaneda",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:10:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011343,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Sao Paulo",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T10:07:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Sao Paulo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011340,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Montevideo",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:04:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Montevideo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011336,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "Medellin",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:01:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "Medellin.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011332,
                        LeagueId = 20849528,
                        HomeTeam = "Agua Branca",
                        AwayTeam = "La Boca",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T09:58:00"),
                        HomeImg = "Agua Branca.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011327,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Itaquera",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:55:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011324,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "Porto Alegre",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T09:52:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011320,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Bogota",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T09:49:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Bogota.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011316,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "Asuncion",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T09:46:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "Asuncion.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011311,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Itaquera",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T09:43:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011308,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Lima",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:40:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Lima.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011304,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "La Plata",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T09:37:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011300,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Porto Alegre",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T09:34:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011295,
                        LeagueId = 20849528,
                        HomeTeam = "Santiago",
                        AwayTeam = "La Plata",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:31:00"),
                        HomeImg = "Santiago.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011290,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Penarol",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T09:28:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011286,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "Lima",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T09:25:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "Lima.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011282,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "La Plata",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:22:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011278,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "Porto Alegre",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T09:19:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011275,
                        LeagueId = 20849528,
                        HomeTeam = "Bogota",
                        AwayTeam = "Itaquera",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:16:00"),
                        HomeImg = "Bogota.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011271,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "Asuncion",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T09:13:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "Asuncion.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011268,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "Lima",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:10:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "Lima.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011263,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "La Plata",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:07:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011259,
                        LeagueId = 20849528,
                        HomeTeam = "Asuncion",
                        AwayTeam = "Santiago",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T09:04:00"),
                        HomeImg = "Asuncion.jpeg",
                        AwayImg = "Santiago.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011253,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Santos",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T09:01:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011250,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Santiago",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:58:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Santiago.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011245,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Sao Paulo",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T08:55:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Sao Paulo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011241,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Penarol",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:52:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011235,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Avellaneda",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T08:49:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011231,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "Sao Paulo",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:46:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "Sao Paulo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011227,
                        LeagueId = 20849528,
                        HomeTeam = "Santiago",
                        AwayTeam = "Montevideo",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T08:43:00"),
                        HomeImg = "Santiago.jpeg",
                        AwayImg = "Montevideo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011224,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "Buenos Aires",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T08:40:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "Buenos Aires.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011219,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Santiago",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:37:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Santiago.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011215,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "Asuncion",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:34:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "Asuncion.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011211,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Agua Branca",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T08:31:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Agua Branca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011208,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Rio de Janeiro",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:28:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Rio de Janeiro.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011203,
                        LeagueId = 20849528,
                        HomeTeam = "Medellin",
                        AwayTeam = "Quito",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T08:25:00"),
                        HomeImg = "Medellin.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011199,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "Montevideo",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:22:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "Montevideo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011195,
                        LeagueId = 20849528,
                        HomeTeam = "Penarol",
                        AwayTeam = "Guayaquil",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:19:00"),
                        HomeImg = "Penarol.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011192,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "Bogota",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T08:16:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "Bogota.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011186,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Santos",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T08:13:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011183,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "La Plata",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:10:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011179,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "Agua Branca",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T08:07:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "Agua Branca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011174,
                        LeagueId = 20849528,
                        HomeTeam = "Penarol",
                        AwayTeam = "Itaquera",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:04:00"),
                        HomeImg = "Penarol.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011170,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "Medellin",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:01:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "Medellin.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011166,
                        LeagueId = 20849528,
                        HomeTeam = "La Boca",
                        AwayTeam = "Itaquera",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:58:00"),
                        HomeImg = "La Boca.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011162,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:55:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011157,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Penarol",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:52:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011154,
                        LeagueId = 20849528,
                        HomeTeam = "La Boca",
                        AwayTeam = "Buenos Aires",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T07:49:00"),
                        HomeImg = "La Boca.jpeg",
                        AwayImg = "Buenos Aires.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011149,
                        LeagueId = 20849528,
                        HomeTeam = "Bogota",
                        AwayTeam = "Rio de Janeiro",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:46:00"),
                        HomeImg = "Bogota.jpeg",
                        AwayImg = "Rio de Janeiro.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011145,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Montevideo",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:43:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Montevideo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011141,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "La Boca",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:40:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011137,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "Montevideo",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:37:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "Montevideo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011133,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Bogota",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:34:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Bogota.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011128,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "Penarol",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:31:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011124,
                        LeagueId = 20849528,
                        HomeTeam = "Itaquera",
                        AwayTeam = "Santiago",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T07:28:00"),
                        HomeImg = "Itaquera.jpeg",
                        AwayImg = "Santiago.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011120,
                        LeagueId = 20849528,
                        HomeTeam = "Medellin",
                        AwayTeam = "Avellaneda",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:25:00"),
                        HomeImg = "Medellin.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011115,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Penarol",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:22:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011112,
                        LeagueId = 20849528,
                        HomeTeam = "Itaquera",
                        AwayTeam = "Guayaquil",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:19:00"),
                        HomeImg = "Itaquera.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011108,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Buenos Aires",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T07:16:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Buenos Aires.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011104,
                        LeagueId = 20849528,
                        HomeTeam = "Medellin",
                        AwayTeam = "Guayaquil",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T07:13:00"),
                        HomeImg = "Medellin.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011100,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Avellaneda",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T07:10:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011096,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "La Boca",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T07:07:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011091,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Agua Branca",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:04:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Agua Branca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011087,
                        LeagueId = 20849528,
                        HomeTeam = "Bogota",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:01:00"),
                        HomeImg = "Bogota.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011084,
                        LeagueId = 20849528,
                        HomeTeam = "Medellin",
                        AwayTeam = "Santos",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:58:00"),
                        HomeImg = "Medellin.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011079,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "Itaquera",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:55:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011075,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "La Plata",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:52:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011071,
                        LeagueId = 20849528,
                        HomeTeam = "Agua Branca",
                        AwayTeam = "Asuncion",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:49:00"),
                        HomeImg = "Agua Branca.jpeg",
                        AwayImg = "Asuncion.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011066,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Lima",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:46:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Lima.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011062,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Guayaquil",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:43:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011058,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Sao Paulo",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:40:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Sao Paulo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011055,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "Avellaneda",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:37:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011049,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Sao Paulo",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T06:34:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Sao Paulo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011045,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Agua Branca",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:31:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Agua Branca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011041,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Penarol",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:28:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011037,
                        LeagueId = 20849528,
                        HomeTeam = "Asuncion",
                        AwayTeam = "Montevideo",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:25:00"),
                        HomeImg = "Asuncion.jpeg",
                        AwayImg = "Montevideo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011034,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "La Boca",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:22:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011029,
                        LeagueId = 20849528,
                        HomeTeam = "Santiago",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:19:00"),
                        HomeImg = "Santiago.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011025,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "Guayaquil",
                        SumScore = 5,
                        FinalTimeResult = "4-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T06:16:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011021,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Rio de Janeiro",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:13:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Rio de Janeiro.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011017,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "La Boca",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:10:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011014,
                        LeagueId = 20849528,
                        HomeTeam = "Penarol",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 5,
                        FinalTimeResult = "0-5+",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T06:07:00"),
                        HomeImg = "Penarol.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011008,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Medellin",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:04:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Medellin.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011004,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "La Boca",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T06:01:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011000,
                        LeagueId = 20849528,
                        HomeTeam = "Santiago",
                        AwayTeam = "Porto Alegre",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:58:00"),
                        HomeImg = "Santiago.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010997,
                        LeagueId = 20849528,
                        HomeTeam = "La Boca",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T05:55:00"),
                        HomeImg = "La Boca.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010992,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "Medellin",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T05:52:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "Medellin.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010989,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Guayaquil",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:49:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010984,
                        LeagueId = 20849528,
                        HomeTeam = "Santiago",
                        AwayTeam = "Rio de Janeiro",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T05:46:00"),
                        HomeImg = "Santiago.jpeg",
                        AwayImg = "Rio de Janeiro.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010981,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Sao Paulo",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T05:43:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Sao Paulo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010975,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Medellin",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T05:40:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Medellin.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010971,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:37:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010968,
                        LeagueId = 20849528,
                        HomeTeam = "Bogota",
                        AwayTeam = "Penarol",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T05:34:00"),
                        HomeImg = "Bogota.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010963,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Asuncion",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T05:31:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Asuncion.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010960,
                        LeagueId = 20849528,
                        HomeTeam = "Santiago",
                        AwayTeam = "Lima",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T05:28:00"),
                        HomeImg = "Santiago.jpeg",
                        AwayImg = "Lima.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010956,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Sao Paulo",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T05:25:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Sao Paulo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010951,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "Avellaneda",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:22:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010945,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "Santos",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:19:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010941,
                        LeagueId = 20849528,
                        HomeTeam = "Agua Branca",
                        AwayTeam = "Avellaneda",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:16:00"),
                        HomeImg = "Agua Branca.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010936,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Itaquera",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T05:13:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010931,
                        LeagueId = 20849528,
                        HomeTeam = "Bogota",
                        AwayTeam = "Montevideo",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T05:10:00"),
                        HomeImg = "Bogota.jpeg",
                        AwayImg = "Montevideo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010928,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Sao Paulo",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:07:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Sao Paulo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010924,
                        LeagueId = 20849528,
                        HomeTeam = "La Boca",
                        AwayTeam = "Montevideo",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:04:00"),
                        HomeImg = "La Boca.jpeg",
                        AwayImg = "Montevideo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010919,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:01:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010916,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Rio de Janeiro",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:58:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Rio de Janeiro.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010911,
                        LeagueId = 20849528,
                        HomeTeam = "Agua Branca",
                        AwayTeam = "Penarol",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T04:55:00"),
                        HomeImg = "Agua Branca.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010906,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "Itaquera",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T04:52:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010901,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Agua Branca",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:49:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Agua Branca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010898,
                        LeagueId = 20849528,
                        HomeTeam = "Medellin",
                        AwayTeam = "Rio de Janeiro",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T04:46:00"),
                        HomeImg = "Medellin.jpeg",
                        AwayImg = "Rio de Janeiro.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010894,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Bogota",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T04:43:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Bogota.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010889,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "Itaquera",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:40:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010886,
                        LeagueId = 20849528,
                        HomeTeam = "Penarol",
                        AwayTeam = "La Plata",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:37:00"),
                        HomeImg = "Penarol.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010882,
                        LeagueId = 20849528,
                        HomeTeam = "Agua Branca",
                        AwayTeam = "Bogota",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:34:00"),
                        HomeImg = "Agua Branca.jpeg",
                        AwayImg = "Bogota.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010878,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "Quito",
                        SumScore = 4,
                        FinalTimeResult = "0-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T04:31:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010873,
                        LeagueId = 20849528,
                        HomeTeam = "Medellin",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:28:00"),
                        HomeImg = "Medellin.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010870,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Asuncion",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T04:25:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Asuncion.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010866,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "La Boca",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T04:22:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010862,
                        LeagueId = 20849528,
                        HomeTeam = "Asuncion",
                        AwayTeam = "Lima",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T04:19:00"),
                        HomeImg = "Asuncion.jpeg",
                        AwayImg = "Lima.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010857,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "Santos",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:16:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010854,
                        LeagueId = 20849528,
                        HomeTeam = "Asuncion",
                        AwayTeam = "Penarol",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T04:13:00"),
                        HomeImg = "Asuncion.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010850,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 6,
                        FinalTimeResult = "4-2",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T04:10:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010846,
                        LeagueId = 20849528,
                        HomeTeam = "Agua Branca",
                        AwayTeam = "Quito",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T04:07:00"),
                        HomeImg = "Agua Branca.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010842,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Montevideo",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:04:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Montevideo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010837,
                        LeagueId = 20849528,
                        HomeTeam = "Penarol",
                        AwayTeam = "Medellin",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:01:00"),
                        HomeImg = "Penarol.jpeg",
                        AwayImg = "Medellin.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010833,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "Porto Alegre",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:58:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010829,
                        LeagueId = 20849528,
                        HomeTeam = "Asuncion",
                        AwayTeam = "Guayaquil",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:55:00"),
                        HomeImg = "Asuncion.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010825,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "La Boca",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:52:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010821,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "Guayaquil",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:49:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010818,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "Medellin",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:46:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "Medellin.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010814,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "La Boca",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T03:43:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010809,
                        LeagueId = 20849528,
                        HomeTeam = "Agua Branca",
                        AwayTeam = "Itaquera",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:40:00"),
                        HomeImg = "Agua Branca.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010804,
                        LeagueId = 20849528,
                        HomeTeam = "Asuncion",
                        AwayTeam = "Rio de Janeiro",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:37:00"),
                        HomeImg = "Asuncion.jpeg",
                        AwayImg = "Rio de Janeiro.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010801,
                        LeagueId = 20849528,
                        HomeTeam = "Medellin",
                        AwayTeam = "Porto Alegre",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:34:00"),
                        HomeImg = "Medellin.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010796,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Bogota",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T03:31:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Bogota.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010792,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "La Boca",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T03:28:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010789,
                        LeagueId = 20849528,
                        HomeTeam = "Bogota",
                        AwayTeam = "Santiago",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:25:00"),
                        HomeImg = "Bogota.jpeg",
                        AwayImg = "Santiago.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010784,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Asuncion",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:22:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Asuncion.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010779,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "Quito",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:19:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010774,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "La Plata",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:16:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010771,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Avellaneda",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:13:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010767,
                        LeagueId = 20849528,
                        HomeTeam = "Asuncion",
                        AwayTeam = "Sao Paulo",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:10:00"),
                        HomeImg = "Asuncion.jpeg",
                        AwayImg = "Sao Paulo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010762,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "Bogota",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:07:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "Bogota.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010759,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T03:04:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010754,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Montevideo",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:01:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Montevideo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010750,
                        LeagueId = 20849528,
                        HomeTeam = "Bogota",
                        AwayTeam = "Asuncion",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T02:58:00"),
                        HomeImg = "Bogota.jpeg",
                        AwayImg = "Asuncion.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010745,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "Porto Alegre",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:55:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010741,
                        LeagueId = 20849528,
                        HomeTeam = "Avellaneda",
                        AwayTeam = "Buenos Aires",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T02:52:00"),
                        HomeImg = "Avellaneda.jpeg",
                        AwayImg = "Buenos Aires.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010736,
                        LeagueId = 20849528,
                        HomeTeam = "La Boca",
                        AwayTeam = "Guayaquil",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:49:00"),
                        HomeImg = "La Boca.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010732,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Santos",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T02:46:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010728,
                        LeagueId = 20849528,
                        HomeTeam = "Agua Branca",
                        AwayTeam = "Montevideo",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:43:00"),
                        HomeImg = "Agua Branca.jpeg",
                        AwayImg = "Montevideo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010722,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Itaquera",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T02:40:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010718,
                        LeagueId = 20849528,
                        HomeTeam = "Bogota",
                        AwayTeam = "La Boca",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:37:00"),
                        HomeImg = "Bogota.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010715,
                        LeagueId = 20849528,
                        HomeTeam = "Itaquera",
                        AwayTeam = "Buenos Aires",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T02:34:00"),
                        HomeImg = "Itaquera.jpeg",
                        AwayImg = "Buenos Aires.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010711,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Lima",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T02:31:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Lima.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010706,
                        LeagueId = 20849528,
                        HomeTeam = "La Boca",
                        AwayTeam = "Agua Branca",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T02:28:00"),
                        HomeImg = "La Boca.jpeg",
                        AwayImg = "Agua Branca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010703,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:25:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010699,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "Porto Alegre",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:22:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010694,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Santiago",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:19:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Santiago.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010690,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Medellin",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:16:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Medellin.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010685,
                        LeagueId = 20849528,
                        HomeTeam = "Santiago",
                        AwayTeam = "Sao Paulo",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T02:13:00"),
                        HomeImg = "Santiago.jpeg",
                        AwayImg = "Sao Paulo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010680,
                        LeagueId = 20849528,
                        HomeTeam = "Penarol",
                        AwayTeam = "Santos",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:10:00"),
                        HomeImg = "Penarol.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010677,
                        LeagueId = 20849528,
                        HomeTeam = "Itaquera",
                        AwayTeam = "Quito",
                        SumScore = 4,
                        FinalTimeResult = "0-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T02:07:00"),
                        HomeImg = "Itaquera.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010672,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "Medellin",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T02:04:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "Medellin.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010668,
                        LeagueId = 20849528,
                        HomeTeam = "La Boca",
                        AwayTeam = "Porto Alegre",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:01:00"),
                        HomeImg = "La Boca.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010665,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Santiago",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T01:58:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Santiago.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010660,
                        LeagueId = 20849528,
                        HomeTeam = "Medellin",
                        AwayTeam = "Itaquera",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:55:00"),
                        HomeImg = "Medellin.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010656,
                        LeagueId = 20849528,
                        HomeTeam = "Penarol",
                        AwayTeam = "Buenos Aires",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T01:52:00"),
                        HomeImg = "Penarol.jpeg",
                        AwayImg = "Buenos Aires.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010652,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Porto Alegre",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:49:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010647,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Rio de Janeiro",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:46:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Rio de Janeiro.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010643,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Penarol",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:43:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010639,
                        LeagueId = 20849528,
                        HomeTeam = "Itaquera",
                        AwayTeam = "Porto Alegre",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:40:00"),
                        HomeImg = "Itaquera.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010636,
                        LeagueId = 20849528,
                        HomeTeam = "Bogota",
                        AwayTeam = "La Plata",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:37:00"),
                        HomeImg = "Bogota.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010632,
                        LeagueId = 20849528,
                        HomeTeam = "Santiago",
                        AwayTeam = "Agua Branca",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:34:00"),
                        HomeImg = "Santiago.jpeg",
                        AwayImg = "Agua Branca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010627,
                        LeagueId = 20849528,
                        HomeTeam = "La Boca",
                        AwayTeam = "Santos",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T01:31:00"),
                        HomeImg = "La Boca.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010624,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "Quito",
                        SumScore = 6,
                        FinalTimeResult = "2-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T01:28:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010619,
                        LeagueId = 20849528,
                        HomeTeam = "La Plata",
                        AwayTeam = "Buenos Aires",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T01:25:00"),
                        HomeImg = "La Plata.jpeg",
                        AwayImg = "Buenos Aires.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010613,
                        LeagueId = 20849528,
                        HomeTeam = "Sao Paulo",
                        AwayTeam = "Quito",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T01:22:00"),
                        HomeImg = "Sao Paulo.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010608,
                        LeagueId = 20849528,
                        HomeTeam = "La Boca",
                        AwayTeam = "La Plata",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:19:00"),
                        HomeImg = "La Boca.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010604,
                        LeagueId = 20849528,
                        HomeTeam = "Itaquera",
                        AwayTeam = "Penarol",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:16:00"),
                        HomeImg = "Itaquera.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010599,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Santos",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:13:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Santos.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010593,
                        LeagueId = 20849528,
                        HomeTeam = "Porto Alegre",
                        AwayTeam = "Belo Horizonte",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:10:00"),
                        HomeImg = "Porto Alegre.jpeg",
                        AwayImg = "Belo Horizonte.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010589,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Bogota",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:07:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Bogota.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010584,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Santiago",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:04:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Santiago.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010581,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "Itaquera",
                        SumScore = 6,
                        FinalTimeResult = "4-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T01:01:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010575,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "Bogota",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:58:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "Bogota.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010572,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Avellaneda",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T00:55:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010567,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "La Plata",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T00:52:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010562,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Guayaquil",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T00:49:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Guayaquil.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010559,
                        LeagueId = 20849528,
                        HomeTeam = "Asuncion",
                        AwayTeam = "Agua Branca",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:46:00"),
                        HomeImg = "Asuncion.jpeg",
                        AwayImg = "Agua Branca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010554,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "Penarol",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:43:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "Penarol.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010550,
                        LeagueId = 20849528,
                        HomeTeam = "Guayaquil",
                        AwayTeam = "Buenos Aires",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:40:00"),
                        HomeImg = "Guayaquil.jpeg",
                        AwayImg = "Buenos Aires.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010545,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "Agua Branca",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T00:37:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "Agua Branca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010542,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Sao Paulo",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:34:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Sao Paulo.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010536,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Avellaneda",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T00:31:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Avellaneda.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010530,
                        LeagueId = 20849528,
                        HomeTeam = "Rio de Janeiro",
                        AwayTeam = "Porto Alegre",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:28:00"),
                        HomeImg = "Rio de Janeiro.jpeg",
                        AwayImg = "Porto Alegre.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010526,
                        LeagueId = 20849528,
                        HomeTeam = "Lima",
                        AwayTeam = "Quito",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:25:00"),
                        HomeImg = "Lima.jpeg",
                        AwayImg = "Quito.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010522,
                        LeagueId = 20849528,
                        HomeTeam = "Montevideo",
                        AwayTeam = "Itaquera",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T00:22:00"),
                        HomeImg = "Montevideo.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010517,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "La Boca",
                        SumScore = 6,
                        FinalTimeResult = "4-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T00:19:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010513,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Santiago",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:16:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Santiago.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010509,
                        LeagueId = 20849528,
                        HomeTeam = "Quito",
                        AwayTeam = "La Plata",
                        SumScore = 5,
                        FinalTimeResult = "1-4",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T00:13:00"),
                        HomeImg = "Quito.jpeg",
                        AwayImg = "La Plata.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010506,
                        LeagueId = 20849528,
                        HomeTeam = "Buenos Aires",
                        AwayTeam = "Itaquera",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T00:10:00"),
                        HomeImg = "Buenos Aires.jpeg",
                        AwayImg = "Itaquera.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010501,
                        LeagueId = 20849528,
                        HomeTeam = "Santos",
                        AwayTeam = "Rio de Janeiro",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:07:00"),
                        HomeImg = "Santos.jpeg",
                        AwayImg = "Rio de Janeiro.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010498,
                        LeagueId = 20849528,
                        HomeTeam = "Belo Horizonte",
                        AwayTeam = "Agua Branca",
                        SumScore = 5,
                        FinalTimeResult = "1-4",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T00:04:00"),
                        HomeImg = "Belo Horizonte.jpeg",
                        AwayImg = "Agua Branca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010493,
                        LeagueId = 20849528,
                        HomeTeam = "Medellin",
                        AwayTeam = "La Boca",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:01:00"),
                        HomeImg = "Medellin.jpeg",
                        AwayImg = "La Boca.jpeg"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011682,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "Leeds",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T14:06:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011677,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "United",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T14:03:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "United.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011673,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "Chelsea",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T14:00:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011668,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Leeds",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:57:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011663,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "Norwich",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:54:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011659,
                        LeagueId = 20120653,
                        HomeTeam = "Newcastle",
                        AwayTeam = "Brentford",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:51:00"),
                        HomeImg = "Newcastle.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011655,
                        LeagueId = 20120653,
                        HomeTeam = "West Ham",
                        AwayTeam = "Brighton",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T13:48:00"),
                        HomeImg = "West Ham.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011650,
                        LeagueId = 20120653,
                        HomeTeam = "Aston",
                        AwayTeam = "Watford",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:45:00"),
                        HomeImg = "Aston.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011645,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Newcastle",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T13:42:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Newcastle.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011641,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "Burnley",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T13:39:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011637,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Brentford",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:36:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011632,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "Newcastle",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:33:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "Newcastle.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011628,
                        LeagueId = 20120653,
                        HomeTeam = "Aston",
                        AwayTeam = "Chelsea",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:30:00"),
                        HomeImg = "Aston.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011624,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "Palace",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:27:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011620,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Wolverhampton",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:24:00"),
                        HomeImg = "watford.png",
                        AwayImg = "Wolverhampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011616,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "Aston",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T13:21:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011611,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "Burnley",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:18:00"),
                        HomeImg = "City.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011606,
                        LeagueId = 20120653,
                        HomeTeam = "Southampton",
                        AwayTeam = "Brighton",
                        SumScore = 4,
                        FinalTimeResult = "0-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T13:15:00"),
                        HomeImg = "Southampton.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011600,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Wolverhampton",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:12:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "Wolverhampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011597,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "United",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:09:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "United.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011593,
                        LeagueId = 20120653,
                        HomeTeam = "Aston",
                        AwayTeam = "Brentford",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T13:06:00"),
                        HomeImg = "Aston.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011588,
                        LeagueId = 20120653,
                        HomeTeam = "Newcastle",
                        AwayTeam = "Watford",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T13:03:00"),
                        HomeImg = "Newcastle.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011584,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "Everton",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T13:00:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011580,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Brighton",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T12:57:00"),
                        HomeImg = "United.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011575,
                        LeagueId = 20120653,
                        HomeTeam = "Burnley",
                        AwayTeam = "Norwich",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:54:00"),
                        HomeImg = "Burnley.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011570,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "Leeds",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:51:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011566,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Norwich",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:48:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011562,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "West Ham",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T12:45:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "West Ham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011558,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Everton",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T12:42:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011554,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "City",
                        SumScore = 4,
                        FinalTimeResult = "0-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T12:39:00"),
                        HomeImg = "United.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011550,
                        LeagueId = 20120653,
                        HomeTeam = "West Ham",
                        AwayTeam = "Southampton",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T12:36:00"),
                        HomeImg = "West Ham.png",
                        AwayImg = "Southampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011546,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "Chelsea",
                        SumScore = 6,
                        FinalTimeResult = "4-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T12:33:00"),
                        HomeImg = "City.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011542,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "Wolverhampton",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T12:30:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "Wolverhampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011538,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "Burnley",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:27:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011533,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Islington",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T12:24:00"),
                        HomeImg = "United.png",
                        AwayImg = "islingtonreds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011528,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "Burnley",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:21:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011524,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Palace",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:18:00"),
                        HomeImg = "watford.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011520,
                        LeagueId = 20120653,
                        HomeTeam = "West Ham",
                        AwayTeam = "Chelsea",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T12:15:00"),
                        HomeImg = "West Ham.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011515,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "Aston",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T12:12:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011511,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Wolverhampton",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T12:09:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "Wolverhampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011507,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "Chelsea",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T12:06:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011503,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Aston",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T12:03:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011499,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "Watford",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T12:00:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011495,
                        LeagueId = 20120653,
                        HomeTeam = "Southampton",
                        AwayTeam = "Leeds",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:57:00"),
                        HomeImg = "Southampton.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011490,
                        LeagueId = 20120653,
                        HomeTeam = "Everton",
                        AwayTeam = "Liverpool",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T11:54:00"),
                        HomeImg = "Everton.png",
                        AwayImg = "Liverpool.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011486,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "Norwich",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T11:51:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011482,
                        LeagueId = 20120653,
                        HomeTeam = "Aston",
                        AwayTeam = "City",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T11:48:00"),
                        HomeImg = "Aston.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011478,
                        LeagueId = 20120653,
                        HomeTeam = "Burnley",
                        AwayTeam = "Liverpool",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T11:45:00"),
                        HomeImg = "Burnley.png",
                        AwayImg = "Liverpool.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011474,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "United",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T11:42:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "United.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011470,
                        LeagueId = 20120653,
                        HomeTeam = "Southampton",
                        AwayTeam = "Liverpool",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:39:00"),
                        HomeImg = "Southampton.png",
                        AwayImg = "Liverpool.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011465,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "Brighton",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T11:36:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011461,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Wolverhampton",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T11:33:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Wolverhampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011457,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "Leicester",
                        SumScore = 4,
                        FinalTimeResult = "0-4",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:30:00"),
                        HomeImg = "City.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011453,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Norwich",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:27:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011449,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "Southampton",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T11:24:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "Southampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011445,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Norwich",
                        SumScore = 7,
                        FinalTimeResult = "3-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T11:21:00"),
                        HomeImg = "watford.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011441,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "Chelsea",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:18:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011437,
                        LeagueId = 20120653,
                        HomeTeam = "Brentford",
                        AwayTeam = "Burnley",
                        SumScore = 5,
                        FinalTimeResult = "1-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T11:15:00"),
                        HomeImg = "Brentford.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011433,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Leicester",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:12:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011429,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "Everton",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:09:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011425,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "Tottenham",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T11:06:00"),
                        HomeImg = "City.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011421,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "Liverpool",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:03:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "Liverpool.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011417,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Chelsea",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T11:00:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011413,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "Norwich",
                        SumScore = 6,
                        FinalTimeResult = "5+-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T10:57:00"),
                        HomeImg = "City.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011409,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "Islington",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:54:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "islingtonreds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011405,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "United",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:51:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "United.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011401,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "Newcastle",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T10:48:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "Newcastle.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011396,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "Aston",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T10:45:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011392,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "Burnley",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:42:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011387,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Tottenham",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T10:39:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011383,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Chelsea",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T10:36:00"),
                        HomeImg = "watford.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011379,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "City",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:33:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011375,
                        LeagueId = 20120653,
                        HomeTeam = "Southampton",
                        AwayTeam = "Watford",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:30:00"),
                        HomeImg = "Southampton.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011370,
                        LeagueId = 20120653,
                        HomeTeam = "Burnley",
                        AwayTeam = "Newcastle",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T10:27:00"),
                        HomeImg = "Burnley.png",
                        AwayImg = "Newcastle.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011366,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Leeds",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T10:24:00"),
                        HomeImg = "watford.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011362,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "Brighton",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:21:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011358,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "Everton",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T10:18:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011354,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Wolverhampton",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T10:15:00"),
                        HomeImg = "United.png",
                        AwayImg = "Wolverhampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011350,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "Southampton",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:12:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "Southampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011346,
                        LeagueId = 20120653,
                        HomeTeam = "Everton",
                        AwayTeam = "City",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:09:00"),
                        HomeImg = "Everton.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011342,
                        LeagueId = 20120653,
                        HomeTeam = "Southampton",
                        AwayTeam = "Aston",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T10:06:00"),
                        HomeImg = "Southampton.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011338,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Brighton",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T10:03:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011334,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Liverpool",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T10:00:00"),
                        HomeImg = "United.png",
                        AwayImg = "Liverpool.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011330,
                        LeagueId = 20120653,
                        HomeTeam = "Newcastle",
                        AwayTeam = "Chelsea",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T09:57:00"),
                        HomeImg = "Newcastle.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011326,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "Palace",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:54:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011322,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Newcastle",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T09:51:00"),
                        HomeImg = "United.png",
                        AwayImg = "Newcastle.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011318,
                        LeagueId = 20120653,
                        HomeTeam = "Burnley",
                        AwayTeam = "Islington",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:48:00"),
                        HomeImg = "Burnley.png",
                        AwayImg = "islingtonreds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011314,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Brentford",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:45:00"),
                        HomeImg = "watford.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011310,
                        LeagueId = 20120653,
                        HomeTeam = "Aston",
                        AwayTeam = "Wolverhampton",
                        SumScore = 6,
                        FinalTimeResult = "2-4",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T09:42:00"),
                        HomeImg = "Aston.png",
                        AwayImg = "Wolverhampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011306,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Brentford",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T09:39:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011302,
                        LeagueId = 20120653,
                        HomeTeam = "Southampton",
                        AwayTeam = "Tottenham",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:36:00"),
                        HomeImg = "Southampton.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011298,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "City",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:33:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011294,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Palace",
                        SumScore = 4,
                        FinalTimeResult = "4-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T09:30:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011289,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Brentford",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T09:27:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011285,
                        LeagueId = 20120653,
                        HomeTeam = "Everton",
                        AwayTeam = "West Ham",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T09:24:00"),
                        HomeImg = "Everton.png",
                        AwayImg = "West Ham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011281,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "Leicester",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T09:21:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011277,
                        LeagueId = 20120653,
                        HomeTeam = "Aston",
                        AwayTeam = "West Ham",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:18:00"),
                        HomeImg = "Aston.png",
                        AwayImg = "West Ham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011273,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Newcastle",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T09:15:00"),
                        HomeImg = "watford.png",
                        AwayImg = "Newcastle.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011269,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Tottenham",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T09:12:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011265,
                        LeagueId = 20120653,
                        HomeTeam = "Aston",
                        AwayTeam = "Liverpool",
                        SumScore = 7,
                        FinalTimeResult = "4-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T09:09:00"),
                        HomeImg = "Aston.png",
                        AwayImg = "Liverpool.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011261,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "United",
                        SumScore = 4,
                        FinalTimeResult = "4-0",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T09:06:00"),
                        HomeImg = "City.png",
                        AwayImg = "United.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011257,
                        LeagueId = 20120653,
                        HomeTeam = "West Ham",
                        AwayTeam = "Newcastle",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T09:03:00"),
                        HomeImg = "West Ham.png",
                        AwayImg = "Newcastle.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011252,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Leeds",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T09:00:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011248,
                        LeagueId = 20120653,
                        HomeTeam = "West Ham",
                        AwayTeam = "Leicester",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:57:00"),
                        HomeImg = "West Ham.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011243,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "Norwich",
                        SumScore = 4,
                        FinalTimeResult = "4-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T08:54:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011238,
                        LeagueId = 20120653,
                        HomeTeam = "West Ham",
                        AwayTeam = "Aston",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T08:51:00"),
                        HomeImg = "West Ham.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011234,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "Brighton",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T08:48:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011230,
                        LeagueId = 20120653,
                        HomeTeam = "Everton",
                        AwayTeam = "Aston",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T08:45:00"),
                        HomeImg = "Everton.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011226,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "United",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T08:42:00"),
                        HomeImg = "watford.png",
                        AwayImg = "United.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011222,
                        LeagueId = 20120653,
                        HomeTeam = "Everton",
                        AwayTeam = "Palace",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:39:00"),
                        HomeImg = "Everton.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011218,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "Leicester",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:36:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011214,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "Aston",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:33:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011210,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Islington",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:30:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "islingtonreds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011205,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Leicester",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T08:27:00"),
                        HomeImg = "United.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011201,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "Leeds",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T08:24:00"),
                        HomeImg = "City.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011197,
                        LeagueId = 20120653,
                        HomeTeam = "Everton",
                        AwayTeam = "Tottenham",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:21:00"),
                        HomeImg = "Everton.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011193,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Southampton",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:18:00"),
                        HomeImg = "watford.png",
                        AwayImg = "Southampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011189,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Brentford",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:15:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011185,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "West Ham",
                        SumScore = 5,
                        FinalTimeResult = "0-5+",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T08:12:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "West Ham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011181,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "City",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T08:09:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011176,
                        LeagueId = 20120653,
                        HomeTeam = "Newcastle",
                        AwayTeam = "Leicester",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T08:06:00"),
                        HomeImg = "Newcastle.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011172,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Palace",
                        SumScore = 4,
                        FinalTimeResult = "0-4",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T08:03:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011168,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Everton",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T08:00:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011164,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Aston",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T07:57:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011160,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Liverpool",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:54:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Liverpool.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011156,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Tottenham",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T07:51:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011152,
                        LeagueId = 20120653,
                        HomeTeam = "West Ham",
                        AwayTeam = "Palace",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:48:00"),
                        HomeImg = "West Ham.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011148,
                        LeagueId = 20120653,
                        HomeTeam = "Everton",
                        AwayTeam = "Leeds",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:45:00"),
                        HomeImg = "Everton.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011144,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "Leicester",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T07:42:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011140,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "Liverpool",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:39:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "Liverpool.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011135,
                        LeagueId = 20120653,
                        HomeTeam = "Aston",
                        AwayTeam = "Everton",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T07:36:00"),
                        HomeImg = "Aston.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011130,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Palace",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:33:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011126,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Southampton",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T07:30:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Southampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011122,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "Newcastle",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:27:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "Newcastle.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011118,
                        LeagueId = 20120653,
                        HomeTeam = "Brentford",
                        AwayTeam = "Chelsea",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T07:24:00"),
                        HomeImg = "Brentford.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011114,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "Watford",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:21:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011110,
                        LeagueId = 20120653,
                        HomeTeam = "Newcastle",
                        AwayTeam = "Burnley",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T07:18:00"),
                        HomeImg = "Newcastle.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011106,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "City",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T07:15:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011102,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "Leicester",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T07:12:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011098,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "West Ham",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:09:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "West Ham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011094,
                        LeagueId = 20120653,
                        HomeTeam = "Burnley",
                        AwayTeam = "Chelsea",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:06:00"),
                        HomeImg = "Burnley.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011090,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Tottenham",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T07:03:00"),
                        HomeImg = "watford.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011086,
                        LeagueId = 20120653,
                        HomeTeam = "Everton",
                        AwayTeam = "Wolverhampton",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T07:00:00"),
                        HomeImg = "Everton.png",
                        AwayImg = "Wolverhampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011082,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "Leeds",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:57:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011078,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Islington",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:54:00"),
                        HomeImg = "watford.png",
                        AwayImg = "islingtonreds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011074,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Aston",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T06:51:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011070,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "City",
                        SumScore = 6,
                        FinalTimeResult = "4-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T06:48:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011065,
                        LeagueId = 20120653,
                        HomeTeam = "Southampton",
                        AwayTeam = "Everton",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:45:00"),
                        HomeImg = "Southampton.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011061,
                        LeagueId = 20120653,
                        HomeTeam = "Newcastle",
                        AwayTeam = "Islington",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:42:00"),
                        HomeImg = "Newcastle.png",
                        AwayImg = "islingtonreds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011057,
                        LeagueId = 20120653,
                        HomeTeam = "Southampton",
                        AwayTeam = "Palace",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T06:39:00"),
                        HomeImg = "Southampton.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011052,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "United",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:36:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "United.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011048,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Aston",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:33:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011044,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "Newcastle",
                        SumScore = 5,
                        FinalTimeResult = "5+-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T06:30:00"),
                        HomeImg = "City.png",
                        AwayImg = "Newcastle.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011040,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Burnley",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:27:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011036,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Watford",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:24:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011032,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "City",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:21:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011028,
                        LeagueId = 20120653,
                        HomeTeam = "Aston",
                        AwayTeam = "Palace",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T06:18:00"),
                        HomeImg = "Aston.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011024,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Leeds",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:15:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011020,
                        LeagueId = 20120653,
                        HomeTeam = "Aston",
                        AwayTeam = "Watford",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T06:12:00"),
                        HomeImg = "Aston.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011016,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Islington",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:09:00"),
                        HomeImg = "United.png",
                        AwayImg = "islingtonreds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011012,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "City",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T06:06:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011007,
                        LeagueId = 20120653,
                        HomeTeam = "Brentford",
                        AwayTeam = "Leeds",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:03:00"),
                        HomeImg = "Brentford.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3011003,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "Tottenham",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T06:00:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010999,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Leicester",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:57:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010995,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "Palace",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T05:54:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010991,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Watford",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:51:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010987,
                        LeagueId = 20120653,
                        HomeTeam = "Newcastle",
                        AwayTeam = "Tottenham",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:48:00"),
                        HomeImg = "Newcastle.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010983,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Norwich",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T05:45:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010978,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Leicester",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T05:42:00"),
                        HomeImg = "watford.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010974,
                        LeagueId = 20120653,
                        HomeTeam = "Newcastle",
                        AwayTeam = "Wolverhampton",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T05:39:00"),
                        HomeImg = "Newcastle.png",
                        AwayImg = "Wolverhampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010970,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "Brentford",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:36:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010966,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Southampton",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:33:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "Southampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010962,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "Leicester",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T05:30:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010958,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Burnley",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:27:00"),
                        HomeImg = "watford.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010953,
                        LeagueId = 20120653,
                        HomeTeam = "Brentford",
                        AwayTeam = "Everton",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T05:24:00"),
                        HomeImg = "Brentford.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010948,
                        LeagueId = 20120653,
                        HomeTeam = "West Ham",
                        AwayTeam = "Chelsea",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T05:21:00"),
                        HomeImg = "West Ham.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010943,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Everton",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:18:00"),
                        HomeImg = "watford.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010939,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Burnley",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T05:15:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010935,
                        LeagueId = 20120653,
                        HomeTeam = "Aston",
                        AwayTeam = "Southampton",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T05:12:00"),
                        HomeImg = "Aston.png",
                        AwayImg = "Southampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010930,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "Palace",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T05:09:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010926,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "Leeds",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:06:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010922,
                        LeagueId = 20120653,
                        HomeTeam = "Aston",
                        AwayTeam = "Norwich",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T05:03:00"),
                        HomeImg = "Aston.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010918,
                        LeagueId = 20120653,
                        HomeTeam = "Burnley",
                        AwayTeam = "Southampton",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T05:00:00"),
                        HomeImg = "Burnley.png",
                        AwayImg = "Southampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010913,
                        LeagueId = 20120653,
                        HomeTeam = "West Ham",
                        AwayTeam = "Everton",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:57:00"),
                        HomeImg = "West Ham.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010909,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "Tottenham",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T04:54:00"),
                        HomeImg = "City.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010904,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Norwich",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T04:51:00"),
                        HomeImg = "United.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010900,
                        LeagueId = 20120653,
                        HomeTeam = "Southampton",
                        AwayTeam = "West Ham",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T04:48:00"),
                        HomeImg = "Southampton.png",
                        AwayImg = "West Ham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010896,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "Tottenham",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T04:45:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010892,
                        LeagueId = 20120653,
                        HomeTeam = "Aston",
                        AwayTeam = "Islington",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T04:42:00"),
                        HomeImg = "Aston.png",
                        AwayImg = "islingtonreds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010888,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "Watford",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T04:39:00"),
                        HomeImg = "City.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010884,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Liverpool",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T04:36:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Liverpool.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010880,
                        LeagueId = 20120653,
                        HomeTeam = "Southampton",
                        AwayTeam = "Leicester",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T04:33:00"),
                        HomeImg = "Southampton.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010876,
                        LeagueId = 20120653,
                        HomeTeam = "Everton",
                        AwayTeam = "Brentford",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T04:30:00"),
                        HomeImg = "Everton.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010872,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Brighton",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:27:00"),
                        HomeImg = "United.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010868,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "Newcastle",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T04:24:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "Newcastle.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010864,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "Watford",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:21:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010860,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "Burnley",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T04:18:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010856,
                        LeagueId = 20120653,
                        HomeTeam = "Newcastle",
                        AwayTeam = "Brentford",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:15:00"),
                        HomeImg = "Newcastle.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010852,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "United",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T04:12:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "United.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010848,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "City",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T04:09:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010844,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Liverpool",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T04:06:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "Liverpool.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010840,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Aston",
                        SumScore = 5,
                        FinalTimeResult = "4-1",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T04:03:00"),
                        HomeImg = "United.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010836,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "Leeds",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T04:00:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010832,
                        LeagueId = 20120653,
                        HomeTeam = "West Ham",
                        AwayTeam = "Brentford",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:57:00"),
                        HomeImg = "West Ham.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010828,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Wolverhampton",
                        SumScore = 6,
                        FinalTimeResult = "4-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T03:54:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Wolverhampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010824,
                        LeagueId = 20120653,
                        HomeTeam = "Everton",
                        AwayTeam = "Watford",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:51:00"),
                        HomeImg = "Everton.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010820,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Brighton",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:48:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010816,
                        LeagueId = 20120653,
                        HomeTeam = "Burnley",
                        AwayTeam = "City",
                        SumScore = 3,
                        FinalTimeResult = "0-3",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:45:00"),
                        HomeImg = "Burnley.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010812,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "Everton",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:42:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010807,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Watford",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T03:39:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010803,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Burnley",
                        SumScore = 4,
                        FinalTimeResult = "4-0",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T03:36:00"),
                        HomeImg = "United.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010799,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "Leeds",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:33:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010795,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "Brighton",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T03:30:00"),
                        HomeImg = "City.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010791,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "Wolverhampton",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:27:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "Wolverhampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010787,
                        LeagueId = 20120653,
                        HomeTeam = "Burnley",
                        AwayTeam = "Islington",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:24:00"),
                        HomeImg = "Burnley.png",
                        AwayImg = "islingtonreds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010783,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "West Ham",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:21:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "West Ham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010778,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "Brentford",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T03:18:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010773,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "Newcastle",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:15:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "Newcastle.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010769,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "Liverpool",
                        SumScore = 4,
                        FinalTimeResult = "4-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T03:12:00"),
                        HomeImg = "City.png",
                        AwayImg = "Liverpool.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010765,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Norwich",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T03:09:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010761,
                        LeagueId = 20120653,
                        HomeTeam = "Newcastle",
                        AwayTeam = "Aston",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T03:06:00"),
                        HomeImg = "Newcastle.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010757,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Everton",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T03:03:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010753,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "Wolverhampton",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T03:00:00"),
                        HomeImg = "watford.png",
                        AwayImg = "Wolverhampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010748,
                        LeagueId = 20120653,
                        HomeTeam = "Burnley",
                        AwayTeam = "Palace",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T02:57:00"),
                        HomeImg = "Burnley.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010743,
                        LeagueId = 20120653,
                        HomeTeam = "Brentford",
                        AwayTeam = "Watford",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:54:00"),
                        HomeImg = "Brentford.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010739,
                        LeagueId = 20120653,
                        HomeTeam = "Newcastle",
                        AwayTeam = "Palace",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:51:00"),
                        HomeImg = "Newcastle.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010735,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Aston",
                        SumScore = 6,
                        FinalTimeResult = "3-3",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T02:48:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010731,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "City",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:45:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010727,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Leicester",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:42:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010721,
                        LeagueId = 20120653,
                        HomeTeam = "Tottenham",
                        AwayTeam = "Watford",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T02:39:00"),
                        HomeImg = "Tottenham.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010717,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "Norwich",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T02:36:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010713,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Burnley",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:33:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010709,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "Islington",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T02:30:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "islingtonreds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010705,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "Tottenham",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:27:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010701,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Islington",
                        SumScore = 4,
                        FinalTimeResult = "1-3",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T02:24:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "islingtonreds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010697,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "City",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:21:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010693,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "Tottenham",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T02:18:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010689,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "Everton",
                        SumScore = 5,
                        FinalTimeResult = "2-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T02:15:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010684,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Brighton",
                        SumScore = 6,
                        FinalTimeResult = "3-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T02:12:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010679,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "West Ham",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:09:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "West Ham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010675,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Tottenham",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:06:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010671,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Everton",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T02:03:00"),
                        HomeImg = "United.png",
                        AwayImg = "Everton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010667,
                        LeagueId = 20120653,
                        HomeTeam = "Leeds",
                        AwayTeam = "Wolverhampton",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T02:00:00"),
                        HomeImg = "Leeds.png",
                        AwayImg = "Wolverhampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010663,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "United",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T01:57:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "United.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010659,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Chelsea",
                        SumScore = 7,
                        FinalTimeResult = "4-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T01:54:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010655,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Burnley",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:51:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010650,
                        LeagueId = 20120653,
                        HomeTeam = "Brentford",
                        AwayTeam = "Tottenham",
                        SumScore = 2,
                        FinalTimeResult = "0-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T01:48:00"),
                        HomeImg = "Brentford.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010646,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "Leicester",
                        SumScore = 6,
                        FinalTimeResult = "3-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T01:45:00"),
                        HomeImg = "City.png",
                        AwayImg = "Leicester.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010642,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "Watford",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:42:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "watford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010638,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "Burnley",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T01:39:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "Burnley.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010634,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "Brentford",
                        SumScore = 4,
                        FinalTimeResult = "3-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:36:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010630,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Chelsea",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:33:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010626,
                        LeagueId = 20120653,
                        HomeTeam = "City",
                        AwayTeam = "Aston",
                        SumScore = 5,
                        FinalTimeResult = "3-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T01:30:00"),
                        HomeImg = "City.png",
                        AwayImg = "Aston.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010621,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "Leeds",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:27:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010616,
                        LeagueId = 20120653,
                        HomeTeam = "Everton",
                        AwayTeam = "Islington",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:24:00"),
                        HomeImg = "Everton.png",
                        AwayImg = "islingtonreds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010611,
                        LeagueId = 20120653,
                        HomeTeam = "Brighton",
                        AwayTeam = "Newcastle",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T01:21:00"),
                        HomeImg = "Brighton.png",
                        AwayImg = "Newcastle.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010607,
                        LeagueId = 20120653,
                        HomeTeam = "Wolverhampton",
                        AwayTeam = "Norwich",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T01:18:00"),
                        HomeImg = "Wolverhampton.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010603,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Leeds",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:15:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010596,
                        LeagueId = 20120653,
                        HomeTeam = "Watford",
                        AwayTeam = "United",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:12:00"),
                        HomeImg = "watford.png",
                        AwayImg = "United.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010591,
                        LeagueId = 20120653,
                        HomeTeam = "Southampton",
                        AwayTeam = "Brighton",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T01:09:00"),
                        HomeImg = "Southampton.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010587,
                        LeagueId = 20120653,
                        HomeTeam = "Newcastle",
                        AwayTeam = "United",
                        SumScore = 3,
                        FinalTimeResult = "3-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T01:06:00"),
                        HomeImg = "Newcastle.png",
                        AwayImg = "United.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010583,
                        LeagueId = 20120653,
                        HomeTeam = "Everton",
                        AwayTeam = "Leeds",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T01:03:00"),
                        HomeImg = "Everton.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010579,
                        LeagueId = 20120653,
                        HomeTeam = "West Ham",
                        AwayTeam = "City",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T01:00:00"),
                        HomeImg = "West Ham.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010574,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Newcastle",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:57:00"),
                        HomeImg = "United.png",
                        AwayImg = "Newcastle.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010570,
                        LeagueId = 20120653,
                        HomeTeam = "Leicester",
                        AwayTeam = "Southampton",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:54:00"),
                        HomeImg = "Leicester.png",
                        AwayImg = "Southampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010565,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "Norwich",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:51:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "Norwich.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010561,
                        LeagueId = 20120653,
                        HomeTeam = "West Ham",
                        AwayTeam = "Palace",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-2",
                        Date = DateTime.Parse("2024-01-03T00:48:00"),
                        HomeImg = "West Ham.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010557,
                        LeagueId = 20120653,
                        HomeTeam = "United",
                        AwayTeam = "Tottenham",
                        SumScore = 3,
                        FinalTimeResult = "2-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:45:00"),
                        HomeImg = "United.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010553,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "Chelsea",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:42:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "Chelsea.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010548,
                        LeagueId = 20120653,
                        HomeTeam = "Southampton",
                        AwayTeam = "Leeds",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:39:00"),
                        HomeImg = "Southampton.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010544,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "United",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:36:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "United.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010539,
                        LeagueId = 20120653,
                        HomeTeam = "Burnley",
                        AwayTeam = "Leeds",
                        SumScore = 1,
                        FinalTimeResult = "0-1",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T00:33:00"),
                        HomeImg = "Burnley.png",
                        AwayImg = "Leeds.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010534,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Southampton",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "0-1",
                        Date = DateTime.Parse("2024-01-03T00:30:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "Southampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010529,
                        LeagueId = 20120653,
                        HomeTeam = "Burnley",
                        AwayTeam = "Brighton",
                        SumScore = 6,
                        FinalTimeResult = "3-3",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T00:27:00"),
                        HomeImg = "Burnley.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010525,
                        LeagueId = 20120653,
                        HomeTeam = "Brentford",
                        AwayTeam = "City",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T00:24:00"),
                        HomeImg = "Brentford.png",
                        AwayImg = "City.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010521,
                        LeagueId = 20120653,
                        HomeTeam = "Liverpool",
                        AwayTeam = "Brighton",
                        SumScore = 1,
                        FinalTimeResult = "1-0",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:21:00"),
                        HomeImg = "Liverpool.png",
                        AwayImg = "Brighton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010516,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Brentford",
                        SumScore = 4,
                        FinalTimeResult = "2-2",
                        HalfTimeResult = "1-1",
                        Date = DateTime.Parse("2024-01-03T00:18:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "Brentford.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010512,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Tottenham",
                        SumScore = 0,
                        FinalTimeResult = "0-0",
                        HalfTimeResult = "0-0",
                        Date = DateTime.Parse("2024-01-03T00:15:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010508,
                        LeagueId = 20120653,
                        HomeTeam = "Norwich",
                        AwayTeam = "Palace",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:12:00"),
                        HomeImg = "Norwich.png",
                        AwayImg = "Palace.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010504,
                        LeagueId = 20120653,
                        HomeTeam = "Islington",
                        AwayTeam = "Southampton",
                        SumScore = 5,
                        FinalTimeResult = "4-1",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T00:09:00"),
                        HomeImg = "islingtonreds.png",
                        AwayImg = "Southampton.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010500,
                        LeagueId = 20120653,
                        HomeTeam = "Palace",
                        AwayTeam = "Tottenham",
                        SumScore = 3,
                        FinalTimeResult = "1-2",
                        HalfTimeResult = "OUTROS",
                        Date = DateTime.Parse("2024-01-03T00:06:00"),
                        HomeImg = "Palace.png",
                        AwayImg = "Tottenham.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010496,
                        LeagueId = 20120653,
                        HomeTeam = "Brentford",
                        AwayTeam = "United",
                        SumScore = 2,
                        FinalTimeResult = "2-0",
                        HalfTimeResult = "2-0",
                        Date = DateTime.Parse("2024-01-03T00:03:00"),
                        HomeImg = "Brentford.png",
                        AwayImg = "United.png"
                    },
                    new FutebolVirtualGame
                    {
                        IdBet365 = 3010492,
                        LeagueId = 20120653,
                        HomeTeam = "Chelsea",
                        AwayTeam = "Newcastle",
                        SumScore = 2,
                        FinalTimeResult = "1-1",
                        HalfTimeResult = "1-0",
                        Date = DateTime.Parse("2024-01-03T00:00:00"),
                        HomeImg = "Chelsea.png",
                        AwayImg = "Newcastle.png"
                    },

                };

                await context.FutebolVirtualGames.AddRangeAsync(games);
                await context.SaveChangesAsync();
            }

        }
    }
}
