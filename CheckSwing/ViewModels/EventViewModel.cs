using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using CheckSwing.Models;
using Xamarin.Forms;

namespace CheckSwing.ViewModels
{
    public class EventViewModel : BaseViewModel<Event>
    {
        public EventViewModel()
        {
            Title = "이벤트";
            Items = new ObservableCollection<Event>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadEventsCommand());
        }

        async Task ExecuteLoadEventsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await Repository.EventDataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
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
