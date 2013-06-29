﻿using System;
using System.Collections.Generic;
using ReactiveUI;
using TennisMatchScorer.ViewModel;

namespace TennisMatchScorer.DesignTimeData
{
    public class DummyDataBuilder
    {
        public IEnumerable<MyMatchStats> BuildMatchStatsForDesignTimeView()
        {
            var matchStats = new List<MyMatchStats>();
            matchStats.Add(DummyMatchStats1(0));
            matchStats.Add(DummyMatchStats2(1));
            matchStats.Add(DummyMatchStats3(2));
            matchStats.Add(DummyMatchStats2(3));
            matchStats.Add(DummyMatchStats1(4));
            return matchStats;
        }

        private static MyMatchStats DummyMatchStats1(int index)
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
                Won = true,
                IndexWithinParentCollection = index
            };
        }

        private static MyMatchStats DummyMatchStats2(int index)
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
                Won = true,
                IndexWithinParentCollection = index
            };

        }

        private static MyMatchStats DummyMatchStats3(int index)
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
                Won = false,
                IndexWithinParentCollection = index
            };

        }

        public UpcomingMatchesControlViewModel BuildUpcomingMatchesDataForDesignView()
        {
            var playerOne = new Player() { FirstName = "Adeomola", Rating = "7.2", SurName = "Baruwa" };
            var upcomingMatch = new UpcomingMatchesControlViewModel();
            upcomingMatch.DefaultPlayer = playerOne;
            upcomingMatch.MatchFormat = new MatchFormat() {FinalSetType = 3, Sets = 3};
            upcomingMatch.StartTime =  DateTime.Now.AddHours(3.0);


            upcomingMatch.Matches = new ReactiveList<MyMatchStats>(); 
            upcomingMatch.Matches.Add(new MyMatchStats()
            {
                Date = DateTime.Now.AddHours(4.0),
                PlayerOne = playerOne,
                PlayerTwo = new Player(){FirstName = "Winston", SurName = "Willis",Rating = "6.1"},
                TournamentName = "Sutton Clay Open",
                IndexWithinParentCollection = 0
            });

            upcomingMatch.Matches.Add(new MyMatchStats()
            {
                Date = DateTime.Now.AddHours(8.0),
                PlayerOne = playerOne,
                PlayerTwo = new Player() { FirstName = "Elliot", SurName = "Chad", Rating = "5.2" },
                TournamentName = "Sutton Clay Open",
                IndexWithinParentCollection = 1
            });

            upcomingMatch.Matches.Add(new MyMatchStats()
            {
                Date = DateTime.Now.AddDays(1.0),
                PlayerOne = playerOne,
                PlayerTwo = new Player() { FirstName = "Michael", SurName = "Brownie", Rating = "5.2" },
                TournamentName = "Sutton Clay Open",
                IndexWithinParentCollection = 2
            });

            upcomingMatch.Matches.Add(new MyMatchStats()
            {
                Date = DateTime.Now.AddDays(1.0).AddHours(4.0),
                PlayerOne = playerOne,
                PlayerTwo = new Player() { FirstName = "Benjamin", SurName = "Dada", Rating = "6.2" },
                TournamentName = "Sutton Clay Open",
                IndexWithinParentCollection = 3
            });
            return upcomingMatch;
        }
    }
}