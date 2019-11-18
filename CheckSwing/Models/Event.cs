using System;
using CheckSwing.Enums;

namespace CheckSwing.Models
{
    public class Event : IBaseModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ImageUrl { get; set; }
        public ClubCategoryEnum Category { get; set; }
        public string CategoryIcon { get; set; }
        public string ClubId { get; set; }
        public DateTime PostedDate { get; set; }
    }
}
