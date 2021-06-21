using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TrendyolApp.Services;
using TrendyolApp.Services.abstracts;
using TrendyolApp.View;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TrendyolApp.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        #region Variables
        readonly string facebook = "Facebook \nile bağlan";
        readonly string google = "Google \nile bağlan";
        private string username;
        private string password;
        private bool isBusy;
        private bool result;
        #endregion
        #region Props
        public string Facebook
        {
            get { return facebook; }
        }
        public string Google
        {
            get { return google; }
        }
        public string Username
        {
            set
            {
                this.username = value;
                OnPropertyChanged();
            }
            get
            {
                return this.username;
            }
        }
        public string Password
        {
            set
            {
                this.password = value;
                OnPropertyChanged();
            }
            get
            {
                return this.password;
            }
        }
        public bool IsBusy
        {
            set
            {
                this.isBusy = value;
                OnPropertyChanged();
            }
            get
            {
                return this.isBusy;
            }
        }
        public bool Result
        {
            set
            {
                this.result = value;
                OnPropertyChanged();
            }
            get
            {
                return this.result;
            }
        }
        #endregion
        #region Commands
        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; } 
        #endregion
        private IUserService _userService { get; set; }
        
        public LoginPageViewModel(IUserService userService)
        {
            _userService = userService;
            DefineCommands();
        }

        private void DefineCommands()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
            RegisterCommand = new Command(async () => await RegisterCommandAsync());
        }

        private async Task RegisterCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                //var userService = new UserService();
                Result = await _userService.RegisterUser(Username, Password);
                if (Result)
                {
                    await Application.Current.MainPage.DisplayAlert("Success", "User Registered", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "User already exists", "OK");
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task LoginCommandAsync()
        {

            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                //var userService = new UserService();
                Result = await _userService.LoginUser(Username, Password);
                if (Result)
                {
                    Preferences.Set("Username", Username);
                    Preferences.Set("Registered", true);
                    Application.Current.MainPage = new TabPage();
                }
            }
            catch (Exception)
            {
                

            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
