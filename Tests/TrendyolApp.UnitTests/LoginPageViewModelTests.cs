using Autofac.Extras.Moq;
using AutoFixture;
using System;
using TrendyolApp.ViewModels;
using FluentAssertions;
using Xunit;
using TrendyolApp.Services;
using System.Threading.Tasks;
using Autofac;
using Moq;
using TrendyolApp.Services.abstracts;

namespace TrendyolApp.UnitTests
{
    public class LoginPageViewModelTests
    {

        private Fixture _fixture;
        public LoginPageViewModelTests() => _fixture = new Fixture();

        [Fact]
        public void LoginPageViewModel_Username_Should_Be_Empty_First()
        {
           
            using (var mock =AutoMock.GetLoose())
            {
                var vm = mock.Create<LoginPageViewModel>();
                vm.Username.Should().BeNullOrEmpty();
            }
        }

        [Fact]
        public void LoginPageViewModel_Password_Should_Be_Empty_First()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var vm = mock.Create<LoginPageViewModel>();
                vm.Password.Should().BeNullOrEmpty();
            }
        }

        [Fact]
        public void LoginPageViewModel_IsBusy_Should_Be_False_First()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var vm = mock.Create<LoginPageViewModel>();
                vm.IsBusy.Should().BeFalse();
            }
        }

        [Fact]
        public void LoginPageViewModel_WhenSuccessfull_Initializes_LoginCommand_And_RegisterCommand()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var vm = mock.Create<LoginPageViewModel>();

                vm.LoginCommand.Should().NotBeNull();
                vm.RegisterCommand.Should().NotBeNull();
            }
        }

        [Fact]
        public void LoginPageViewModel_Login_Success()
        {
            var userService = new MockUserServiceSuccess();
           
            var vm = new LoginPageViewModel(userService);

             vm.LoginCommand.Execute(null);
            vm.Result.Should().BeTrue();
        }
        [Fact]
        public void LoginPageViewModel_Register_Success()
        {
            var userService = new MockUserServiceSuccess();

            var vm = new LoginPageViewModel(userService);

            vm.RegisterCommand.Execute(null);
            vm.Result.Should().BeTrue();
        }

        [Fact]
        public void LoginPageViewModel_Login_UnSuccess()
        {
            var userService = new MockUserServiceError();

            var vm = new LoginPageViewModel(userService);

            vm.LoginCommand.Execute(null);
            vm.Result.Should().BeFalse();
        }
        [Fact]
        public void LoginPageViewModel_Register_UnSuccess()
        {
            var userService = new MockUserServiceError();

            var vm = new LoginPageViewModel(userService);

            vm.RegisterCommand.Execute(null);
            vm.Result.Should().BeFalse();
        }

    }
    public class MockUserServiceSuccess : IUserService
    {
        public Task<bool> IsUserExists(string uname)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LoginUser(string uname, string passwd)
        {
            return Task.FromResult(true);
        }

        public Task<bool> RegisterUser(string uname, string passwd)
        {
            return Task.FromResult(true);
        }
    }
    public class MockUserServiceError : IUserService
    {
        public Task<bool> IsUserExists(string uname)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LoginUser(string uname, string passwd)
        {
            return Task.FromResult(false);
        }

        public Task<bool> RegisterUser(string uname, string passwd)
        {
            return Task.FromResult(false);
        }
    }
}
