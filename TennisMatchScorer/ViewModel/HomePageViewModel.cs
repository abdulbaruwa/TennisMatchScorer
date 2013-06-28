using System.Runtime.Serialization;
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

        private Player _defaultPlayer;
        public Player DefaultPlayer
        {
            get { return _defaultPlayer; }
            set { this.RaiseAndSetIfChanged(ref _defaultPlayer, value); }
        }
    }

}