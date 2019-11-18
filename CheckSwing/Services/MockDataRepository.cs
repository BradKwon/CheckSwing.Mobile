namespace CheckSwing.Services
{
    public class MockDataRepository : IDataRepository
    {
        private IInfoDataStore infoDataStore;
        public IInfoDataStore InfoDataStore
        {
            get
            {
                if (infoDataStore == null)
                    infoDataStore = new MockInfoDataStore();
                return infoDataStore;
            }
        }

        private IEventDataStore eventDataStore;
        public IEventDataStore EventDataStore
        {
            get
            {
                if (eventDataStore == null)
                    eventDataStore = new MockEventDataStore();
                return eventDataStore;
            }
        }

        private IClubDataStore clubDataStore;
        public IClubDataStore ClubDataStore
        {
            get
            {
                if (clubDataStore == null)
                    clubDataStore = new MockClubDataStore();
                return clubDataStore;
            }
        }
    }
}
