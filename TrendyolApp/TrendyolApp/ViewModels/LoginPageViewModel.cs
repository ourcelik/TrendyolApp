using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TrendyolApp.Services;
using TrendyolApp.View;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TrendyolApp.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        readonly string facebook = "Facebook \nile bağlan";
        public string Facebook
        {
            get { return facebook; }
        }
        readonly string google = "Google \nile bağlan";
        public string Google
        {
            get { return google; }
        }
        private string username;
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
        private string password;
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
        private bool isBusy;
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
        private bool result;
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
        public Command  LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }
        public LoginPageViewModel()
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
                var userService = new UserService();
                Result = await userService.RegisterUser(Username, Password);
                if (Result)
                {
                    await Application.Current.MainPage.DisplayAlert("Success", "User Registered", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "User already exists", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
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
                var userService = new UserService();
                Result = await userService.LoginUser(Username, Password);
                if (Result)
                {
                    Preferences.Set("Username", Username);
                    Preferences.Set("Registered", true);
                    Application.Current.MainPage = new TabPage();
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
