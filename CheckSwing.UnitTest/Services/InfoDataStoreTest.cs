using System;
using System.Linq;
using System.Threading.Tasks;
using CheckSwing.Models;
using CheckSwing.Services;
using NUnit.Framework;

namespace CheckSwing.UnitTest.Services
{
    [Category("Services")]
    [TestFixture]
    public class InfoDataStoreTest : IServicesTest
    {
        IInfoDataStore _infoDataStore;

        [OneTimeSetUp]
        public void Init()
        {
            _infoDataStore = new MockInfoDataStore();
        }

        [Test]
        public async Task ConstructorTest()
        {
            var items = await _infoDataStore.GetItemsAsync();
            Assert.Greater(items.Count(), 0);
        }

        [Test]
        public async Task GetItemAsyncTest()
        {
            var info = await GetRandomInfo();
            var received = await _infoDataStore.GetItemAsync(info.Id);
            Assert.AreEqual(received, info);
        }

        [Test]
        public async Task AddItemAsyncTest()
        {
            var info = new Info
            {
                Id = "test1",
                Name = "Test info",
                Description = "This is test info item",
                ImageUrl = "",
            };

            var items = await _infoDataStore.GetItemsAsync();
            int itemCnt = items.Count();

            bool result = await _infoDataStore.AddItemAsync(info);
            Assert.AreEqual(result, true);

            var newItems = await _infoDataStore.GetItemsAsync();
            int newItemCnt = newItems.Count();
            Assert.AreEqual(newItemCnt, itemCnt + 1);

            var newItem = await _infoDataStore.GetItemAsync(info.Id);
            Assert.AreEqual(newItem, info);
        }

        [Test]
        public async Task UpdateItemAsyncTest()
        {
            var info = await GetRandomInfo();
            var updatedName = "Updated name";
            info.Name = updatedName;

            bool result = await _infoDataStore.UpdateItemAsync(info);
            Assert.AreEqual(result, true);

            var updatedItem = await _infoDataStore.GetItemAsync(info.Id);
            Assert.AreEqual(updatedItem.Name, updatedName);
        }

        [Test]
        public async Task DeleteItemAsyncTest()
        {
            var prevItems = await _infoDataStore.GetItemsAsync();
            int prevItemsCnt = prevItems.Count();

            var info = await GetRandomInfo();
            bool result = await _infoDataStore.DeleteItemAsync(info.Id);
            Assert.AreEqual(result, true);

            var deletedItem = await _infoDataStore.GetItemAsync(info.Id);
            Assert.AreEqual(deletedItem, null);

            var newItems = await _infoDataStore.GetItemsAsync();
            int newItemsCnt = newItems.Count();
            Assert.AreEqual(newItemsCnt, prevItemsCnt - 1);
        }

        async Task<Info> GetRandomInfo()
        {
            var infos = await _infoDataStore.GetItemsAsync();

            var info = infos.ElementAt(new Random().Next(infos.Count() - 1));
            return info;
        }
    }
}
