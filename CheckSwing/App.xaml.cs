using CheckSwing.Views;
using Xamarin.Forms;

namespace CheckSwing
{
    public partial class App : Application
    {

        public App()
        {
            ModuleRegister.RegisterMockModules();
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
