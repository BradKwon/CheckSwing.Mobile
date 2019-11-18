using System;
using System.Collections.Generic;
using CheckSwing.Enums;
using CheckSwing.Models;
using Xamarin.Essentials;

namespace CheckSwing.Services
{
    public class MockClubDataStore : MockBaseDataStore<Club>, IClubDataStore
    {
        public MockClubDataStore()
        {
            items = new List<Club>
            {
                new Club
                {
                    Id = "club-1",
                    Category = ClubCategoryEnum.Club,
                    Name = "스윙 트리 (Swing Tree)",
                    Region = "서울 광진구",
                    Address = "서울특별시 광진구 광진로 14",
                    Website = "http://m.cafe.naver.com/swingis2",
                    ThumbnailUrl = "https://picsum.photos/id/550/300/200",
                    ImageUrl = "https://picsum.photos/id/550/800/600",
                    Location = new Location(13.339148, 52.501348),
                    IsFavorite = false,
                },
                new Club
                {
                    Id = "club-2",
                    Category = ClubCategoryEnum.Club,
                    Name = "스윙 에이드 (Swing Ade)",
                    Region = "서울 서초구",
                    Address = "서울특별시 서초구 서초로 14",
                    Website = "http://m.cafe.naver.com/swingis2",
                    ThumbnailUrl = "https://picsum.photos/id/250/300/200",
                    ImageUrl = "https://picsum.photos/id/250/800/600",
                    Location = new Location(13.339148, 52.501348),
                    IsFavorite = true,
                },
                new Club
                {
                    Id = "club-3",
                    Category = ClubCategoryEnum.Club,
                    Name = "딴따라 댄스홀 강남",
                    Region = "서울 강남구",
                    Address = "서울특별시 강남구 강남로 14",
                    Website = "http://m.cafe.naver.com/swingis2",
                    ThumbnailUrl = "https://picsum.photos/id/180/300/200",
                    ImageUrl = "https://picsum.photos/id/180/800/600",
                    Location = new Location(13.339148, 52.501348),
                    IsFavorite = false,
                },
                new Club
                {
                    Id = "club-4",
                    Category = ClubCategoryEnum.Club,
                    Name = "링고팝 스윙 (RingoPop Swing)",
                    Region = "서울 강남구",
                    Address = "서울특별시 강남구 강남로 24",
                    Website = "http://m.cafe.naver.com/swingis2",
                    ThumbnailUrl = "https://picsum.photos/id/280/300/200",
                    ImageUrl = "https://picsum.photos/id/280/800/600",
                    Location = new Location(13.339148, 52.501348),
                    IsFavorite = false,
                },
                new Club
                {
                    Id = "club-5",
                    Category = ClubCategoryEnum.Club,
                    Name = "박쥐 스윙 (Bat Swing)",
                    Region = "서울 강남구",
                    Address = "서울특별시 강남구 강남로 34",
                    Website = "http://m.cafe.naver.com/swingis2",
                    ThumbnailUrl = "https://picsum.photos/id/380/300/200",
                    ImageUrl = "https://picsum.photos/id/380/800/600",
                    Location = new Location(13.339148, 52.501348),
                    IsFavorite = false,
                },
                new Club
                {
                    Id = "club-6",
                    Category = ClubCategoryEnum.Club,
                    Name = "보헤미안 (Bohemian)",
                    Region = "서울 관악구",
                    Address = "서울특별시 관악구 관악로 34",
                    Website = "http://m.cafe.naver.com/swingis2",
                    ThumbnailUrl = "https://picsum.photos/id/480/300/200",
                    ImageUrl = "https://picsum.photos/id/480/800/600",
                    Location = new Location(13.339148, 52.501348),
                    IsFavorite = false,
                },
                new Club
                {
                    Id = "club-7",
                    Category = ClubCategoryEnum.Club,
                    Name = "비바 스윙 (Viva Swing)",
                    Region = "서울 송파구",
                    Address = "서울특별시 송파구 송파로 34",
                    Website = "http://m.cafe.naver.com/swingis2",
                    ThumbnailUrl = "https://picsum.photos/id/420/300/200",
                    ImageUrl = "https://picsum.photos/id/420/800/600",
                    Location = new Location(13.339148, 52.501348),
                    IsFavorite = false,
                },
                new Club
                {
                    Id = "bar-1",
                    Category = ClubCategoryEnum.Bar,
                    Name = "스윙 라떼 (Swing Latte)",
                    Region = "창원 의창구",
                    Address = "창원시 의창구 의창로 34",
                    Website = "http://m.cafe.naver.com/swingis2",
                    ThumbnailUrl = "https://picsum.photos/id/45/300/200",
                    ImageUrl = "https://picsum.photos/id/45/800/600",
                    Location = new Location(13.339148, 52.501348),
                    IsFavorite = true,
                },
                new Club
                {
                    Id = "bar-2",
                    Category = ClubCategoryEnum.Bar,
                    Name = "더 홀릭 바 (The Holic Bar)",
                    Region = "서울 서초구",
                    Address = "서울특별시 서초구 서초로 44",
                    Website = "http://m.cafe.naver.com/swingis2",
                    ThumbnailUrl = "https://picsum.photos/id/75/300/200",
                    ImageUrl = "https://picsum.photos/id/75/800/600",
                    Location = new Location(13.339148, 52.501348),
                    IsFavorite = false,
                },
                new Club
                {
                    Id = "bar-3",
                    Category = ClubCategoryEnum.Bar,
                    Name = "링고 팝 (Ringo Pop)",
                    Region = "서울 강남구",
                    Address = "서울특별시 강남구 강남로 44",
                    Website = "http://m.cafe.naver.com/swingis2",
                    ThumbnailUrl = "https://picsum.photos/id/125/300/200",
                    ImageUrl = "https://picsum.photos/id/125/800/600",
                    Location = new Location(13.339148, 52.501348),
                    IsFavorite = false,
                },
                new Club
                {
                    Id = "bar-4",
                    Category = ClubCategoryEnum.Bar,
                    Name = "바운스 블루 (Bounce Blue)",
                    Region = "서울 송파구",
                    Address = "서울특별시 송파구 송파로 44",
                    Website = "http://m.cafe.naver.com/swingis2",
                    ThumbnailUrl = "https://picsum.photos/id/165/300/200",
                    ImageUrl = "https://picsum.photos/id/165/800/600",
                    Location = new Location(13.339148, 52.501348),
                    IsFavorite = false,
                },
                new Club
                {
                    Id = "bar-5",
                    Category = ClubCategoryEnum.Bar,
                    Name = "부기우기 (Boogie Woogie Bar)",
                    Region = "서울 관악구",
                    Address = "서울특별시 관악구 관악로 44",
                    Website = "http://m.cafe.naver.com/swingis2",
                    ThumbnailUrl = "https://picsum.photos/id/195/300/200",
                    ImageUrl = "https://picsum.photos/id/195/800/600",
                    Location = new Location(13.339148, 52.501348),
                    IsFavorite = false,
                },
            };
        }
    }
}
