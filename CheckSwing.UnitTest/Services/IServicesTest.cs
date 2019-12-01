using System.Threading.Tasks;
using CheckSwing.Services;

namespace CheckSwing.UnitTest.Services
{
    public interface IServicesTest<T>
    {
        public IDataStore<T> DataStore { get; set; }
        public T TestItemToBeAdded { get; set; }

        public void Init();
        public void SetTestItemToBeAdded();
        public Task ConstructorTest();
        public Task GetItemAsyncTest();
        public Task AddItemAsyncTest();
        public Task UpdateItemAsyncTest();
        public Task DeleteItemAsyncTest();
        public Task<T> GetRandomItem();
    }
}
