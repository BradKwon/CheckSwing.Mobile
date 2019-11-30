using System;
using CheckSwing.Services;
using NUnit.Framework;
using Xamarin.Forms;

namespace CheckSwing.UnitTest.Services
{
    [Category("Services")]
    public class InfoDataStoreTest
    {
        IInfoDataStore _infoDataStore;

        [SetUp]
        public void Setup()
        {
            DependencyService.Register<MockInfoDataStore>();
        }

        [Test]
        public void ConstructorTest()
        {

        }
    }
}
