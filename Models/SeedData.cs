using Microsoft.EntityFrameworkCore;


namespace CIDM_3312_Final_Project.Pages
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlayerContext(serviceProvider.GetRequiredService<DbContextOptions<PlayerContext>>()))
            {
                if (context.Players.Any())
                {
                    return;
                }

                context.Players.AddRange(

                    new Player
                    {
                        playerID = 1,
                        firstName = "Cheyanne",
                        lastName = "Jones",
                        number = 22, 
                        position = "Right Defender",
                        GameStats = new List<GameStats> {
                            new GameStats {gameID = 1},
                            new GameStats {goals = 1},
                            new GameStats {assists = 1},
                            new GameStats {blocks = 2},
                            new GameStats {saves = 3},
                            new GameStats {takeaways = 4},
                            new GameStats {timePlayed = 15}
                        }
                    },

                    new Player
                    {
                        playerID = 2,
                        firstName = "Austin",
                        lastName ="Perez",
                        number = 11,
                        position = "Left Defender",
                        GameStats = new List<GameStats> {
                            new GameStats {gameID = 1},
                            new GameStats {goals = 2},
                            new GameStats {assists = 3},
                            new GameStats {blocks = 2},
                            new GameStats {saves = 4},
                            new GameStats {takeaways = 4},
                            new GameStats {timePlayed = 18}
                        }
                    },
                    new Player
                    {
                         playerID = 3,
                        firstName = "Gunnar",
                        lastName ="Anderson",
                        number = 23,
                        position = "Left Wing",
                        GameStats = new List<GameStats> {
                            new GameStats {gameID = 1},
                            new GameStats {goals = 0},
                            new GameStats {assists = 3},
                            new GameStats {blocks = 3},
                            new GameStats {saves = 5},
                            new GameStats {takeaways = 2},
                            new GameStats {timePlayed = 14}
                        }
                    },
                    new Player
                    {
                        playerID = 4,
                        firstName = "Cooper",
                        lastName ="Carlson",
                        number = 45,
                        position = "Right Wing",
                        GameStats = new List<GameStats> {
                            new GameStats {gameID = 1},
                            new GameStats {goals = 2},
                            new GameStats {assists = 3},
                            new GameStats {blocks = 6},
                            new GameStats {saves = 2},
                            new GameStats {takeaways = 0},
                            new GameStats {timePlayed = 10}

                        }
                    },
                    new Player
                    {
                        playerID = 5,
                        firstName = "Aries",
                        lastName ="Chrzanowski",
                        number = 2,
                        position = "Center",
                        GameStats = new List<GameStats> {
                            new GameStats {gameID = 1},
                            new GameStats {goals = 3},
                            new GameStats {assists = 3},
                            new GameStats {blocks = 6},
                            new GameStats {saves = 0},
                            new GameStats {takeaways = 3},
                            new GameStats {timePlayed = 18}
                        }
                    },
                    new Player
                    {
                        playerID = 6,
                        firstName = "Barron",
                        lastName ="Sutter",
                        number = 5,
                        position = "Goalie",
                        GameStats = new List<GameStats> {
                            new GameStats {gameID = 1},
                            new GameStats {goals = 0},
                            new GameStats {assists = 0},
                            new GameStats {blocks = 6},
                            new GameStats {saves = 15},
                            new GameStats {takeaways = 0},
                            new GameStats {timePlayed = 30}
                        }
                    },
                    new Player
                    {
                        playerID = 7,
                        firstName = "Jessie",
                        lastName ="Garcia",
                        number = 6,
                        position = "Center",
                        GameStats = new List<GameStats> {
                            new GameStats {gameID = 1},
                            new GameStats {goals = 0},
                            new GameStats {assists = 0},
                            new GameStats {blocks = 6},
                            new GameStats {saves = 3},
                            new GameStats {takeaways = 2},
                            new GameStats {timePlayed = 12}
                        }
                    },
                    new Player
                    {
                        playerID = 8,
                        firstName = "Ben",
                        lastName ="Resner",
                        number = 99,
                        position = "Right Defender",
                        GameStats = new List<GameStats> {
                            new GameStats {gameID = 1},
                            new GameStats {goals = 1},
                            new GameStats {assists = 2},
                            new GameStats {blocks = 0},
                            new GameStats {saves = 0},
                            new GameStats {takeaways = 2},
                            new GameStats {timePlayed = 15}
                        }
                    },
                    new Player
                    {
                        playerID = 9,
                        firstName = "Jaxon",
                        lastName ="Wages",
                        number = 76,
                        position = "Left Defender",
                        GameStats = new List<GameStats> {
                            new GameStats {gameID = 1},
                            new GameStats {goals = 0},
                            new GameStats {assists = 2},
                            new GameStats {blocks = 4},
                            new GameStats {saves = 0},
                            new GameStats {takeaways = 4},
                            new GameStats {timePlayed = 12}
                        }
                    },
                    new Player
                    {
                        playerID = 10,
                        firstName = "Will",
                        lastName ="Reeves",
                        number = 56,
                        position = "Left Wing",
                        GameStats = new List<GameStats> {
                            new GameStats {gameID = 1},
                            new GameStats {goals = 3},
                            new GameStats {assists = 2},
                            new GameStats {blocks = 4},
                            new GameStats {saves = 2},
                            new GameStats {takeaways = 0},
                            new GameStats {timePlayed = 16}
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}