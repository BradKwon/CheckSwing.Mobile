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
    public abstract class DataStoreTest<T> : IServicesTest<T> where T : IBaseModel
    {
        public IDataStore<T> DataStore { get; set; }
        public T TestItemToBeAdded { get; set; }

        [OneTimeSetUp]
        public abstract void Init();

        [OneTimeSetUp]
        public abstract void SetTestItemToBeAdded();

        [Test]
        public async Task ConstructorTest()
        {
            var items = await DataStore.GetItemsAsync();
            Assert.Greater(items.Count(), 0);
        }

        [Test]
        public virtual async Task AddItemAsyncTest()
        {
            Assert.AreNotEqual(TestItemToBeAdded, null);

            var items = await DataStore.GetItemsAsync();
            int itemCnt = items.Count();

            bool result = await DataStore.AddItemAsync(TestItemToBeAdded);
            Assert.AreEqual(result, true);

            var newItems = await DataStore.GetItemsAsync();
            int newItemCnt = newItems.Count();
            Assert.AreEqual(newItemCnt, itemCnt + 1);

            var addedItem = await DataStore.GetItemAsync(TestItemToBeAdded.Id);
            Assert.AreEqual(addedItem, TestItemToBeAdded);
        }

        [Test]
        public async Task DeleteItemAsyncTest()
        {
            var prevItems = await DataStore.GetItemsAsync();
            int prevItemsCnt = prevItems.Count();

            var item = await GetRandomItem();
            bool result = await DataStore.DeleteItemAsync(item.Id);
            Assert.AreEqual(result, true);

            var deletedItem = await DataStore.GetItemAsync(item.Id);
            Assert.AreEqual(deletedItem, null);

            var newItems = await DataStore.GetItemsAsync();
            int newItemsCnt = newItems.Count();
            Assert.AreEqual(newItemsCnt, prevItemsCnt - 1);
        }

        [Test]
        public async Task GetItemAsyncTest()
        {
            var item = await GetRandomItem();
            var received = await DataStore.GetItemAsync(item.Id);
            Assert.AreEqual(received, item);
        }

        [Test]
        public async Task UpdateItemAsyncTest()
        {
            var info = await GetRandomItem();
            var updatedName = "Updated name";
            info.Name = updatedName;

            bool result = await DataStore.UpdateItemAsync(info);
            Assert.AreEqual(result, true);

            var updatedItem = await DataStore.GetItemAsync(info.Id);
            Assert.AreEqual(updatedItem.Name, updatedName);
        }

        public async Task<T> GetRandomItem()
        {
            var items = await DataStore.GetItemsAsync();

            var item = items.ElementAt(new Random().Next(items.Count() - 1));
            return item;
        }
    }
}
