using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using ReactiveUI;

namespace TennisMatchScorer.ViewModel
{
    [DataContract]
    public class MatchScoreViewModel : ReactiveObject
    {
        public ReactiveList<PointReason>  PointReasons { get; protected set; }

        public MatchScoreViewModel()
        {
            PointReasons = new ReactiveList<PointReason>();
        }

        //public ObservableCollection<PointReason> PointReasons
        //{
        //    get { return _pointReasons; }
        //    set { this.RaiseAndSetIfChanged(ref _pointReasons, value); }
        //}
        //PlayerOneCurrentGame

        private string _playerOneCurrentGame = "";
        public string PlayerOneCurrentGame
        {
            get { return _playerOneCurrentGame; }
            set { this.RaiseAndSetIfChanged(ref _playerOneCurrentGame, value); }
        }

        private string _playerTwoCurrentGame = "";
        public string PlayerTwoCurrentGame
        {
            get { return _playerTwoCurrentGame; }
            set { this.RaiseAndSetIfChanged(ref _playerTwoCurrentGame, value); }
        }

        private string _playerOnesName = "";
        public string PlayerOnesName
        {
            get { return _playerOnesName; }
            set { this.RaiseAndSetIfChanged(ref _playerOnesName, value); }
        }

        private string _playerTwosName = "";
        public string PlayerTwosName
        {
            get { return _playerTwosName; }
            set { this.RaiseAndSetIfChanged(ref _playerTwosName, value); }
        }

        private string _playerTwoThirdSet = "";
        public string PlayerTwoThirdSet
        {
            get { return _playerTwoThirdSet; }
            set { this.RaiseAndSetIfChanged(ref _playerTwoThirdSet, value); }
        }

        private string _playerOneThirdSet = "";
        public string PlayerOneThirdSet
        {
            get { return _playerOneThirdSet; }
            set { this.RaiseAndSetIfChanged(ref _playerOneThirdSet, value); }
        }

        private string _playerOneSecondSet = "";
        public string PlayerOneSecondSet
        {
            get { return _playerOneSecondSet; }
            set { this.RaiseAndSetIfChanged(ref _playerOneSecondSet, value); }
        }

        private string _playerTwoSecondSet = "";
        public string PlayerTwoSecondSet
        {
            get { return _playerTwoSecondSet; }
            set { this.RaiseAndSetIfChanged(ref _playerTwoSecondSet, value); }
        }


        private string _playerOneFirstSet = "";
        public string PlayerOneFirstSet
        {
            get { return _playerOneFirstSet; }
            set { this.RaiseAndSetIfChanged(ref _playerOneFirstSet, value); }
        }

        private string _playerTwoFirstSet = "";
        public string PlayerTwoFirstSet
        {
            get { return _playerTwoFirstSet; }
            set { this.RaiseAndSetIfChanged(ref _playerTwoFirstSet, value); }
        }
    }

    public class PointReason
    {
        public string Name { get; set; }
        public string Player  { get; set; }
    }


    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled) return;
        }

        public MatchScoreViewModel MatchScoreViewModel
        {
            get
            {
                var pageVm = new MatchScoreViewModel();

                for (int i = 0; i < 10; i++)
                {
                    pageVm.PointReasons.Add(new PointReason(){Name = "Action " + i, Player = "Ademola"});
                }

                pageVm.PlayerOnesName = "Ademola";
                pageVm.PlayerTwosName= "Kieran";
                pageVm.PlayerOneCurrentGame = "0";
                pageVm.PlayerTwoCurrentGame = "15";
                pageVm.PlayerOneFirstSet = "6";
                pageVm.PlayerTwoFirstSet = "4";
                return pageVm;
            }
        }
    }
}