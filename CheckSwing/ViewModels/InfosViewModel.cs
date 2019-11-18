using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using CheckSwing.Models;
using Xamarin.Forms;

namespace CheckSwing.ViewModels
{
    public class InfosViewModel : BaseViewModel<Info>
    {
        public InfosViewModel()
        {
            Title = "스윙댄스";
            Items = new ObservableCollection<Info>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadInfosCommand());

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var newItem = item as Item;
            //    Items.Add(newItem);
            //    await DataStore.AddItemAsync(newItem);
            //});
        }

        async Task ExecuteLoadInfosCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await Repository.InfoDataStore.GetItemsAsync(true);
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
