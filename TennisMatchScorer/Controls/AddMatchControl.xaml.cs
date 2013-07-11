using ReactiveUI;
using TennisMatchScorer.ViewModel;
using Windows.UI.Xaml;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace TennisMatchScorer.Controls
{
    public sealed partial class AddMatchControl : IViewFor<NewMatchViewModel>
    {
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof (NewMatchViewModel), typeof (AddMatchControl),
                                        new PropertyMetadata(null));

        public AddMatchControl()
        {
            ViewModel = new NewMatchViewModel();
            InitializeComponent();
            this.Bind(ViewModel, x => x.FinalSetFormat, x => x.FinalSetFormat.SelectedItem);
        }

        public NewMatchViewModel ViewModel
        {
            get { return (NewMatchViewModel) GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (NewMatchViewModel) value; }
        }

    }
}