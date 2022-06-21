using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.ViewModels.Base;
using eShopOnContainers.Core.Views;
using MobileGUI.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public  class MainPageViewModel:ViewModelBase
    {
        private ObservableCollection<ProductItem> obProducts;
        private ObservableCollection<Carousel> carouselItems;
        IProductService productService;

        public ObservableCollection<Carousel> CarouselItems
        {
            get => carouselItems;
            set
            {
                if (value == CarouselItems) return;
                carouselItems = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<ProductItem> ObProducts
        {
            get => obProducts;
            set
            {
                if (value == ObProducts) return;
                obProducts = value;
                OnPropertyChanged();
            }
        }


        public ICommand MyCollectionSelectedCommand { get; }

        public MainPageViewModel()
        {

            deneme();

            MyCollectionSelectedCommand = new Command(GenerateNavigations);
        }
        INavigation Navigation => Application.Current.MainPage.Navigation;

        private async void GenerateNavigations(object obj)
        {
            var selectedItem = obj as ProductItem;

            if (selectedItem == null)
                return;
            else
            {
                await Navigation.PushAsync(new ProductPage(selectedItem.ID));
            }
        }


        public async void deneme()
        {
            productService = new ProductService();
            CarouselItems = await productService.GetCarouselItems();
            ObProducts = await productService.GetProduct();
        }
    }
}
