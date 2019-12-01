using CheckSwing.Enums;
using CheckSwing.Models;
using CheckSwing.Services;
using Xamarin.Essentials;

namespace CheckSwing.UnitTest.Services
{
    public class ClubDataStoreTest : DataStoreTest<Club>
    {
        public override void Init()
        {
            DataStore = new MockClubDataStore();
        }

        public override void SetTestItemToBeAdded()
        {
            TestItemToBeAdded = new Club
            {
                Id = "test1",
                Category = ClubCategoryEnum.Club,
                Name = "TEST CLUB",
                Website = "http://m.cafe.naver.com/swingis2",
                ThumbnailUrl = "https://picsum.photos/id/550/300/200",
                ImageUrl = "https://picsum.photos/id/550/800/600",
                Location = new Location(13.339148, 52.501348),
                IsFavorite = true,
            };
        }
    }
}
