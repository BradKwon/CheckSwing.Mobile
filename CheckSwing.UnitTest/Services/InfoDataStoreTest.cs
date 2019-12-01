using CheckSwing.Models;
using CheckSwing.Services;

namespace CheckSwing.UnitTest.Services
{
    public class InfoDataStoreTest : DataStoreTest<Info>
    {
        public override void Init()
        {
            DataStore = new MockInfoDataStore();
        }

        public override void SetTestItemToBeAdded()
        {
            TestItemToBeAdded = new Info
            {
                Id = "test1",
                Name = "Test info",
                Description = "This is test info item",
                ImageUrl = "",
            };
        }
    }
}
