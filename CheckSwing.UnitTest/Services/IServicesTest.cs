using System.Threading.Tasks;

namespace CheckSwing.UnitTest.Services
{
    public interface IServicesTest
    {
        public void Init();
        public Task ConstructorTest();
        public Task GetItemAsyncTest();
        public Task AddItemAsyncTest();
        public Task UpdateItemAsyncTest();
        public Task DeleteItemAsyncTest();
    }
}
