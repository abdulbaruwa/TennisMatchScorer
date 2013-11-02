using Windows.UI.Xaml;
// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236
using ReactiveUI;
using TennisMatchScorer.ViewModel;

namespace TennisMatchScorer.Controls
{
    public sealed partial class NewMatchControl : IViewFor<AddMatchViewModel>
    {
        public NewMatchControl()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register("ViewModel",
                                                                                                typeof(AddMatchViewModel),
                                                                                                typeof(NewMatchControl),
                                                                                                new PropertyMetadata(null));

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (AddMatchViewModel)value; }
        }

        public AddMatchViewModel ViewModel
        {
            get { return (AddMatchViewModel) GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

    }
}
