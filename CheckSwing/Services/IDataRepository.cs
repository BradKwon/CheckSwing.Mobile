namespace CheckSwing.Services
{
    public interface IDataRepository
    {
        IInfoDataStore InfoDataStore { get; }
        IEventDataStore EventDataStore { get; }
        IClubDataStore ClubDataStore { get; }
    }
}
