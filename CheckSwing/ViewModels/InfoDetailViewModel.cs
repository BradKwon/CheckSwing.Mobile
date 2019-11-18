using CheckSwing.Models;

namespace CheckSwing.ViewModels
{
    public class InfoDetailViewModel : BaseViewModel<Info>
    {
        public Info Info { get; set; }
        public InfoDetailViewModel(Info info = null)
        {
            Title = info?.Name;
            Info = info;
        }
    }
}
