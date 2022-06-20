using eShopOnContainers.Core.ViewModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eShopOnContainers.Core.Views
{
    public partial class LoginView : ContentPage
    {
        private bool _animate;

        public LoginView()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }

       
    }
}