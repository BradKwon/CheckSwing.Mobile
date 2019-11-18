using System;
using System.Collections.Generic;
using System.ComponentModel;
using CheckSwing.Models;
using CheckSwing.ViewModels;
using Xamarin.Forms;

namespace CheckSwing.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class InfoPage : ContentPage
    {
        InfosViewModel viewModel;

        public InfoPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new InfosViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Info;
            if (item == null)
                return;

            await Navigation.PushAsync(new InfoDetailPage(new InfoDetailViewModel(item)));

            // Manually deselect item.
            InfoListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
