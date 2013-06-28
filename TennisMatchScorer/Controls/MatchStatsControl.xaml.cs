using ReactiveUI;
using TennisMatchScorer.ViewModel;
using Windows.UI.Xaml;

namespace TennisMatchScorer.Controls
{
    public sealed partial class MatchStatsControl : IViewFor<MyMatchStatsViewModel>
    {
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(MyMatchStatsViewModel), typeof(MatchStatsControl),
                                        new PropertyMetadata(null));

        public MatchStatsControl()
        {
            ViewModel = new MyMatchStatsViewModel();
            InitializeComponent();
        }

        public MyMatchStatsViewModel ViewModel
        {
            get { return (MyMatchStatsViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (MyMatchStatsViewModel)value; }
        }
    }
}