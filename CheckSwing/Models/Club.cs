using CheckSwing.Enums;
using Xamarin.Essentials;

namespace CheckSwing.Models
{
    public class Club : IBaseModel
    {
        public string Id { get; set; }
        public ClubCategoryEnum Category { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public string PublicTransportation { get; set; }
        public string Website { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ImageUrl { get; set; }
        public Location Location { get; set; }
        public bool IsFavorite { get; set; }
    }
}
