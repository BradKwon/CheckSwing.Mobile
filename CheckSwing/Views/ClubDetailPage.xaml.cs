using System.ComponentModel;
using CheckSwing.Models;
using CheckSwing.ViewModels;
using Xamarin.Forms;

namespace CheckSwing.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ClubDetailPage : ContentPage
    {
        ClubDetailViewModel viewModel;

        public ClubDetailPage(ClubDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.DetailItems.Count == 0)
                viewModel.LoadDetailItemsCommand.Execute(null);
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Event;
            if (item == null)
                return;

            await Navigation.PushAsync(new EventDetailPage(new EventDetailViewModel(item)));

            // Manually deselect item.
            ClubEventListView.SelectedItem = null;
        }
    }
}
