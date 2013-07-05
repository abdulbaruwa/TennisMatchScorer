using System.Runtime.Serialization;
using System.Windows.Input;
using ReactiveUI;
namespace TennisMatchScorer.ViewModel
{
    [DataContract]
    public class HomePageViewModel : ReactiveObject
    {
        private MyMatchStatsViewModel _myMatchStatsViewModel;

        public MyMatchStatsViewModel MyMatchStatsViewModel
        {
            get { return _myMatchStatsViewModel; }
            set { this.RaiseAndSetIfChanged(ref _myMatchStatsViewModel, value); }
        }

        private UpcomingMatchesControlViewModel _upcomingMatchesControlViewModel;
        public UpcomingMatchesControlViewModel UpcomingMatchesControlViewModel
        {
            get { return _upcomingMatchesControlViewModel; }
            set { this.RaiseAndSetIfChanged(ref _upcomingMatchesControlViewModel, value); }
        }

        private Player _defaultPlayer;
        public Player DefaultPlayer
        {
            get { return _defaultPlayer; }
            set { this.RaiseAndSetIfChanged(ref _defaultPlayer, value); }
        }

        public ReactiveCommand AddMatch { get; protected set; }
    }

}