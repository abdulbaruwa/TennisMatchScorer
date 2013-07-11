using System;
using System.Collections.Generic;
using ReactiveUI;

namespace TennisMatchScorer.ViewModel
{

    public class NewMatchViewModel : ReactiveObject
    {
        private static List<FinalSetFormats> _finalSet; 
        private static List<DueceFormat> _dueceFormat; 
        private static List<SetsFormat> _setsFormat;

        public List<FinalSetFormats> FinalSet
        {
           get
           {
               return _finalSet ?? (_finalSet = GetEnumAsList<FinalSetFormats>());
           } 
        }

        public List<DueceFormat> DueceFormats
        {
           get
           {
               return _dueceFormat ?? (_dueceFormat = GetEnumAsList<DueceFormat>());
           } 
        }

        public List<SetsFormat> SetsFormats
        {
           get
           {
               return _setsFormat ?? (_setsFormat = GetEnumAsList<SetsFormat>());
           } 
        }

        private FinalSetFormats _finalSetFormats;
        public FinalSetFormats FinalSetFormat
        {
            get { return _finalSetFormats; }
            set { this.RaiseAndSetIfChanged(ref _finalSetFormats, value); }
        }


        private List<T> GetEnumAsList<T>()
        {
            var enumArray = Enum.GetValues(typeof (T));
            var result = new List<T>();
            foreach (var item in enumArray)
            {
               result.Add((T)item); 
            }
            return result;
        }
    }

    public class NewMatch
    {
        public DateTime MatchTime { get; set; }
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public Tournament Tournament { get; set; }
        public MatchFormat MatchFormat { get; set; }
    }

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