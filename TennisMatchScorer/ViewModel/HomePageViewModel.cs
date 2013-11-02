using System;
using System.Runtime.Serialization;
using System.Windows.Input;
using ReactiveUI;
namespace TennisMatchScorer.ViewModel
{
    [DataContract]
    public class HomePageViewModel : ReactiveObject
    {
        public HomePageViewModel()
        {
            //AddMatch Command fires only when PopUp is not currently being displayed 
            AddMatch = new ReactiveCommand(this.WhenAny(vm => vm.ShowNewMatchPopup, s => ! s.Value ));
            AddMatch.Subscribe(_ => ShowOrAddMatchPopUp());
        }

        private void ShowOrAddMatchPopUp()
        {
            ShowNewMatchPopup = true;
        }
        private void HideAddMatchPopUp()
        {
            ShowNewMatchPopup = false;
        }

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

        private bool _showNewMatchPopup ;
        public bool ShowNewMatchPopup
        {
            get { return _showNewMatchPopup; }
            set { this.RaiseAndSetIfChanged(ref _showNewMatchPopup, value); }
        }

        public ReactiveCommand AddMatch { get; protected set; }
    }

}