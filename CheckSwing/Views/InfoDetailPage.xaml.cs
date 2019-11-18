using System.ComponentModel;
using CheckSwing.ViewModels;
using Xamarin.Forms;

namespace CheckSwing.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class InfoDetailPage : ContentPage
    {
        InfoDetailViewModel viewModel;

        public InfoDetailPage(InfoDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}
