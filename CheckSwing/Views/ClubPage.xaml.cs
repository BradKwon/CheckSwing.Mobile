using System.ComponentModel;
using CheckSwing.Enums;
using CheckSwing.Models;
using CheckSwing.ViewModels;
using Xamarin.Forms;

namespace CheckSwing.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ClubPage : ContentPage
    {
        ClubViewModel viewModel;

        public ClubPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ClubViewModel(ClubCategoryEnum.Club);
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Club;
            if (item == null)
                return;

            await Navigation.PushAsync(new ClubDetailPage(new ClubDetailViewModel(item)));

            // Manually deselect item.
            ClubListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
