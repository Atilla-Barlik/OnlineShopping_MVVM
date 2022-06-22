using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Services.SubProductService;
using eShopOnContainers.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {
        private ObservableCollection<SubProductItem> sProducts;
        private object iD;
        INavigation Navigation => Application.Current.MainPage.Navigation;
        ISubProductService subProductService;
        public ICommand MyCollectionSelectedCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand AddFavoriteCommand { get; }
        public ObservableCollection<SubProductItem> SProducts
        {
            get => sProducts;
            set
            {
                if (value == SProducts) return;
                sProducts = value;

                OnPropertyChanged();
            }

        }

        public ProductViewModel(object iD)
        {
            this.iD = iD;

            getSubProductItems(iD.ToString());

            MyCollectionSelectedCommand = new Command(GenerateNavigations);
            AddCommand = new Command(AddItem);
            AddFavoriteCommand = new Command(AddFavorite);
        }



        public async void getSubProductItems(string id)
        {
            subProductService = new SubProductService();

            SProducts = await subProductService.GetSubProduct(id.ToString());
        }

        private async void GenerateNavigations(object obj)
        {
            var selectedItem = obj as SubProductItem;

            if (selectedItem == null)
                return;
            else
            {
                //await Navigation.PushAsync(new DetailPage(selectedItem));
            }
        }

        private async void AddItem(object obj)
        {
            var selectedItem = obj as SubProductItem;
            subProductService.AddBasket(selectedItem);
        }

        private async void AddFavorite(object obj)
        {
            var selectedItem = obj as SubProductItem;
            subProductService.AddFavorite(selectedItem.Product);
        }
    }
}
