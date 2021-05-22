using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrendyolApp.ViewModels;

namespace TrendyolApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var viewModel = mock.Create<LoginPageViewModel>();
                viewModel.Username.Should().BeEmpty();
            }
        }
    }
}
