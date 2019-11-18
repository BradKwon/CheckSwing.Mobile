using System;
using System.Collections.Generic;
using CheckSwing.Models;

namespace CheckSwing.Services
{
    public class MockInfoDataStore : MockBaseDataStore<Info>, IInfoDataStore
    {
        public MockInfoDataStore()
        {
            items = new List<Info>()
            {
                new Info
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "스윙댄스란?",
                    Description = "스윙댄스(Swing Dance)는 1920년대 미국에서 스윙(Swing)이라는 재즈 음악에 맞춰 춤을 추던 것이 100여년에 걸쳐 발전하여 오늘날의 모습을 갖추게 되었습니다. 남녀가 짝을 맞추어 추는 커플댄스이며, 린디합 지터벅 찰스턴 블루스 발보아 등으로 구분됩니다. 헐리우드 영화에 등장하는 커플댄스가 대부분 스윙댄스이며, 국내에는 KBS 드라마 <경성스캔들>과 영화 <모던보이> 등에서 소개된 적이 있습니다."
                },
                new Info
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "스윙댄스 종류?",
                    Description = "스윙댄스(Swing Dance)는 1920년대 미국에서 스윙(Swing)이라는 재즈 음악에 맞춰 춤을 추던 것이 100여년에 걸쳐 발전하여 오늘날의 모습을 갖추게 되었습니다. 남녀가 짝을 맞추어 추는 커플댄스이며, 린디합 지터벅 찰스턴 블루스 발보아 등으로 구분됩니다. 헐리우드 영화에 등장하는 커플댄스가 대부분 스윙댄스이며, 국내에는 KBS 드라마 <경성스캔들>과 영화 <모던보이> 등에서 소개된 적이 있습니다."
                },
                new Info
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "스윙댄스 강습 및 가격?",
                    Description = "스윙댄스(Swing Dance)는 1920년대 미국에서 스윙(Swing)이라는 재즈 음악에 맞춰 춤을 추던 것이 100여년에 걸쳐 발전하여 오늘날의 모습을 갖추게 되었습니다. 남녀가 짝을 맞추어 추는 커플댄스이며, 린디합 지터벅 찰스턴 블루스 발보아 등으로 구분됩니다. 헐리우드 영화에 등장하는 커플댄스가 대부분 스윙댄스이며, 국내에는 KBS 드라마 <경성스캔들>과 영화 <모던보이> 등에서 소개된 적이 있습니다."
                },
                new Info
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "스윙댄스 복장?",
                    Description = "스윙댄스(Swing Dance)는 1920년대 미국에서 스윙(Swing)이라는 재즈 음악에 맞춰 춤을 추던 것이 100여년에 걸쳐 발전하여 오늘날의 모습을 갖추게 되었습니다. 남녀가 짝을 맞추어 추는 커플댄스이며, 린디합 지터벅 찰스턴 블루스 발보아 등으로 구분됩니다. 헐리우드 영화에 등장하는 커플댄스가 대부분 스윙댄스이며, 국내에는 KBS 드라마 <경성스캔들>과 영화 <모던보이> 등에서 소개된 적이 있습니다."
                },
                new Info
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "몸치시라구요?",
                    Description = "스윙댄스(Swing Dance)는 1920년대 미국에서 스윙(Swing)이라는 재즈 음악에 맞춰 춤을 추던 것이 100여년에 걸쳐 발전하여 오늘날의 모습을 갖추게 되었습니다. 남녀가 짝을 맞추어 추는 커플댄스이며, 린디합 지터벅 찰스턴 블루스 발보아 등으로 구분됩니다. 헐리우드 영화에 등장하는 커플댄스가 대부분 스윙댄스이며, 국내에는 KBS 드라마 <경성스캔들>과 영화 <모던보이> 등에서 소개된 적이 있습니다."
                },
            };
        }
    }
}
