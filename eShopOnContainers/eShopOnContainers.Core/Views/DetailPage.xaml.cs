using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        private SubProductItem selectedItem;
        public DetailPage(SubProductItem selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;
            BindingContext = new DetailPageViewModel(selectedItem);
        }
    }
}