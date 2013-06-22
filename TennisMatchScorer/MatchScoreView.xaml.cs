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
            this.Bind(ViewModel, x => x.PointReasons, x => x.PlayerOneCommands.ItemsSource);
            var resultofbind = this.PlayerOneCommands.ItemsSource;

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
