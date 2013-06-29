using ReactiveUI;
using TennisMatchScorer.ViewModel;
using Windows.UI.Xaml;

namespace TennisMatchScorer.Controls
{
    public sealed partial class UpcomingMatchControl : IViewFor<UpcomingMatchesControlViewModel>
    {
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(UpcomingMatchesControlViewModel), typeof(UpcomingMatchControl),
                                        new PropertyMetadata(null));

        public UpcomingMatchControl()
        {
            ViewModel = new UpcomingMatchesControlViewModel();
            InitializeComponent();
        }

        public UpcomingMatchesControlViewModel ViewModel
        {
            get { return (UpcomingMatchesControlViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (UpcomingMatchesControlViewModel)value; }
        }
    }
}