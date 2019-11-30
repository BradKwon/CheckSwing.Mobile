using System.Linq;
using CheckSwing.Services;
using NUnit.Framework;

namespace CheckSwing.UnitTest.Services
{
    [TestFixture]
    [Category("Services")]
    public class InfoDataStoreTest
    {
        IInfoDataStore _infoDataStore;

        [OneTimeSetUp]
        public void Init()
        {
            _infoDataStore = new MockInfoDataStore();
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.Greater(_infoDataStore.GetItemsAsync().Result.Count(), 0);
        }
    }
}
