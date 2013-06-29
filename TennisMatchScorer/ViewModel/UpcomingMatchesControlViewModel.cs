using System;
using System.Runtime.Serialization;
using ReactiveUI;
namespace TennisMatchScorer.ViewModel
{
    [DataContract]
    public class UpcomingMatchesControlViewModel : ReactiveObject
    {

        private Player _defaultPlayer;
        public Player DefaultPlayer
        {
            get { return _defaultPlayer; }
            set { this.RaiseAndSetIfChanged(ref _defaultPlayer, value); }
        }

        private Tournament _tournament;
        public Tournament Tournament
        {
            get { return _tournament; }
            set { this.RaiseAndSetIfChanged(ref _tournament, value); }
        }

        private DateTime _startTime;
        public DateTime StartTime { 
            get { return _startTime; }
            set { this.RaiseAndSetIfChanged(ref _startTime, value); }
        }

        private MatchFormat _matchFormat;

        public MatchFormat MatchFormat
        {
            get { return _matchFormat; }
            set { this.RaiseAndSetIfChanged(ref _matchFormat, value); }
        }

        private ReactiveList<MyMatchStats> _matches;

        public ReactiveList<MyMatchStats> Matches
        {
            get { return _matches; }
            set { this.RaiseAndSetIfChanged(ref _matches, value); }
        }

    }

    public enum FinalSetFormats
    {
        [Description("Normal")]
        Normal, 

        [Description("10 Point Championship Tie Break")]
        10PointChampionShipTieBreak
    }

    [DataContract]
    public class MatchFormat
    {
        public int Sets { get; set; }
        public int FinalSetType { get; set; }

    }

    [DataContract]
    public class Tournament
    {
        public string TournamentName { get; set;}
        public string TournamentGrade { get; set; }
        public DateTime StartDate { get; set; }
    }
}