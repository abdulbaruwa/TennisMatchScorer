using System;

namespace TennisMatchScorer.ViewModel
{
    public class MyMatchStats
    {
        public string TournamentName { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public bool Won { get; set; }

        public string WinLose
        {
            get { return Won ? "&#xE071" : "&#xE071;"; }
        }

        public Score Score { get; set; }

        public string MatchScore
        {
            get
            { 
                return GetGameScoreText(Score.GameOne) + " " + GetGameScoreText(Score.GameTwo) + " " + GetGameScoreText(Score.GameThree);
            }
        }

        private string GetGameScoreText(Game game)
        {
            string matchScore;
            if (Score.GameOne.Winner == this.PlayerOne)
            {
                matchScore = game.ForScore + "-" + game.AgainstScore;
            }
            else
            {
                matchScore = game.AgainstScore + "-" + game.ForScore;
            }
            return matchScore;
        }
    }
}