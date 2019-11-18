using System;
using System.Windows.Input;
using CheckSwing.Models;
using Xamarin.Forms;

namespace CheckSwing.ViewModels
{
    public class AboutViewModel : BaseViewModel<Info>
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}