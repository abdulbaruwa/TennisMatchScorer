using System;
using System.Collections.Generic;
using TennisMatchScorer.ViewModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ReactiveUI;

// The Grouped Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234231

namespace TennisMatchScorer.Views
{
    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
    public sealed partial class HomePageView : IViewFor<HomePageViewModel>
    {
        public HomePageView()
        {
            ViewModel = new ViewModelLocator().HomePageViewModel;
            this.InitializeComponent();
            this.OneWayBind(ViewModel, x => x.MyMatchStatsViewModel, x => x.MatchStatsGridSection.DataContext);
            this.Bind(ViewModel, x => x.DefaultPlayer.FullName, x => x.DefaultPlayerFullName.Text);
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            // TODO: Assign a collection of bindable groups to this.DefaultViewModel["Groups"]
        }

        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register("ViewModel",
                                                                                                  typeof (HomePageViewModel),
                                                                                                  typeof (HomePageView),
                                                                                                  new PropertyMetadata(null));
        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (HomePageViewModel)value; }
        }

        public HomePageViewModel ViewModel
        {
            get { return (HomePageViewModel) GetValue(ViewModelProperty); } 
            set{SetValue(ViewModelProperty,value);}
        }

    }
}
