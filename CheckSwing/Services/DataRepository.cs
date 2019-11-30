using Xamarin.Forms;

namespace CheckSwing.Services
{
    public class DataRepository : IDataRepository
    {
        public IInfoDataStore InfoDataStore => DependencyService.Resolve<IInfoDataStore>();
        public IEventDataStore EventDataStore => DependencyService.Resolve<IEventDataStore>();
        public IClubDataStore ClubDataStore => DependencyService.Resolve<IClubDataStore>();
    }
}
