using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Services.SubProductService;
using eShopOnContainers.Core.ViewModels.Base;
using eShopOnContainers.Core.Views;
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
        public ICommand listSubProduct1 { get; }
        public ICommand listSubProduct2 { get; }
        public string SubProduct1 { get; set; }
        public string SubProduct2 { get; set; }
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
        string id;
        public ProductViewModel(ProductItem item)
        {
            this.iD = item.ID;
            id = item.ID;

            getSubProductItems(iD.ToString());

            SubProduct1 = item.SCategori1;
            SubProduct2 = item.SCategori2;

            MyCollectionSelectedCommand = new Command(GenerateNavigations);
            AddCommand = new Command(AddItem);
            AddFavoriteCommand = new Command(AddFavorite);

            listSubProduct1 = new Command(getScategori1Item);
            listSubProduct2 = new Command(getScategori2Item);
        }

        public async void getScategori1Item()
        {
            subProductService = new SubProductService();

            SProducts.Clear();
            SProducts = await subProductService.ListScategori("0", id);
        }

        public async void getScategori2Item()
        {
            subProductService = new SubProductService();

            SProducts.Clear();
            SProducts = await subProductService.ListScategori("1", id);
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
                await Navigation.PushAsync(new DetailPage(selectedItem));
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
