using System;
using System.Collections.Generic;
using CheckSwing.Enums;
using CheckSwing.Models;

namespace CheckSwing.Services
{
    public class MockEventDataStore : MockBaseDataStore<Event>, IEventDataStore
    {
        public MockEventDataStore()
        {
            items = new List<Event>
            {
                new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "스윙하일 어플 알파 오픈!",
                    Category = ClubCategoryEnum.AppNotice,
                    ThumbnailUrl = "https://picsum.photos/id/0/300/200",
                    ImageUrl = "https://picsum.photos/id/0/800/600",
                    PostedDate = DateTime.Now,
                    CategoryIcon = "ic_group_fill",
                    Description = "이전까지 없었던 스윙댄스 어플인 스윙하일 알파 버전 오픈!"
                },
                new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "[파티] 두둥, 창원 스윙댄스 동호회 1주년 기념 파티",
                    Category = ClubCategoryEnum.Bar,
                    ThumbnailUrl = "https://picsum.photos/id/10/300/200",
                    ImageUrl = "https://picsum.photos/id/10/800/600",
                    PostedDate = DateTime.Now.AddDays(-1),
                    CategoryIcon = "ic_cocktail_fill",
                    Description = "창원스윙댄스 동호회가 어느덧 첫 돌을 맞이했습니다.",
                    ClubId = "bar-1",
                },
                new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "[안내] 2014 하반기 스윙트리 지인 소개왕창",
                    Category = ClubCategoryEnum.Club,
                    ThumbnailUrl = "https://picsum.photos/id/200/300/200",
                    ImageUrl = "https://picsum.photos/id/200/800/600",
                    PostedDate = DateTime.Now.AddDays(-2),
                    CategoryIcon = "ic_group_fill",
                    Description = "안녕하십니까 스윙트리 회원 여러분 다사다난했던 2014년...",
                    ClubId = "club-1",
                },
                new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "[파티] 2014년 미리 Merry Christmas Party",
                    Category = ClubCategoryEnum.Bar,
                    ThumbnailUrl = "https://picsum.photos/id/33/300/200",
                    ImageUrl = "https://picsum.photos/id/33/800/600",
                    PostedDate = DateTime.Now.AddDays(-3),
                    CategoryIcon = "ic_cocktail_fill",
                    Description = "** 미리 Merry Christmas ** 창원스윙이 맞이하며...",
                    ClubId = "club-2",
                },
                new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "24기 지터벅 강사를 공개 모집합니다.",
                    Category = ClubCategoryEnum.Club,
                    ThumbnailUrl = "https://picsum.photos/id/44/300/200",
                    ImageUrl = "https://picsum.photos/id/44/800/600",
                    PostedDate = DateTime.Now.AddDays(-4),
                    CategoryIcon = "ic_group_fill",
                    Description = "24기 지터벅 강사를 공개 모집합니다. 스윙트리에 새로운...",
                    ClubId = "club-1",
                },
            };
        }
    }
}
