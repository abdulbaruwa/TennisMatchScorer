using System;
using System.Collections.Generic;
using TennisMatchScorer.ViewModel;

namespace TennisMatchScorer.DesignTimeData
{
    public class DummyDataBuilder
    {
        public IEnumerable<MyMatchStats> BuildMatchStatsForDesignTimeView()
        {
            var matchStats = new List<MyMatchStats>();
            matchStats.Add(DummyMatchStats1());
            matchStats.Add(DummyMatchStats2());
            matchStats.Add(DummyMatchStats3());
            matchStats.Add(DummyMatchStats2());
            matchStats.Add(DummyMatchStats1());
            return matchStats;
        }

        private static MyMatchStats DummyMatchStats1()
        {
            var playerOne = new Player() { FirstName = "Adeomola", Rating = "7.2", SurName = "Baruwa" };
            var playerTwo = new Player() { FirstName = "Kieran", Rating = "7.1", SurName = "Reed" };
            var gameOne = new Game() { AgainstScore = 7, ForScore = 5, Winner = playerTwo };
            var gameTwo = new Game() { AgainstScore = 7, ForScore = 6, Winner = playerOne };
            var gameThree = new Game() { AgainstScore = 6, ForScore = 3, Winner = playerOne };

            return new MyMatchStats()
            {
                Date = DateTime.Now,
                Duration = 99,
                PlayerOne = playerOne,
                PlayerTwo = playerTwo,
                Score = new Score() { GameOne = gameOne, GameTwo = gameTwo, GameThree = gameThree },
                TournamentName = "Sutton Clay Open",
                Won = true
            };
        }

        private static MyMatchStats DummyMatchStats2()
        {
            var playerOne = new Player() { FirstName = "Adeomola", Rating = "7.2", SurName = "Baruwa" };
            var playerTwo = new Player() { FirstName = "Adam", Rating = "7.1", SurName = "Keop" };
            var gameOne = new Game() { AgainstScore = 7, ForScore = 5, Winner = playerTwo };
            var gameTwo = new Game() { AgainstScore = 7, ForScore = 6, Winner = playerOne };
            var gameThree = new Game() { AgainstScore = 6, ForScore = 3, Winner = playerOne };

            return new MyMatchStats()
            {
                Date = DateTime.Now,
                Duration = 59,
                PlayerOne = playerOne,
                PlayerTwo = playerTwo,
                Score = new Score() { GameOne = gameOne, GameTwo = gameTwo, GameThree = gameThree },
                TournamentName = "DL Open",
                Won = true
            };

        }

        private static MyMatchStats DummyMatchStats3()
        {
            var playerOne = new Player() { FirstName = "Adeomola", Rating = "7.2", SurName = "Baruwa" };
            var playerTwo = new Player() { FirstName = "Quinton", Rating = "6.1", SurName = "Kumaressagem" };
            var gameOne = new Game() { AgainstScore = 7, ForScore = 5, Winner = playerTwo };
            var gameTwo = new Game() { AgainstScore = 7, ForScore = 6, Winner = playerOne };
            var gameThree = new Game() { AgainstScore = 6, ForScore = 2, Winner = playerTwo };

            return new MyMatchStats()
            {
                Date = DateTime.Now,
                Duration = 59,
                PlayerOne = playerOne,
                PlayerTwo = playerTwo,
                Score = new Score() { GameOne = gameOne, GameTwo = gameTwo, GameThree = gameThree },
                TournamentName = "Heston Summer Championship",
                Won = false
            };

        }
    }
}