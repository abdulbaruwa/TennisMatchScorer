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
        public bool DefaultPlayerWon { get; set; }
        public Tournament Tournament { get; set; }
        public MatchFormat MatchFormat { get; set; }
        public string DefaultPlayerWinLose
        {
            get { return DefaultPlayerWon ? "&#xE071" : "&#xE071;"; }
        }

        public Score Score { get; set; }

        public string MatchScore
        {
            get
            { 
                return GetGameScoreText(Score.GameOne) + " " + GetGameScoreText(Score.GameTwo) + " " + GetGameScoreText(Score.GameThree);
            }
        }


        public int IndexWithinParentCollection { get; set; }

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