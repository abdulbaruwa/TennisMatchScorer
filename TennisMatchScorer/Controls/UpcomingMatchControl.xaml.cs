using ReactiveUI;
using TennisMatchScorer.ViewModel;
using Windows.UI.Xaml;

namespace TennisMatchScorer.Controls
{
    public sealed partial class UpcomingMatchControl : IViewFor<UpcomingMatchControlViewModel>
    {
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(UpcomingMatchControlViewModel), typeof(UpcomingMatchControl),
                                        new PropertyMetadata(null));

        public UpcomingMatchControl()
        {
            ViewModel = new UpcomingMatchControlViewModel();
            InitializeComponent();
        }

        public UpcomingMatchControlViewModel ViewModel
        {
            get { return (UpcomingMatchControlViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (UpcomingMatchControlViewModel)value; }
        }
    }
}