using System.Runtime.Serialization;
using ReactiveUI;

namespace TennisMatchScorer.ViewModel
{
    [DataContract]
    public class MyMatchStatsViewModel : ReactiveObject
    {
        public MyMatchStatsViewModel()
        {
            _myMatchStats = new ReactiveList<MyMatchStats>();
        }

        private ReactiveList<MyMatchStats>  _myMatchStats;

        public ReactiveList<MyMatchStats> MyMatchStats
        {
            get { return _myMatchStats; }
            set { this.RaiseAndSetIfChanged(ref _myMatchStats, value); }
        }
    }
}