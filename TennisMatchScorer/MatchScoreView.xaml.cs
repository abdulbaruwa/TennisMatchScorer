using ReactiveUI;
using TennisMatchScorer.ViewModel;
using Windows.UI.Xaml;


namespace TennisMatchScorer
{
    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
    public sealed partial class MatchScoreView : IViewFor<MatchScoreViewModel>
    {
        public MatchScoreView()
        {
            //ViewModel = new MatchScoreViewModel();
            ViewModel =  new ViewModelLocator().MatchScoreViewModel;
            this.InitializeComponent();
            this.OneWayBind(ViewModel, x => x.PointReasons, x => x.PlayerOneCommands.ItemsSource);
            this.OneWayBind(ViewModel, x => x.PointReasons, x => x.PlayerTwoCommands.ItemsSource);
            this.Bind(ViewModel, x => x.PlayerOneCurrentGame, x => x.PlayerOneCurrentGame);
            this.Bind(ViewModel, x => x.PlayerTwoCurrentGame, x => x.PlayerTwoCurrentGame);
            this.Bind(ViewModel, x => x.PlayerOneFirstSet, x => x.PlayerOneFirstSet);
            this.Bind(ViewModel, x => x.PlayerTwoFirstSet, x => x.PlayerTwoFirstSet);
            this.Bind(ViewModel, x => x.PlayerOneSecondSet, x => x.PlayerOneSecondSet);
            this.Bind(ViewModel, x => x.PlayerTwoSecondSet, x => x.PlayerTwoSecondSet);
            this.Bind(ViewModel, x => x.PlayerOneThirdSet, x => x.PlayerOneThirdSet);
            this.Bind(ViewModel, x => x.PlayerTwoThirdSet, x => x.PlayerTwoThirdSet);
            this.Bind(ViewModel, x => x.PlayerOnesName, x => x.PlayerOnesName);
            this.Bind(ViewModel, x => x.PlayerTwosName, x => x.PlayerTwosName);
        }

        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof (MatchScoreViewModel), typeof (MatchScoreView), new PropertyMetadata(null));


        

        public MatchScoreViewModel ViewModel
        {
            get { return (MatchScoreViewModel) GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        } 

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel =(MatchScoreViewModel) value; }
        }

    }
}
