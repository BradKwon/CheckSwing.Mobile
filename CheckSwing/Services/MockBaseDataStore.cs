using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckSwing.Models;

namespace CheckSwing.Services
{
    public class MockBaseDataStore<T> : IDataStore<T> where T : IBaseModel
    {
        protected List<T> items;

        public async Task<bool> AddItemAsync(T item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((T arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<T> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

        public async Task<bool> UpdateItemAsync(T item)
        {
            var oldInfo = items.Where((T arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldInfo);
            items.Add(item);

            return await Task.FromResult(true);
        }
    }
}
