using System;
using CheckSwing.Enums;
using CheckSwing.Models;
using CheckSwing.Services;

namespace CheckSwing.UnitTest.Services
{
    public class EventDataStoreTest : DataStoreTest<Event>
    {
        public override void Init()
        {
            DataStore = new MockEventDataStore();
        }

        public override void SetTestItemToBeAdded()
        {
            TestItemToBeAdded = new Event
            {
                Id = "test1",
                Name = "TEST EVENT",
                Category = ClubCategoryEnum.AppNotice,
                ThumbnailUrl = "https://picsum.photos/id/0/300/200",
                ImageUrl = "https://picsum.photos/id/0/800/600",
                PostedDate = DateTime.Now,
                CategoryIcon = "ic_group_fill",
                Description = "TEST EVENT DESCRIPTION"
            };
        }
    }
}
