using TennisMatchScorer.DesignTimeData;

namespace TennisMatchScorer.ViewModel
{
    public class ViewModelLocator
    {
        private MyMatchStats _myMatchStats;
        private Player _defaultPlayer;
        public ViewModelLocator()
        {

            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled) return;
         
        }

        public MyMatchStatsViewModel MyMatchStatsViewModel
        {
            get
            {
                var statsViewModel = new MyMatchStatsViewModel();
                statsViewModel.MyMatchStats.AddRange(new DummyDataBuilder().BuildMatchStatsForDesignTimeView());
                return statsViewModel;
            }
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

        public NewMatchViewModel NewMatchViewModel
        {
            get 
            { 
                return new NewMatchViewModel();
            }
        }

        public HomePageViewModel HomePageViewModel
        {
            get
            {
                var defaultPlayer = new Player() {FirstName = "Ademola", Rating = "7.2", SurName = "Baruwa"};
                var homepageVm = new HomePageViewModel();
                homepageVm.MyMatchStatsViewModel = this.MyMatchStatsViewModel;
                homepageVm.UpcomingMatchesControlViewModel = this.UpcomingMatchesControlViewModel;
                homepageVm.DefaultPlayer = defaultPlayer;
                return homepageVm;
            }
        }

        public UpcomingMatchesControlViewModel UpcomingMatchesControlViewModel
        {
            get
            {
                return new DummyDataBuilder().BuildUpcomingMatchesDataForDesignView();
            }
        }
    }
}