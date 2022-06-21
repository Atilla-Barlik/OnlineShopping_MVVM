using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eShopOnContainers.Core.Services.SubProductService
{
    public class SubProductService : ISubProductService
    {
        string id;
        ObservableCollection<SubProductItem> sProducts;

        public Task<ObservableCollection<SubProductItem>> AddBasket(SubProductItem subProductItem)
        {
            if (subProductItem == null)
                return null;
            else
            {
                App.Current.MainPage.DisplayAlert("Açıklama", subProductItem.Product + " sepete eklendi.", "Ok");
                Model.list.Add(subProductItem);
                return null;
            }
        }

        public Task<ObservableCollection<SubProductItem>> GetSubProduct(string id)
        {
            this.id = id;
            sProducts = new ObservableCollection<SubProductItem>();
            foreach (var item in searchListModel.list)
            {
                if (item.ID == id.ToString())
                {
                    sProducts.Add(item);
                }
            }



            return Task.FromResult(sProducts);

        }

        public Task<ObservableCollection<SubProductItem>> AddFavorite(string Product)
        {

            foreach (var item in searchListModel.list)
            {
                if (Product == item.Product)
                {
                    item.Favorite = "1";
                }
            }
            App.Current.MainPage.DisplayAlert("Açıklama", Product + " favorilere eklendi.", "Ok");
            return null;
        }
    }
}
