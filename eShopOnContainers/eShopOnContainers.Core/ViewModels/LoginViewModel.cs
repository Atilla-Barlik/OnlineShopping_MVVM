using eShopOnContainers.Core.Extensions;
using eShopOnContainers.Core.Interfaces;
using eShopOnContainers.Core.Models.User;
using eShopOnContainers.Core.Services.Identity;
using eShopOnContainers.Core.Services.OpenUrl;
using eShopOnContainers.Core.Services.Settings;
using eShopOnContainers.Core.Validations;
using eShopOnContainers.Core.ViewModels.Base;
using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string deneme { get; set; }

        public Command checkValue { get; set; }
        public Command signIn { get; set; }

        public LoginViewModel()
        {


            checkValue = new Command(() =>
            {
                deneme = Email + " " + Password;
                Register();

                OnPropertyChanged(nameof(deneme));
            });

            signIn = new Command(() =>
            {
                Login();
            });

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        public async void Register()
        {
            var fblogin = DependencyService.Get<IFirebase>();
            string token = await fblogin.Register(Email, Password);

            await Application.Current.MainPage.DisplayAlert("Kayıt Durumu", token, "OK");

        }
        public async void Login()
        {
            var fblogin = DependencyService.Get<IFirebase>();
            string token = await fblogin.Login(Email, Password);
            if (token.Length > 500)
            {
                //await Application.Current.MainPage.Navigation.PushAsync(new AboutPage());
                //await Shell.Current.GoToAsync("..");
                await Shell.Current.GoToAsync("//Main/Catalog");

            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Giriş Hatası", token, "OK");
            }
        }
    }
}