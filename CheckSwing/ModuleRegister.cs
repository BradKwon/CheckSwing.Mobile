using CheckSwing.Services;
using Xamarin.Forms;

namespace CheckSwing
{
    public static class ModuleRegister
    {
        public static void RegisterMockModules()
        {
            DependencyService.Register<IDataRepository, DataRepository>();
            DependencyService.Register<IInfoDataStore, MockInfoDataStore>();
            DependencyService.Register<IEventDataStore, MockEventDataStore>();
            DependencyService.Register<IClubDataStore, MockClubDataStore>();
        }
    }
}
