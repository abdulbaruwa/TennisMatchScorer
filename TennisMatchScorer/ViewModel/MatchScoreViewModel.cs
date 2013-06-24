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

        private string _playerTwoThirdSet;
        public string PlayerTwoThirdSet
        {
            get { return _playerTwoThirdSet; }
            set { this.RaiseAndSetIfChanged(ref _playerTwoThirdSet, value); }
        }

        private string _playerOneThirdSet;
        public string PlayerOneThirdSet
        {
            get { return _playerOneThirdSet; }
            set { this.RaiseAndSetIfChanged(ref _playerOneThirdSet, value); }
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
           
                return pageVm;
            }
        }
    }
}