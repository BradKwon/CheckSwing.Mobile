using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CheckSwing.Enums;
using CheckSwing.Models;
using Xamarin.Forms;

namespace CheckSwing.ViewModels
{
    public class ClubDetailViewModel : BaseDetailViewModel<Club, Event>
    {
        public string DetailItemsTitle { get; }

        public ClubDetailViewModel(Club club)
        {
            Title = club?.Name;
            Item = club;

            if (club.Category == ClubCategoryEnum.Bar) DetailItemsTitle = "스윙바 공지";
            else DetailItemsTitle = "동호회 공지";

            DetailItems = new ObservableCollection<Event>();
            LoadDetailItemsCommand = new Command(async () => await ExecuteLoadEventsCommand());
        }

        async Task ExecuteLoadEventsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                DetailItems.Clear();
                var events = await Repository.EventDataStore.GetItemsAsync(true);
                events = events.Where(d => d.ClubId == Item.Id);

                foreach (var item in events)
                {
                    DetailItems.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
