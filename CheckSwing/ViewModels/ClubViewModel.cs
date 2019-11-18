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
    public class ClubViewModel : BaseViewModel<Club>
    {
        private readonly ClubCategoryEnum? category;

        public ClubViewModel()
        {
            Title = "동호회";
            Items = new ObservableCollection<Club>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadEventsCommand());
        }

        public ClubViewModel(ClubCategoryEnum category) : this()
        {
            this.category = category;
            if (category == ClubCategoryEnum.Bar) Title = "스윙바";
        }

        async Task ExecuteLoadEventsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await Repository.ClubDataStore.GetItemsAsync(true);

                if (category.HasValue)
                    items = items.Where(d => d.Category == category);

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
